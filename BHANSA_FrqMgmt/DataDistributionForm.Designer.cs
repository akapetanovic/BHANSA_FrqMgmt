namespace BHANSA_FrqMgmt
{
    partial class DataDistributionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataDistributionForm));
            this.timerStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxConnectionStatus = new System.Windows.Forms.GroupBox();
            this.CWP2 = new System.Windows.Forms.Button();
            this.CWP3 = new System.Windows.Forms.Button();
            this.CWP1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxConnectionStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerStatusTimer
            // 
            this.timerStatusTimer.Enabled = true;
            this.timerStatusTimer.Interval = 3500;
            this.timerStatusTimer.Tick += new System.EventHandler(this.timerStatusTimer_Tick);
            // 
            // groupBoxConnectionStatus
            // 
            this.groupBoxConnectionStatus.Controls.Add(this.CWP2);
            this.groupBoxConnectionStatus.Controls.Add(this.CWP3);
            this.groupBoxConnectionStatus.Controls.Add(this.CWP1);
            this.groupBoxConnectionStatus.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnectionStatus.Name = "groupBoxConnectionStatus";
            this.groupBoxConnectionStatus.Size = new System.Drawing.Size(431, 104);
            this.groupBoxConnectionStatus.TabIndex = 0;
            this.groupBoxConnectionStatus.TabStop = false;
            this.groupBoxConnectionStatus.Text = "Current CWP Connection Status";
            // 
            // CWP2
            // 
            this.CWP2.BackColor = System.Drawing.Color.Red;
            this.CWP2.Enabled = false;
            this.CWP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CWP2.Location = new System.Drawing.Point(150, 32);
            this.CWP2.Name = "CWP2";
            this.CWP2.Size = new System.Drawing.Size(98, 53);
            this.CWP2.TabIndex = 2;
            this.CWP2.Text = "CWP 2";
            this.CWP2.UseVisualStyleBackColor = false;
            // 
            // CWP3
            // 
            this.CWP3.BackColor = System.Drawing.Color.Red;
            this.CWP3.Enabled = false;
            this.CWP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CWP3.Location = new System.Drawing.Point(274, 32);
            this.CWP3.Name = "CWP3";
            this.CWP3.Size = new System.Drawing.Size(97, 53);
            this.CWP3.TabIndex = 1;
            this.CWP3.Text = "CWP 3";
            this.CWP3.UseVisualStyleBackColor = false;
            this.CWP3.Click += new System.EventHandler(this.CWP3_Click);
            // 
            // CWP1
            // 
            this.CWP1.BackColor = System.Drawing.Color.Red;
            this.CWP1.Enabled = false;
            this.CWP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CWP1.Location = new System.Drawing.Point(23, 32);
            this.CWP1.Name = "CWP1";
            this.CWP1.Size = new System.Drawing.Size(97, 53);
            this.CWP1.TabIndex = 0;
            this.CWP1.Text = "CWP 1";
            this.CWP1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Succefull Distribution";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Distribute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 53);
            this.button2.TabIndex = 0;
            this.button2.Text = "CWP 1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 53);
            this.button3.TabIndex = 1;
            this.button3.Text = "CWP 2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(274, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 53);
            this.button4.TabIndex = 2;
            this.button4.Text = "CWP 3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // DataDistributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxConnectionStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataDistributionForm";
            this.Text = "Data Distribution";
            this.Load += new System.EventHandler(this.DataDistributionForm_Load);
            this.groupBoxConnectionStatus.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerStatusTimer;
        private System.Windows.Forms.GroupBox groupBoxConnectionStatus;
        private System.Windows.Forms.Button CWP2;
        private System.Windows.Forms.Button CWP3;
        private System.Windows.Forms.Button CWP1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}