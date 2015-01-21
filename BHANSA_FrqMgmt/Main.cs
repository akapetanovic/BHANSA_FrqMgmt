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
    public partial class Main : Form
    {
        private static Server_Connection_Settings Server_Connection_Settings_Form = new Server_Connection_Settings();
        private static Client_Connection_Settings Clinet_Connection_Settings_Form = new Client_Connection_Settings();
        private static General_Settings GS = new General_Settings();

        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {

            Shared_Data.I_Am_Server = Properties.Settings.Default.I_am_Server;
            Shared_Data.Position_Name = Properties.Settings.Default.Position_Name;

            Server_Connection_Settings_Form.Visible = false;
            Clinet_Connection_Settings_Form.Visible = false;
            GS.Visible = false;

            this.checkBox_US_ZG.Checked = Properties.Settings.Default.CCL_US_Checked;
            this.checkBox_UW_ZG.Checked = Properties.Settings.Default.CCL_UN_Checked;
            this.checkBox_UN_ZG.Checked = Properties.Settings.Default.CCL_UW_Checked;
            this.checkBox_LS_ZG.Checked = Properties.Settings.Default.CCL_LS_Checked;
            this.checkBox_LW_ZG.Checked = Properties.Settings.Default.CCL_LN_Checked;
            this.checkBox_LN_ZG.Checked = Properties.Settings.Default.CCL_LW_Checked;

            if (this.checkBox_US_ZG.Checked)
            {
                this.textBox_CCL_US_Value.Text = Properties.Settings.Default.CCL_US_Value;
            }
            else
            {
                this.textBox_CCL_US_Value.Text = "";
                this.textBox_CCL_US_Value.Enabled = false;
            }

            if (this.checkBox_UW_ZG.Checked)
            {
                this.textBox_CCL_UN_Value.Text = Properties.Settings.Default.CCL_UN_Value;
            }
            else
            {
                this.textBox_CCL_UN_Value.Text = "";
                this.textBox_CCL_UN_Value.Enabled = false;
            }

            if (this.checkBox_UN_ZG.Checked)
            {
                this.textBox_CCL_UW_Value.Text = Properties.Settings.Default.CCL_UW_Value;
            }
            else
            {
                this.textBox_CCL_UW_Value.Text = "";
                this.textBox_CCL_UW_Value.Enabled = false;
            }

            if (this.checkBox_LS_ZG.Checked)
            {
                this.textBox_CCL_LS_Value.Text = Properties.Settings.Default.CCL_LS_Value;
            }
            else
            {
                this.textBox_CCL_LS_Value.Text = "";
                this.textBox_CCL_LS_Value.Enabled = false;
            }

            if (this.checkBox_LW_ZG.Checked)
            {
                this.textBox_CCL_LN_Value.Text = Properties.Settings.Default.CCL_LN_Value;
            }
            else
            {
                this.textBox_CCL_LN_Value.Text = "";
                this.textBox_CCL_LN_Value.Enabled = false;
            }

            if (this.checkBox_LN_ZG.Checked)
            {
                this.textBox_CCL_LW_Value.Text = Properties.Settings.Default.CCL_LW_Value;
            }
            else
            {
                this.textBox_CCL_LW_Value.Text = "";
                this.textBox_CCL_LW_Value.Enabled = false;
            }

            this.checkBox_SMATSA_LOWER.Checked = Properties.Settings.Default.SMATSA_Lower_Checked;
            this.checkBox_SMATSA_UW.Checked = Properties.Settings.Default.SMATSA_UW_Checked;
            this.checkBox_SMATSA_UN.Checked = Properties.Settings.Default.SMATSA_UN_Checked;

            if (this.checkBox_SMATSA_LOWER.Checked)
            {
                this.textBox_SMATSA_LOWER.Text = Properties.Settings.Default.SMATSA_Lower_Value;
            }
            else
            {
                this.textBox_SMATSA_LOWER.Text = "";
                this.textBox_SMATSA_LOWER.Enabled = false;
            }

            if (this.checkBox_SMATSA_UW.Checked)
            {
                this.textBox_SMATSA_UW.Text = Properties.Settings.Default.SMATSA_UW_Value;
            }
            else
            {
                this.textBox_SMATSA_UW.Text = "";
                this.textBox_SMATSA_UW.Enabled = false;
            }

            if (this.checkBox_SMATSA_UN.Checked)
            {
                this.textBox_SMATSA_UN.Text = Properties.Settings.Default.SMATSA_UN_Value;
            }
            else
            {
                this.textBox_SMATSA_UN.Text = "";
                this.textBox_SMATSA_UN.Enabled = false;
            }

            this.textBox_Division_Level.Text = Properties.Settings.Default.Division_Level;

            this.textBoxLDZA.Text = Properties.Settings.Default.LDZA;
            this.textBoxLDDU.Text = Properties.Settings.Default.LDDU;
            this.textBoxLDSP.Text = Properties.Settings.Default.LDSP;
            this.textBoxLDOS.Text = Properties.Settings.Default.LDOS;
            this.textBoxZGFIC.Text = Properties.Settings.Default.ZGFIC;

            this.textBoxLQSA.Text = Properties.Settings.Default.LQSA;
            this.textBoxLQMO.Text = Properties.Settings.Default.LQMO;
            this.textBoxLQTZ.Text = Properties.Settings.Default.LQTZ;
            this.textBoxLQBK.Text = Properties.Settings.Default.LQBK;
            this.textBoxFIC.Text = Properties.Settings.Default.FIC;

            this.textBoxLYBE.Text = Properties.Settings.Default.LYBE;
            this.textBoxLYPG.Text = Properties.Settings.Default.LYPG;

            this.textBoxSectorLYPG.Text = Properties.Settings.Default.Chief_Sup_Ext;
            this.textBoxChief_Sup.Text = Properties.Settings.Default.Sector_LYPG;

            this.textBoxFree_One.Text = Properties.Settings.Default.Free_Text_1;
            this.textBoxFree_Two.Text = Properties.Settings.Default.Free_Text_2;
            this.textBoxFree_Three.Text = Properties.Settings.Default.Free_Text_3;
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {


            this.End_X_UP_ZG.Visible = false;
            this.End_X_DOWN_ZG.Visible = false;

            // Create four Pen objects with red,
            // blue, green, and black colors and
            // different widths
            Pen redPen = new Pen(Color.Red, 3);
            Pen bluePen = new Pen(Color.Blue, 3);
            Pen greenPen = new Pen(Color.Green, 3);
            Pen blackPen = new Pen(Color.Black, 3);

            // DRAW ZAGREB BOX

            // Draw line using Point structure
            Point p1 = new Point(20, 32);
            Point p2 = new Point(this.End_X_UP_ZG.Location.X, 32);
            e.Graphics.DrawLine(redPen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(20, this.End_X_DOWN_ZG.Location.Y);
            p2 = new Point(this.End_X_DOWN_ZG.Location.X, this.End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(redPen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(20, 32);
            p2 = new Point(20, this.End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(redPen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(checkBox_UW_ZG.Location.X - 10, 32);
            p2 = new Point(checkBox_UW_ZG.Location.X - 10, this.End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(redPen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(checkBox_UN_ZG.Location.X - 10, 32);
            p2 = new Point(checkBox_UN_ZG.Location.X - 10, this.End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(redPen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(this.End_X_UP_ZG.Location.X - 2, 32);
            p2 = new Point(this.End_X_DOWN_ZG.Location.X - 2, this.End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(redPen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(20, checkBox_LS_ZG.Location.Y - 15);
            p2 = new Point(this.End_X_DOWN_ZG.Location.X - 2, checkBox_LS_ZG.Location.Y - 15);
            e.Graphics.DrawLine(redPen, p1, p2);

            // DRAW BEOGRAD BOX

            // Draw line using Point structure
            p1 = new Point(this.End_X_UP_ZG.Location.X + 7, 32);
            p2 = new Point(this.End_X_UP_ZG.Location.X + 7, End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(bluePen, p1, p2);

            p1 = new Point(this.End_X_UP_ZG.Location.X + 7, 32);
            p2 = new Point(this.Width - 15, 32);
            e.Graphics.DrawLine(bluePen, p1, p2);

            p1 = new Point(this.Width - 15, 32);
            p2 = new Point(this.Width - 15, this.End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(bluePen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(checkBox_SMATSA_UN.Location.X - 10, 32);
            p2 = new Point(checkBox_SMATSA_UN.Location.X - 10, checkBox_LS_ZG.Location.Y - 15);
            e.Graphics.DrawLine(bluePen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(End_X_DOWN_ZG.Location.X + 7, End_X_DOWN_ZG.Location.Y);
            p2 = new Point(this.Width - 15, this.End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(bluePen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(this.End_X_DOWN_ZG.Location.X - 2, checkBox_LS_ZG.Location.Y - 15);
            p2 = new Point(this.Width - 15, checkBox_LS_ZG.Location.Y - 15);
            e.Graphics.DrawLine(bluePen, p1, p2);

            // DRAW FREE TEXT
            // Draw line using Point structure
            p1 = new Point(this.textBoxFree_One.Location.X - 6, this.textBoxFree_One.Location.Y - 8);
            p2 = new Point(this.Width - 14, this.textBoxFree_One.Location.Y - 8);
            e.Graphics.DrawLine(blackPen, p1, p2);

            p1 = new Point(this.textBoxFree_One.Location.X - 6, this.textBoxFree_One.Location.Y - 8);
            p2 = new Point(this.textBoxFree_One.Location.X - 6, this.Height - 35);
            e.Graphics.DrawLine(blackPen, p1, p2);

            p1 = new Point(this.textBoxFree_One.Location.X - 6, this.Height - 35);
            p2 = new Point(this.Width - 14, this.Height - 35);
            e.Graphics.DrawLine(blackPen, p1, p2);

            p1 = new Point(this.Width - 14, this.textBoxFree_One.Location.Y - 8);
            p2 = new Point(this.Width - 14, this.Height - 35);
            e.Graphics.DrawLine(blackPen, p1, p2);

            //Dispose of objects
            redPen.Dispose();
            bluePen.Dispose();
            greenPen.Dispose();
            blackPen.Dispose();


        }

        private void checkBox_UN_ZG_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_UW_ZG.Checked)
            {
                this.textBox_CCL_UW_Value.Text = Properties.Settings.Default.CCL_UW_Value;
                this.textBox_CCL_UW_Value.Enabled = true;
            }
            else
            {

                Properties.Settings.Default.CCL_UW_Value = this.textBox_CCL_UW_Value.Text;
                this.textBox_CCL_UW_Value.Text = "";
                this.textBox_CCL_UN_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_UN_Checked = this.checkBox_UW_ZG.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_US_ZG_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_US_ZG.Checked)
            {
                this.textBox_CCL_US_Value.Text = Properties.Settings.Default.CCL_US_Value;
                this.textBox_CCL_US_Value.Enabled = true;
            }
            else
            {

                Properties.Settings.Default.CCL_US_Value = this.textBox_CCL_US_Value.Text;
                this.textBox_CCL_US_Value.Text = "";
                this.textBox_CCL_US_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_US_Checked = this.checkBox_US_ZG.Checked;
            Properties.Settings.Default.Save();

        }

        private void checkBox_UW_ZG_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_UN_ZG.Checked)
            {
                this.textBox_CCL_UN_Value.Text = Properties.Settings.Default.CCL_UN_Value;
                this.textBox_CCL_UN_Value.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.CCL_UN_Value = this.textBox_CCL_UN_Value.Text;
                this.textBox_CCL_UN_Value.Text = "";
                this.textBox_CCL_UN_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_UW_Checked = this.checkBox_UN_ZG.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_LS_ZG_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_LS_ZG.Checked)
            {
                this.textBox_CCL_LS_Value.Text = Properties.Settings.Default.CCL_LS_Value;
                this.textBox_CCL_LS_Value.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.CCL_LS_Value = this.textBox_CCL_LS_Value.Text;
                this.textBox_CCL_LS_Value.Text = "";
                this.textBox_CCL_LS_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_LS_Checked = this.checkBox_LS_ZG.Checked;
            Properties.Settings.Default.Save();

        }

        private void checkBox_LN_ZG_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_LW_ZG.Checked)
            {
                this.textBox_CCL_LW_Value.Text = Properties.Settings.Default.CCL_LW_Value;
                this.textBox_CCL_LW_Value.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.CCL_LN_Value = this.textBox_CCL_LW_Value.Text;
                this.textBox_CCL_LW_Value.Text = "";
                this.textBox_CCL_LW_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_LN_Checked = this.checkBox_LW_ZG.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_LW_ZG_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_LN_ZG.Checked)
            {
                this.textBox_CCL_LN_Value.Text = Properties.Settings.Default.CCL_LN_Value;
                this.textBox_CCL_LN_Value.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.CCL_LW_Value = this.textBox_CCL_LN_Value.Text;
                this.textBox_CCL_LN_Value.Text = "";
                this.textBox_CCL_LN_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_LW_Checked = this.checkBox_LN_ZG.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_SMATSA_UW.Checked)
            {
                this.textBox_SMATSA_UW.Text = Properties.Settings.Default.SMATSA_UW_Value;
                this.textBox_SMATSA_UW.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.SMATSA_UW_Value = this.textBox_SMATSA_UW.Text;
                this.textBox_SMATSA_UW.Text = "";
                this.textBox_SMATSA_UW.Enabled = false;
            }

            Properties.Settings.Default.SMATSA_UW_Checked = this.checkBox_SMATSA_UW.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBoxBG_UN_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_SMATSA_UN.Checked)
            {
                this.textBox_SMATSA_UN.Text = Properties.Settings.Default.SMATSA_UN_Value;
                this.textBox_SMATSA_UN.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.SMATSA_UN_Value = this.textBox_SMATSA_UN.Text;
                this.textBox_SMATSA_UN.Text = "";
                this.textBox_SMATSA_UN.Enabled = false;
            }

            Properties.Settings.Default.SMATSA_UN_Checked = this.checkBox_SMATSA_UN.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_SMATSA_LOWER_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_SMATSA_LOWER.Checked)
            {
                this.textBox_SMATSA_LOWER.Text = Properties.Settings.Default.SMATSA_Lower_Value;
                this.textBox_SMATSA_LOWER.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.SMATSA_Lower_Value = this.textBox_SMATSA_LOWER.Text;
                this.textBox_SMATSA_LOWER.Text = "";
                this.textBox_SMATSA_LOWER.Enabled = false;
            }

            Properties.Settings.Default.SMATSA_Lower_Checked = this.checkBox_SMATSA_LOWER.Checked;
            Properties.Settings.Default.Save();
        }



        private void Update_And_Save()
        {

            if (this.checkBox_UW_ZG.Checked)
            {
                Properties.Settings.Default.CCL_UN_Value = this.textBox_CCL_UN_Value.Text;
            }
            if (this.checkBox_US_ZG.Checked)
            {
                Properties.Settings.Default.CCL_US_Value = this.textBox_CCL_US_Value.Text;
            }
            if (this.checkBox_UN_ZG.Checked)
            {
                Properties.Settings.Default.CCL_UW_Value = this.textBox_CCL_UW_Value.Text;
            }
            if (this.checkBox_LS_ZG.Checked)
            {
                Properties.Settings.Default.CCL_LS_Value = this.textBox_CCL_LS_Value.Text;
            }
            if (this.checkBox_LW_ZG.Checked)
            {
                Properties.Settings.Default.CCL_LN_Value = this.textBox_CCL_LN_Value.Text;
            }
            if (this.checkBox_LN_ZG.Checked)
            {
                Properties.Settings.Default.CCL_LW_Value = this.textBox_CCL_LW_Value.Text;
            }


            if (this.checkBox_SMATSA_LOWER.Checked)
            {
                Properties.Settings.Default.SMATSA_Lower_Value = this.textBox_SMATSA_LOWER.Text;
            }
            if (this.checkBox_SMATSA_UW.Checked)
            {
                Properties.Settings.Default.SMATSA_UW_Value = this.textBox_SMATSA_UW.Text;
            }
            if (this.checkBox_SMATSA_UN.Checked)
            {
                Properties.Settings.Default.SMATSA_UN_Value = this.textBox_SMATSA_UN.Text;
            }

            Properties.Settings.Default.Division_Level = this.textBox_Division_Level.Text;

            Properties.Settings.Default.LDZA = this.textBoxLDZA.Text;
            Properties.Settings.Default.LDDU = this.textBoxLDDU.Text;
            Properties.Settings.Default.LDSP = this.textBoxLDSP.Text;
            Properties.Settings.Default.LDOS = this.textBoxLDOS.Text;
            Properties.Settings.Default.ZGFIC = this.textBoxZGFIC.Text;

            Properties.Settings.Default.LQSA = this.textBoxLQSA.Text;
            Properties.Settings.Default.LQMO = this.textBoxLQMO.Text;
            Properties.Settings.Default.LQTZ = this.textBoxLQTZ.Text;
            Properties.Settings.Default.LQBK = this.textBoxLQBK.Text;
            Properties.Settings.Default.FIC = this.textBoxFIC.Text;

            Properties.Settings.Default.LYBE = this.textBoxLYBE.Text;
            Properties.Settings.Default.LYPG = this.textBoxLYPG.Text;

            Properties.Settings.Default.Chief_Sup_Ext = this.textBoxSectorLYPG.Text;
            Properties.Settings.Default.Sector_LYPG = this.textBoxChief_Sup.Text;

            Properties.Settings.Default.Free_Text_1 = this.textBoxFree_One.Text;
            Properties.Settings.Default.Free_Text_2 = this.textBoxFree_Two.Text;
            Properties.Settings.Default.Free_Text_3 = this.textBoxFree_Three.Text;

            Properties.Settings.Default.Save();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Update_And_Save();
            Server_Connection_Settings_Form.Close();
            Clinet_Connection_Settings_Form.Close();
            GS.Close();
           
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.BackColor = colorDialog1.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Amer Kapetanovic\namer.kapetanovic@bhansa.gov.ba\nVersion 1.0\n21.01.2014");
        }

        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server_Connection_Settings_Form.Visible = true;
        }

        private void clientConnectionSettingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clinet_Connection_Settings_Form.Visible = true;
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            if (Server_Connection_Settings.Is_Server_Connected() == true)
            {
                Shared_Data.Data_To_Distribute(Get_Current_Data_Set());
                Shared_Data.New_Distribution_Requested = true;

            }
            else
                MessageBox.Show("Server not running !");
        }

        private string Get_Current_Data_Set()
        {
            string Data_Out = "";

            Data_Out =
                // CCL

                "ZG_US: " + this.checkBox_US_ZG.CheckState.ToString() + "," +
                "ZG_US_VALUE: " + this.textBox_CCL_US_Value.Text + "," +

                "ZG_UW: " + this.checkBox_UW_ZG.CheckState.ToString() + "," +
                "ZG_UW_VALUE: " + this.textBox_CCL_UW_Value.Text + "," +

                "ZG_UN: " + this.checkBox_UN_ZG.CheckState.ToString() + "," +
                "ZG_UN_VALUE: " + this.textBox_CCL_UN_Value.Text + "," +

                "ZG_LS: " + this.checkBox_LS_ZG.CheckState.ToString() + "," +
                "ZG_LS_VALUE: " + this.textBox_CCL_LS_Value.Text + "," +

                "ZG_LW: " + this.checkBox_LW_ZG.CheckState.ToString() + "," +
                "ZG_LW_VALUE: " + this.textBox_CCL_LW_Value.Text + "," +

                "ZG_LN: " + this.checkBox_LN_ZG.CheckState.ToString() + "," +
                "ZG_LN_VALUE: " + this.textBox_CCL_LN_Value.Text + "," +

                "LDZA: " + textBoxLDZA.Text + "," +
                "LDDU: " + textBoxLDDU.Text + "," +
                "LDSP: " + textBoxLDSP.Text + "," +
                "LDOS: " + textBoxLDOS.Text + "," +
                "ZGFIC: " + textBoxZGFIC.Text + "," +

                // SMATSA

                "BG_UW: " + this.checkBox_SMATSA_UW.CheckState.ToString() + "," +
                "BG_UW_VALUE: " + this.textBox_SMATSA_UW.Text + "," +

                "BG_UN: " + this.checkBox_SMATSA_UN.CheckState.ToString() + "," +
                "BG_UN_VALUE: " + this.textBox_SMATSA_UN.Text + "," +

                "BG_LOWER: " + this.checkBox_SMATSA_LOWER.CheckState.ToString() + "," +
                "BG_LOWER_VALUE: " + this.textBox_SMATSA_LOWER.Text + "," +

                "LYBE: " + this.textBoxLYBE.Text + "," +
                "LYPG: " + this.textBoxLYPG.Text + "," +
                "SEC_LYPG: " + this.textBoxSectorLYPG.Text + "," +

                // GENERAL     
                "DFL: " + this.textBox_Division_Level.Text + "," +

                // BHANSA
                "LQSA: " + this.textBoxLQSA.Text + "," +
                "LQMO: " + this.textBoxLQMO.Text + "," +
                "LQTZ: " + this.textBoxLQTZ.Text + "," +
                "LQBK: " + this.textBoxLQBK.Text + "," +
                "FIC: " + this.textBoxFIC.Text + "," +

                "CHF_SUP: " + this.textBoxChief_Sup.Text + "," +
                "FREE_1: " + this.textBoxFree_One.Text + "," +
                "FREE_2: " + this.textBoxFree_Two.Text + "," +
                "FREE_3: " + this.textBoxFree_Three.Text;

            return Data_Out;
        }

        private CheckState Check_State_From_String(string Value)
        {
            if (Value == "Checked")
                return CheckState.Checked;
            else
                return CheckState.Unchecked;
        }

        private string[] Check_For_Multiple_Strings(string[] S)
        {
            string[] Result = new string[] { " ", "" };

            if (S.Length < 3)
                Result = S;
            else
            {

                Result[0] = S[0];

                for (int I = 1; I < S.Length; I++)
                {
                    Result[1] = Result[1] + S[I] + " ";
                }

                Result[1].Remove(Result.Length - 1);
            }
            return Result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Shared_Data.Update_Main_Data_Display == true)
            {
                timer1.Enabled = false;
                System.Windows.Forms.DialogResult T = MessageBox.Show("New data set available, Proceed with the update?", "Confirm", MessageBoxButtons.YesNo);
                if (T == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (string S in Shared_Data.Received_Data_List_From_Server)
                    {
                        string[] words = S.Split(' ');

                        // Check if the string has more than two strings
                        words = Check_For_Multiple_Strings(words);

                        switch (words[0])
                        {
                            /////////////////////////////////////////////////////////////////////////////////
                            // CCL
                            case "ZG_US:":
                                this.checkBox_US_ZG.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "ZG_US_VALUE:":
                                this.textBox_CCL_US_Value.Text = words[1];
                                break;
                            case "ZG_UW:":
                                this.checkBox_UW_ZG.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "ZG_UW_VALUE:":
                                this.textBox_CCL_UW_Value.Text = words[1];
                                break;
                            case "ZG_UN:":
                                this.checkBox_UN_ZG.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "ZG_UN_VALUE:":
                                this.textBox_CCL_UN_Value.Text = words[1];
                                break;
                            case "ZG_LS:":
                                this.checkBox_LS_ZG.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "ZG_LS_VALUE:":
                                this.textBox_CCL_LS_Value.Text = words[1];
                                break;
                            case "ZG_LW:":
                                this.checkBox_LW_ZG.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "ZG_LW_VALUE:":
                                this.textBox_CCL_LW_Value.Text = words[1];
                                break;
                            case "ZG_LN:":
                                this.checkBox_LN_ZG.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "ZG_LN_VALUE:":
                                this.textBox_CCL_LN_Value.Text = words[1];
                                break;
                            case "LDZA:":
                                textBoxLDZA.Text = words[1];
                                break;
                            case "LDDU:":
                                textBoxLDDU.Text = words[1];
                                break;
                            case "LDSP:":
                                textBoxLDSP.Text = words[1];
                                break;
                            case "LDOS:":
                                textBoxLDOS.Text = words[1];
                                break;
                            case "ZGFIC:":
                                textBoxZGFIC.Text = words[1];
                                break;
                            /////////////////////////////////////////////////////////////////////////////////
                            // SMATSA
                            case "BG_UW:":
                                this.checkBox_SMATSA_UW.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "BG_UW_VALUE:":
                                this.textBox_SMATSA_UW.Text = words[1];
                                break;
                            case "BG_UN:":
                                this.checkBox_SMATSA_UN.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "BG_UN_VALUE:":
                                this.textBox_SMATSA_UN.Text = words[1];
                                break;
                            case "BG_LOWER:":
                                this.checkBox_SMATSA_LOWER.CheckState = Check_State_From_String(words[1]);
                                break;
                            case "BG_LOWER_VALUE:":
                                this.textBox_SMATSA_LOWER.Text = words[1];
                                break;
                            case "LYBE:":
                                this.textBoxLYBE.Text = words[1];
                                break;
                            case "LYPG:":
                                this.textBoxLYPG.Text = words[1];
                                break;
                            case "SEC_LYPG:":
                                this.textBoxSectorLYPG.Text = words[1];
                                break;
                            /////////////////////////////////////////////////////////////////////////////////
                            // GENERAL     
                            case "DFL:":
                                this.textBox_Division_Level.Text = words[1];
                                break;

                            /////////////////////////////////////////////////////////////////////////////////
                            // BHANSA
                            case "LQSA:":
                                this.textBoxLQSA.Text = words[1];
                                break;
                            case "LQMO:":
                                this.textBoxLQMO.Text = words[1];
                                break;
                            case "LQTZ:":
                                this.textBoxLQTZ.Text = words[1];
                                break;
                            case "LQBK:":
                                this.textBoxLQBK.Text = words[1];
                                break;
                            case "FIC:":
                                this.textBoxFIC.Text = words[1];
                                break;

                            case "CHF_SUP:":
                                this.textBoxChief_Sup.Text = words[1];
                                break;
                            case "FREE_1:":
                                this.textBoxFree_One.Text = words[1];
                                break;
                            case "FREE_2:":
                                this.textBoxFree_Two.Text = words[1];
                                break;
                            case "FREE_3:":
                                this.textBoxFree_Three.Text = words[1];
                                break;
                        }
                    }
                }
                Shared_Data.Update_Main_Data_Display = false;
                timer1.Enabled = true;

            }

            if (Shared_Data.I_Am_Server == true)
            {
                this.toolsToolStripMenuItem.DropDownItems[1].Enabled = true;
                this.toolsToolStripMenuItem.DropDownItems[2].Enabled = false;
                this.Text = "BHANSA Frequency Managament " + Shared_Data.Position_Name + " (Server)";
                distributeDataToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.toolsToolStripMenuItem.DropDownItems[1].Enabled = false;
                this.toolsToolStripMenuItem.DropDownItems[2].Enabled = true;
                this.Text = "BHANSA Frequency Managament " + Shared_Data.Position_Name + " (Client)";
                distributeDataToolStripMenuItem.Enabled = false;
            }

            if (Shared_Data.Server_Client_Mode_Changed == true)
            {
                Server_Connection_Settings_Form.Close();
                Clinet_Connection_Settings_Form.Close();

                Server_Connection_Settings_Form = new Server_Connection_Settings();
                Clinet_Connection_Settings_Form = new Client_Connection_Settings();

                Server_Connection_Settings_Form.Visible = false;
                Clinet_Connection_Settings_Form.Visible = false;

                if (Shared_Data.I_Am_Server == true)
                    Server_Connection_Settings_Form.Visible = true;
                else
                    Clinet_Connection_Settings_Form.Visible = true;

                Shared_Data.Server_Client_Mode_Changed = false;
            }

            if (Shared_Data.Is_Connected == false)
            {
                this.labelConnectionStatus.ForeColor = Color.Red;
                this.labelConnectionStatus.Text = "Disconnected";
            }
            else
            {
                this.labelConnectionStatus.ForeColor = Color.Green;
                this.labelConnectionStatus.Text = "Connected";
            }
        }

        private void generalSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GS.Visible = true;
        }

        private void distributeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Server_Connection_Settings.Is_Server_Connected() == true)
            {
                Shared_Data.Data_To_Distribute(Get_Current_Data_Set());
                Shared_Data.New_Distribution_Requested = true;

            }
            else
                MessageBox.Show("Server not running !");
        }
    }
}
