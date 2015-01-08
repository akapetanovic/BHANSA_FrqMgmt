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
        public static Server_Connection_Settings Server_Connection_Settings_Form = new Server_Connection_Settings();
        public static Client_Connection_Settings Clinet_Connection_Settings_Form = new Client_Connection_Settings();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.checkBox_US_ZG.Checked = Properties.Settings.Default.CCL_US_Checked;
            this.checkBox_UN_ZG.Checked = Properties.Settings.Default.CCL_UN_Checked;
            this.checkBox_UW_ZG.Checked = Properties.Settings.Default.CCL_UW_Checked;
            this.checkBox_LS_ZG.Checked = Properties.Settings.Default.CCL_LS_Checked;
            this.checkBox_LN_ZG.Checked = Properties.Settings.Default.CCL_LN_Checked;
            this.checkBox_LW_ZG.Checked = Properties.Settings.Default.CCL_LW_Checked;

            if (this.checkBox_US_ZG.Checked)
            {
                this.textBox_CCL_US_Value.Text = Properties.Settings.Default.CCL_US_Value;
            }
            else
            {
                this.textBox_CCL_US_Value.Text = "";
                this.textBox_CCL_US_Value.Enabled = false;
            }

            if (this.checkBox_UN_ZG.Checked)
            {
                this.textBox_CCL_UN_Value.Text = Properties.Settings.Default.CCL_UN_Value;
            }
            else
            {
                this.textBox_CCL_UN_Value.Text = "";
                this.textBox_CCL_UN_Value.Enabled = false;
            }

            if (this.checkBox_UW_ZG.Checked)
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

            if (this.checkBox_LN_ZG.Checked)
            {
                this.textBox_CCL_LN_Value.Text = Properties.Settings.Default.CCL_LN_Value;
            }
            else
            {
                this.textBox_CCL_LN_Value.Text = "";
                this.textBox_CCL_LN_Value.Enabled = false;
            }

            if (this.checkBox_LW_ZG.Checked)
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
            p1 = new Point(checkBox_UN_ZG.Location.X - 10, 32);
            p2 = new Point(checkBox_UN_ZG.Location.X - 10, this.End_X_DOWN_ZG.Location.Y);
            e.Graphics.DrawLine(redPen, p1, p2);

            // Draw line using Point structure
            p1 = new Point(checkBox_UW_ZG.Location.X - 10, 32);
            p2 = new Point(checkBox_UW_ZG.Location.X - 10, this.End_X_DOWN_ZG.Location.Y);
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

            Properties.Settings.Default.CCL_UN_Checked = this.checkBox_UN_ZG.Checked;
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
            if (this.checkBox_UW_ZG.Checked)
            {
                this.textBox_CCL_UW_Value.Text = Properties.Settings.Default.CCL_UW_Value;
                this.textBox_CCL_UW_Value.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.CCL_UW_Value = this.textBox_CCL_UW_Value.Text;
                this.textBox_CCL_UW_Value.Text = "";
                this.textBox_CCL_UW_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_UW_Checked = this.checkBox_UW_ZG.Checked;
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
            if (this.checkBox_LN_ZG.Checked)
            {
                this.textBox_CCL_LN_Value.Text = Properties.Settings.Default.CCL_LN_Value;
                this.textBox_CCL_LN_Value.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.CCL_LN_Value = this.textBox_CCL_LN_Value.Text;
                this.textBox_CCL_LN_Value.Text = "";
                this.textBox_CCL_LN_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_LN_Checked = this.checkBox_LN_ZG.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_LW_ZG_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_LW_ZG.Checked)
            {
                this.textBox_CCL_LW_Value.Text = Properties.Settings.Default.CCL_LW_Value;
                this.textBox_CCL_LW_Value.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.CCL_LW_Value = this.textBox_CCL_LW_Value.Text;
                this.textBox_CCL_LW_Value.Text = "";
                this.textBox_CCL_LW_Value.Enabled = false;
            }

            Properties.Settings.Default.CCL_LW_Checked = this.checkBox_LW_ZG.Checked;
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

            if (this.checkBox_UN_ZG.Checked)
            {
                Properties.Settings.Default.CCL_UN_Value = this.textBox_CCL_UN_Value.Text;
            }
            if (this.checkBox_US_ZG.Checked)
            {
                Properties.Settings.Default.CCL_US_Value = this.textBox_CCL_US_Value.Text;
            }
            if (this.checkBox_UW_ZG.Checked)
            {
                Properties.Settings.Default.CCL_UW_Value = this.textBox_CCL_UW_Value.Text;
            }
            if (this.checkBox_LS_ZG.Checked)
            {
                Properties.Settings.Default.CCL_LS_Value = this.textBox_CCL_LS_Value.Text;
            }
            if (this.checkBox_LN_ZG.Checked)
            {
                Properties.Settings.Default.CCL_LN_Value = this.textBox_CCL_LN_Value.Text;
            }
            if (this.checkBox_LW_ZG.Checked)
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

            MessageBox.Show("Amer Kapetanovic\namer.kapetanovic@bhansa.gov.ba\nVersion 1.0\n25.12.2014");
        }

        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server_Connection_Settings_Form.Show();
        }

        private void clientConnectionSettingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clinet_Connection_Settings_Form.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
