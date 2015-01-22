using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHANSA_FrqMgmt
{
    public partial class DataDistributionForm : Form
    {
        public DataDistributionForm()
        {
            InitializeComponent();
        }

        private void timerStatusTimer_Tick(object sender, EventArgs e)
        {
            if (Shared_Data.CWP1_Connected == true)
            {
                CWP1.BackColor = Color.Green;
                Shared_Data.CWP1_Connected = false;
            }
            else
            {
                CWP1.BackColor = Color.Red;
                Shared_Data.CWP1_Connected = false;
            }

            if (Shared_Data.CWP2_Connected == true)
            {
                CWP2.BackColor = Color.Green;
                Shared_Data.CWP2_Connected = false;
            }
            else
            {
                CWP2.BackColor = Color.Red;
                Shared_Data.CWP2_Connected = false;
            }

            if (Shared_Data.CWP3_Connected == true)
            {
                CWP3.BackColor = Color.Green;
                Shared_Data.CWP3_Connected = false;
            }
            else
            {
                CWP3.BackColor = Color.Red;
                Shared_Data.CWP3_Connected = false;
            }

            ///////////////////////////////////////////////
            // Update the CWP update stauses
            if (Shared_Data.CWP1_Update_Status.Updated_Succefully == true)
            {
                this.CWP1_Update_Status.BackColor = Color.Green;
                this.label_CWP1_Update_Time.Text = 
                    Shared_Data.CWP1_Update_Status.Last_Succefull_Update.ToShortDateString() + "/" 
                    + Shared_Data.CWP1_Update_Status.Last_Succefull_Update.ToShortTimeString();
            }
            else
            {
                this.CWP1_Update_Status.BackColor = Color.Red;
                this.label_CWP1_Update_Time.Text = "N/A";
            }

            if (Shared_Data.CWP2_Update_Status.Updated_Succefully == true)
            {
                this.CWP2_Update_Status.BackColor = Color.Green;
                this.label_CWP2_Update_Time.Text =
                    Shared_Data.CWP2_Update_Status.Last_Succefull_Update.ToShortDateString() + "/"
                    + Shared_Data.CWP2_Update_Status.Last_Succefull_Update.ToShortTimeString();
            }
            else
            {
                this.CWP2_Update_Status.BackColor = Color.Red;
                this.label_CWP2_Update_Time.Text = "N/A";
            }

            if (Shared_Data.CWP3_Update_Status.Updated_Succefully == true)
            {
                this.CWP3_Update_Status.BackColor = Color.Green;
                this.label_CWP3_Update_Time.Text =
                    Shared_Data.CWP3_Update_Status.Last_Succefull_Update.ToShortDateString() + "/"
                    + Shared_Data.CWP3_Update_Status.Last_Succefull_Update.ToShortTimeString();
            }
            else
            {
                this.CWP3_Update_Status.BackColor = Color.Red;
                this.label_CWP3_Update_Time.Text = "N/A";
            }

        }

        private void CWP3_Click(object sender, EventArgs e)
        {

        }

        private void DataDistributionForm_Load(object sender, EventArgs e)
        {
            Shared_Data.CWP1_Connected = false;
            Shared_Data.CWP2_Connected = false;
            Shared_Data.CWP3_Connected = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Server_Connection_Settings.Is_Server_Connected() == true)
            {
                Shared_Data.Initiate_Data_Distribution = true;
                Shared_Data.CWP1_Update_Status.Updated_Succefully = false;
                Shared_Data.CWP2_Update_Status.Updated_Succefully = false;
                Shared_Data.CWP3_Update_Status.Updated_Succefully = false;
            }
            else
                MessageBox.Show("Server not running !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
