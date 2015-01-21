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
    public partial class General_Settings : Form
    {
        public General_Settings()
        {
            InitializeComponent();
        }

        private void General_Settings_Load(object sender, EventArgs e)
        {
            this.textBoxPositionName.Text = Properties.Settings.Default.Position_Name;
            this.Text = "General Settings: " + Shared_Data.Position_Name;
            this.checkBox1.Checked = Shared_Data.I_Am_Server;
        }



        private void textBoxPositionName_MouseLeave(object sender, EventArgs e)
        {
            Shared_Data.Position_Name = this.textBoxPositionName.Text;
            this.Text = "General Settings: " + Shared_Data.Position_Name;
            Properties.Settings.Default.Position_Name = Shared_Data.Position_Name;
            Properties.Settings.Default.Save();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Shared_Data.I_Am_Server = this.checkBox1.Checked;
            Properties.Settings.Default.I_am_Server = Shared_Data.I_Am_Server;
            Properties.Settings.Default.Save();
            Shared_Data.Server_Client_Mode_Changed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
