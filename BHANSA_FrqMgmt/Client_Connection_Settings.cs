using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;

namespace BHANSA_FrqMgmt
{
    public partial class Client_Connection_Settings : Form
    {
        private static bool KeepGoing = false;
        private static bool RequestStop = false;

        // Define UDP-Multicast RCV connection variables
        private static UdpClient rcv_sock;
        private static IPEndPoint rcv_iep;

        // Same buffer is used for sending and receiving
        private static byte[] UDPBuffer;

        // Define the main listener thread
        private static Thread ListenForDataThread;

        private static int BytesProcessed;

        public Client_Connection_Settings()
        {
            InitializeComponent();
        }

        private void Client_Connection_Settings_Load(object sender, EventArgs e)
        {

        }

        private void Client_Connection_Settings_VisibleChanged(object sender, EventArgs e)
        {
            comboBoxNetworkInterface.Items.Clear();

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            comboBoxNetworkInterface.Items.Add(ip.Address.ToString());
                        }
                    }
                }
            }
            if (comboBoxNetworkInterface.Items.Count > 0)
                comboBoxNetworkInterface.SelectedIndex = Properties.Settings.Default.Client_Interface_Index;

            txtboxServerMulticastAddress.Text = Properties.Settings.Default.Client_Multicast_Address;
            textboxServerMulticastPort.Text = Properties.Settings.Default.Client_Port;
            textBoxClientMulticastAddress.Text = Properties.Settings.Default.Client_Brodacast_Address;
            textBoxClientMulticastPort.Text = Properties.Settings.Default.Client_Broadcast_Port;
        }

        public static bool StartListening(IPAddress Interface_Addres,  // IP address of the interface where the data is expected
                                      IPAddress Multicast_Address, // Multicast address of the expected data
                                      int PortNumber)              // Port number of the forwarded data
        {



            // Open up a new socket with the net IP address and port number   
            try
            {
                rcv_sock = new UdpClient(PortNumber);
                rcv_sock.JoinMulticastGroup(Multicast_Address, Interface_Addres);
                rcv_iep = new IPEndPoint(IPAddress.Any, PortNumber);
            }
            catch
            {
                MessageBox.Show("Not possible! Make sure given IP address/port is a valid one on your system or not already used by some other process");
                return false;
            }

            KeepGoing = true;
            Shared_Data.Is_Connected = true;
            RequestStop = false;
            ListenForDataThread = new Thread(new ThreadStart(DOWork));
            ListenForDataThread.Start();

            return true;
        }

        private static void DOWork()
        {
            while (KeepGoing)
            {
                // OK user requested that we terminate 
                // recording, so lets do it
                if (RequestStop == true)
                    KeepGoing = false;
                else
                {
                    try
                    {
                        // Lets receive data in an array of bytes 
                        // (an octet, of course composed of 8bits)
                        UDPBuffer = rcv_sock.Receive(ref rcv_iep);
                        Shared_Data.Received_Data_List_From_Server.Clear();
                        BytesProcessed = BytesProcessed + UDPBuffer.Length;

                        string[] words = System.Text.Encoding.Default.GetString(UDPBuffer).Split(',');

                        foreach (string S in words)
                        Shared_Data.Received_Data_List_From_Server.Add(S);
                        Shared_Data.Update_Log_Window = true;
                        Shared_Data.Update_Main_Data_Display = true;
                    }
                    catch
                    {
                        //MessageBox.Show("Issue in DoWork");
                    }
                }
            }

            Cleanup();
        }

        private static void Cleanup()
        {
            // Do a cleanup
            if (rcv_sock != null)
                rcv_sock.Close();
        }

        private void btnConnectServerBroadcast_Click(object sender, EventArgs e)
        {
            if (this.btnConnectServerBroadcast.Text == "Connect")
            {
                bool Input_Validated = true;

                // First make sure that all boxes are filled out
                if ((!string.IsNullOrEmpty(this.txtboxServerMulticastAddress.Text)) &&
                     (!string.IsNullOrEmpty(this.comboBoxNetworkInterface.Text)) &&
                    (!string.IsNullOrEmpty(this.textboxServerMulticastPort.Text)))
                {
                    IPAddress IP;
                    IPAddress Multicast;
                    // Validate that a valid IP address is entered
                    if ((IPAddress.TryParse(this.txtboxServerMulticastAddress.Text, out Multicast) != true) || (IPAddress.TryParse(this.comboBoxNetworkInterface.Text, out IP) != true))
                    {
                        MessageBox.Show("Not a valid IP address");
                        Input_Validated = false;
                    }
                    else // Add a check that this is a valid multicast address
                    {
                        UdpClient TempSock;
                        TempSock = new UdpClient(2223);// Port does not matter
                        // Open up a new socket with the net IP address and port number   
                        try
                        {
                            TempSock.JoinMulticastGroup(Multicast, 50); // 50 is TTL value
                        }
                        catch
                        {
                            MessageBox.Show("Not valid Multicast address (has to be in range 224.0.0.0 to 239.255.255.255");
                            Input_Validated = false;
                            TempSock.Close();
                        }
                        TempSock.Close();
                    }

                    int PortNumber;
                    if (int.TryParse(this.textboxServerMulticastPort.Text, out PortNumber) && (PortNumber >= 1 && PortNumber <= 65535))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Invalid Port number");
                        Input_Validated = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all data fileds");
                    Input_Validated = false;
                }

                if (Input_Validated == true)
                {
                    if (StartListening(IPAddress.Parse(this.comboBoxNetworkInterface.Items[this.comboBoxNetworkInterface.SelectedIndex].ToString()),
                                 IPAddress.Parse(this.txtboxServerMulticastAddress.Text),
                                 int.Parse(this.textboxServerMulticastPort.Text)) == true)
                    {

                        this.btnConnectServerBroadcast.Text = "Disconnect";
                        this.btnConnectServerBroadcast.BackColor = Color.Green;
                        timer1.Enabled = true;
                    }
                }
            }
            else
            {
                KeepGoing = false;
                Shared_Data.Is_Connected = false;
                this.btnConnectServerBroadcast.Text = "Connect";
                this.btnConnectServerBroadcast.BackColor = Color.Red;
                timer1.Enabled = false;
                Cleanup();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Shared_Data.Update_Log_Window == true)
            {
                foreach (string s in Shared_Data.Received_Data_List_From_Server)
                {
                    listBoxRcvData.Items.Add(s);
                }
                Shared_Data.Update_Log_Window = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Client_Interface_Index = comboBoxNetworkInterface.SelectedIndex;
            Properties.Settings.Default.Client_Multicast_Address = txtboxServerMulticastAddress.Text;
            Properties.Settings.Default.Client_Port = textboxServerMulticastPort.Text;
            Properties.Settings.Default.Client_Brodacast_Address = textBoxClientMulticastAddress.Text;
            Properties.Settings.Default.Client_Broadcast_Port = textBoxClientMulticastPort.Text;

            Properties.Settings.Default.Save();

            this.Visible = false;
        }

        private void Client_Connection_Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cleanup();
        }

        private void textBoxClientMulticastPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void Client_Connection_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cleanup();
        }
    }
}
