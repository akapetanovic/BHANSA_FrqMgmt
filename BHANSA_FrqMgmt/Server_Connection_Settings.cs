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
    public partial class Server_Connection_Settings : Form
    {
        private static bool KeepGoing = true;
        private static bool KeepGoingCWP1 = true;
        private static bool KeepGoingCWP2 = true;
        private static bool KeepGoingCWP3 = true;


        // Define the main listener thread
        private static Thread ListenForDataThread;

        // Define the main listener thread
        private static Thread ListenForDataThread_CWP1;
        // Define the main listener thread
        private static Thread ListenForDataThread_CWP2;
        // Define the main listener thread
        private static Thread ListenForDataThread_CWP3;


        // Define UDP-Multicast TX connection variables
        private static UdpClient tx_sock;
        private static IPEndPoint tx_iep;
        private static bool Broadcast_Enabled = false;

        // Define UDP-Multicast RCV connection variables
        private static UdpClient rcv_sock_CWP1;
        private static IPEndPoint rcv_iep_CWP1;

        // Same buffer is used for sending and receiving
        private static byte[] UDPBuffer_CWP1;

        // Define UDP-Multicast RCV connection variables
        private static UdpClient rcv_sock_CWP2;
        private static IPEndPoint rcv_iep_CWP2;

        // Same buffer is used for sending and receiving
        private static byte[] UDPBuffer_CWP2;

        // Define UDP-Multicast RCV connection variables
        private static UdpClient rcv_sock_CWP3;
        private static IPEndPoint rcv_iep_CWP3;

        // Same buffer is used for sending and receiving
        private static byte[] UDPBuffer_CWP3;

        public Server_Connection_Settings()
        {
            InitializeComponent();
        }

        private void Server_Connection_Settings_Load(object sender, EventArgs e)
        {

        }

        private void Server_Connection_Settings_VisibleChanged(object sender, EventArgs e)
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
                comboBoxNetworkInterface.SelectedIndex = 0;
        }

        private void btnConnectServerBroadcast_Click(object sender, EventArgs e)
        {

            if (this.btnConnectServerBroadcast.Text == "Connect")
            {
                bool Input_Validated = true;

                // First make sure that all boxes are filled out
                if ((!string.IsNullOrEmpty(this.txtboxIPAddress.Text)) &&
                     (!string.IsNullOrEmpty(this.comboBoxNetworkInterface.Text)) &&
                    (!string.IsNullOrEmpty(this.textboxPort.Text)))
                {
                    IPAddress IP;
                    IPAddress Multicast;
                    // Validate that a valid IP address is entered
                    if ((IPAddress.TryParse(this.txtboxIPAddress.Text, out Multicast) != true) || (IPAddress.TryParse(this.comboBoxNetworkInterface.Text, out IP) != true))
                    {
                        MessageBox.Show("Not a valid IP address");
                        Input_Validated = false;
                    }
                    else // Add a check that this is a valid multicast address
                    {
                        UdpClient TempSock;
                        TempSock = new UdpClient(4000);// Port does not matter
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
                    if (int.TryParse(this.textboxPort.Text, out PortNumber) && (PortNumber >= 1 && PortNumber <= 65535))
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
                    if (StartBroadcast(IPAddress.Parse(this.comboBoxNetworkInterface.Items[this.comboBoxNetworkInterface.SelectedIndex].ToString()),
                                 IPAddress.Parse(this.txtboxIPAddress.Text),
                                 int.Parse(this.textboxPort.Text)) == true)
                    {

                        this.btnConnectServerBroadcast.Text = "Disconnect";
                        this.btnConnectServerBroadcast.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                KeepGoing = false;
                this.btnConnectServerBroadcast.Text = "Connect";
                this.btnConnectServerBroadcast.BackColor = Color.Red;
                Cleanup();

            }
        }

        public static bool StartBroadcast(IPAddress Local_Interface_Addres,  // IP address of the forward interface 
                                         IPAddress Broadcast_Multicast_Address, // Multicast address of the forwarded data
                                         int Broadcast_PortNumber)              // Port number of the forwarded data
        {
            // Open up outgoing socket
            // Open up a new socket with the net IP address and port number   
            try
            {
                tx_sock = new UdpClient();
                tx_sock.JoinMulticastGroup(Broadcast_Multicast_Address, Local_Interface_Addres);
                tx_iep = new IPEndPoint(Broadcast_Multicast_Address, Broadcast_PortNumber);

            }
            catch
            {
                MessageBox.Show("Not possible! Make sure given IP address/port is a valid one on your system or not already used by some other process");
                return false;
            }

            KeepGoing = true;
            ListenForDataThread = new Thread(new ThreadStart(DOWork));
            ListenForDataThread.Start();
            return true;
        }

        private static void DOWork()
        {
            while (KeepGoing)
            {

                try
                {
                    byte[] byData = System.Text.Encoding.ASCII.GetBytes("TEST STRING");
                    tx_sock.Send(byData, byData.Length, tx_iep);

                }
                catch
                {

                }

                Thread.Sleep(1000);
            }

            Cleanup();
        }

        private static void Cleanup()
        {

            if (tx_sock != null)
                tx_sock.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnectCWP1_Click(object sender, EventArgs e)
        {
            if (this.btnConnectCWP1.Text == "Connect")
            {
                bool Input_Validated = true;

                // First make sure that all boxes are filled out
                if ((!string.IsNullOrEmpty(this.txtMulticastCWP1.Text)) &&
                     (!string.IsNullOrEmpty(this.comboBoxNetworkInterface.Text)) &&
                    (!string.IsNullOrEmpty(this.txtPortCWP1.Text)))
                {
                    IPAddress IP;
                    IPAddress Multicast;
                    // Validate that a valid IP address is entered
                    if ((IPAddress.TryParse(this.txtMulticastCWP1.Text, out Multicast) != true) || (IPAddress.TryParse(this.comboBoxNetworkInterface.Text, out IP) != true))
                    {
                        MessageBox.Show("Not a valid IP address");
                        Input_Validated = false;
                    }
                    else // Add a check that this is a valid multicast address
                    {
                        UdpClient TempSock;
                        TempSock = new UdpClient(4001);// Port does not matter
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
                    if (int.TryParse(this.txtPortCWP1.Text, out PortNumber) && (PortNumber >= 1 && PortNumber <= 65535))
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
                    if (StartListening_CWP1(IPAddress.Parse(this.comboBoxNetworkInterface.Items[this.comboBoxNetworkInterface.SelectedIndex].ToString()),
                                 IPAddress.Parse(this.txtMulticastCWP1.Text),
                                 int.Parse(this.txtPortCWP1.Text)) == true)
                    {
                        this.btnConnectCWP1.Text = "Disconnect";
                        this.btnConnectCWP1.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                KeepGoingCWP1 = false;
                this.btnConnectCWP1.Text = "Connect";
                this.btnConnectCWP1.BackColor = Color.Red;
                // Do a cleanup
                if (rcv_sock_CWP1 != null)
                    rcv_sock_CWP1.Close();
            }
        }

        public static bool StartListening_CWP1(IPAddress Interface_Addres,  // IP address of the interface where the data is expected
                                               IPAddress Multicast_Address, // Multicast address of the expected data
                                               int PortNumber)              // Port number of the forwarded data
        {



            // Open up a new socket with the net IP address and port number   
            try
            {
                rcv_sock_CWP1 = new UdpClient(PortNumber);
                rcv_sock_CWP1.JoinMulticastGroup(Multicast_Address, Interface_Addres);
                rcv_iep_CWP1 = new IPEndPoint(IPAddress.Any, PortNumber);
            }
            catch
            {
                MessageBox.Show("Not possible! Make sure given IP address/port is a valid one on your system or not already used by some other process");
                return false;
            }

            KeepGoingCWP1 = true;
            ListenForDataThread_CWP1 = new Thread(new ThreadStart(DOWork_CWP1));
            ListenForDataThread_CWP1.Start();

            return true;
        }

        private static void DOWork_CWP1()
        {
            while (KeepGoingCWP1)
            {

                try
                {
                    // Lets receive data in an array of bytes 
                    // (an octet, of course composed of 8bits)
                    UDPBuffer_CWP1 = rcv_sock_CWP1.Receive(ref rcv_iep_CWP1);
                    Shared_Data.Received_Data_List_From_CWP1.Add(System.Text.Encoding.Default.GetString(UDPBuffer_CWP1));
                    Shared_Data.New_Data_Has_Arrived = true;
                }
                catch
                {
                    if (KeepGoingCWP1 == true)
                        MessageBox.Show("Issue in DoWork_CWP1");
                }

            }

            // Do a cleanup
            if (rcv_sock_CWP1 != null)
                rcv_sock_CWP1.Close();
        }

        private void btnConnectCWP2_Click(object sender, EventArgs e)
        {
            if (this.btnConnectCWP2.Text == "Connect")
            {
                bool Input_Validated = true;

                // First make sure that all boxes are filled out
                if ((!string.IsNullOrEmpty(this.txtMulticastCWP2.Text)) &&
                     (!string.IsNullOrEmpty(this.comboBoxNetworkInterface.Text)) &&
                    (!string.IsNullOrEmpty(this.txtPortCWP2.Text)))
                {
                    IPAddress IP;
                    IPAddress Multicast;
                    // Validate that a valid IP address is entered
                    if ((IPAddress.TryParse(this.txtMulticastCWP2.Text, out Multicast) != true) || (IPAddress.TryParse(this.comboBoxNetworkInterface.Text, out IP) != true))
                    {
                        MessageBox.Show("Not a valid IP address");
                        Input_Validated = false;
                    }
                    else // Add a check that this is a valid multicast address
                    {
                        UdpClient TempSock;
                        TempSock = new UdpClient(4002);// Port does not matter
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
                    if (int.TryParse(this.txtPortCWP2.Text, out PortNumber) && (PortNumber >= 1 && PortNumber <= 65535))
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
                    if (StartListening_CWP2(IPAddress.Parse(this.comboBoxNetworkInterface.Items[this.comboBoxNetworkInterface.SelectedIndex].ToString()),
                                 IPAddress.Parse(this.txtMulticastCWP2.Text),
                                 int.Parse(this.txtPortCWP2.Text)) == true)
                    {
                        this.btnConnectCWP2.Text = "Disconnect";
                        this.btnConnectCWP2.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                KeepGoingCWP2 = false;
                this.btnConnectCWP2.Text = "Connect";
                this.btnConnectCWP2.BackColor = Color.Red;
                // Do a cleanup
                if (rcv_sock_CWP2 != null)
                    rcv_sock_CWP2.Close();
            }
        }

        public static bool StartListening_CWP2(IPAddress Interface_Addres,  // IP address of the interface where the data is expected
                                              IPAddress Multicast_Address, // Multicast address of the expected data
                                              int PortNumber)              // Port number of the forwarded data
        {



            // Open up a new socket with the net IP address and port number   
            try
            {
                rcv_sock_CWP2 = new UdpClient(PortNumber);
                rcv_sock_CWP2.JoinMulticastGroup(Multicast_Address, Interface_Addres);
                rcv_iep_CWP2 = new IPEndPoint(IPAddress.Any, PortNumber);
            }
            catch
            {
                MessageBox.Show("Not possible! Make sure given IP address/port is a valid one on your system or not already used by some other process");
                return false;
            }

            KeepGoingCWP2 = true;
            ListenForDataThread_CWP2 = new Thread(new ThreadStart(DOWork_CWP2));
            ListenForDataThread_CWP2.Start();

            return true;
        }

        private static void DOWork_CWP2()
        {
            while (KeepGoingCWP2)
            {

                try
                {
                    // Lets receive data in an array of bytes 
                    // (an octet, of course composed of 8bits)
                    UDPBuffer_CWP2 = rcv_sock_CWP2.Receive(ref rcv_iep_CWP2);
                    Shared_Data.Received_Data_List_From_CWP2.Add(System.Text.Encoding.Default.GetString(UDPBuffer_CWP2));
                    Shared_Data.New_Data_Has_Arrived = true;
                }
                catch
                {
                    if (KeepGoingCWP2 == true)
                        MessageBox.Show("Issue in DoWork_CWP2");
                }

            }

            // Do a cleanup
            if (rcv_sock_CWP2 != null)
                rcv_sock_CWP2.Close();
        }

        private void btnConnectCWP3_Click(object sender, EventArgs e)
        {
            if (this.btnConnectCWP3.Text == "Connect")
            {
                bool Input_Validated = true;

                // First make sure that all boxes are filled out
                if ((!string.IsNullOrEmpty(this.txtMulticastCWP3.Text)) &&
                     (!string.IsNullOrEmpty(this.comboBoxNetworkInterface.Text)) &&
                    (!string.IsNullOrEmpty(this.txtPortCWP3.Text)))
                {
                    IPAddress IP;
                    IPAddress Multicast;
                    // Validate that a valid IP address is entered
                    if ((IPAddress.TryParse(this.txtMulticastCWP3.Text, out Multicast) != true) || (IPAddress.TryParse(this.comboBoxNetworkInterface.Text, out IP) != true))
                    {
                        MessageBox.Show("Not a valid IP address");
                        Input_Validated = false;
                    }
                    else // Add a check that this is a valid multicast address
                    {
                        UdpClient TempSock;
                        TempSock = new UdpClient(2225);// Port does not matter
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
                    if (int.TryParse(this.txtPortCWP3.Text, out PortNumber) && (PortNumber >= 1 && PortNumber <= 65535))
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
                    if (StartListening_CWP3(IPAddress.Parse(this.comboBoxNetworkInterface.Items[this.comboBoxNetworkInterface.SelectedIndex].ToString()),
                                 IPAddress.Parse(this.txtMulticastCWP3.Text),
                                 int.Parse(this.txtPortCWP3.Text)) == true)
                    {
                        this.btnConnectCWP3.Text = "Disconnect";
                        this.btnConnectCWP3.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                KeepGoingCWP3 = false;
                this.btnConnectCWP3.Text = "Connect";
                this.btnConnectCWP3.BackColor = Color.Red;
                // Do a cleanup
                if (rcv_sock_CWP3 != null)
                    rcv_sock_CWP3.Close();
            }
        }

        public static bool StartListening_CWP3(IPAddress Interface_Addres,  // IP address of the interface where the data is expected
                                             IPAddress Multicast_Address, // Multicast address of the expected data
                                             int PortNumber)              // Port number of the forwarded data
        {



            // Open up a new socket with the net IP address and port number   
            try
            {
                rcv_sock_CWP3 = new UdpClient(PortNumber);
                rcv_sock_CWP3.JoinMulticastGroup(Multicast_Address, Interface_Addres);
                rcv_iep_CWP3 = new IPEndPoint(IPAddress.Any, PortNumber);
            }
            catch
            {
                MessageBox.Show("Not possible! Make sure given IP address/port is a valid one on your system or not already used by some other process");
                return false;
            }

            KeepGoingCWP3 = true;
            ListenForDataThread_CWP3 = new Thread(new ThreadStart(DOWork_CWP3));
            ListenForDataThread_CWP3.Start();

            return true;
        }

        private static void DOWork_CWP3()
        {
            while (KeepGoingCWP3)
            {

                try
                {
                    // Lets receive data in an array of bytes 
                    // (an octet, of course composed of 8bits)
                    UDPBuffer_CWP3 = rcv_sock_CWP3.Receive(ref rcv_iep_CWP3);
                    Shared_Data.Received_Data_List_From_CWP3.Add(System.Text.Encoding.Default.GetString(UDPBuffer_CWP3));
                    Shared_Data.New_Data_Has_Arrived = true;
                }
                catch
                {
                    if (KeepGoingCWP3 == true)
                        MessageBox.Show("Issue in DoWork_CWP3");
                }

            }

            // Do a cleanup
            if (rcv_sock_CWP3 != null)
                rcv_sock_CWP3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
