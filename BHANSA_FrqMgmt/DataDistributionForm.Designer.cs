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
            this.label_CWP3_Update_Time = new System.Windows.Forms.Label();
            this.label_CWP2_Update_Time = new System.Windows.Forms.Label();
            this.label_CWP1_Update_Time = new System.Windows.Forms.Label();
            this.CWP3_Update_Status = new System.Windows.Forms.Button();
            this.CWP2_Update_Status = new System.Windows.Forms.Button();
            this.CWP1_Update_Status = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.groupBoxConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxConnectionStatus.Location = new System.Drawing.Point(9, 10);
            this.groupBoxConnectionStatus.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxConnectionStatus.Name = "groupBoxConnectionStatus";
            this.groupBoxConnectionStatus.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxConnectionStatus.Size = new System.Drawing.Size(451, 84);
            this.groupBoxConnectionStatus.TabIndex = 0;
            this.groupBoxConnectionStatus.TabStop = false;
            this.groupBoxConnectionStatus.Text = "Current CWP Connection Status";
            // 
            // CWP2
            // 
            this.CWP2.BackColor = System.Drawing.Color.Red;
            this.CWP2.Enabled = false;
            this.CWP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CWP2.Location = new System.Drawing.Point(154, 26);
            this.CWP2.Margin = new System.Windows.Forms.Padding(2);
            this.CWP2.Name = "CWP2";
            this.CWP2.Size = new System.Drawing.Size(138, 43);
            this.CWP2.TabIndex = 2;
            this.CWP2.Text = "CWP 2";
            this.CWP2.UseVisualStyleBackColor = false;
            // 
            // CWP3
            // 
            this.CWP3.BackColor = System.Drawing.Color.Red;
            this.CWP3.Enabled = false;
            this.CWP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CWP3.Location = new System.Drawing.Point(304, 26);
            this.CWP3.Margin = new System.Windows.Forms.Padding(2);
            this.CWP3.Name = "CWP3";
            this.CWP3.Size = new System.Drawing.Size(138, 43);
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
            this.CWP1.Location = new System.Drawing.Point(4, 26);
            this.CWP1.Margin = new System.Windows.Forms.Padding(2);
            this.CWP1.Name = "CWP1";
            this.CWP1.Size = new System.Drawing.Size(138, 43);
            this.CWP1.TabIndex = 0;
            this.CWP1.Text = "CWP 1";
            this.CWP1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_CWP3_Update_Time);
            this.groupBox1.Controls.Add(this.label_CWP2_Update_Time);
            this.groupBox1.Controls.Add(this.label_CWP1_Update_Time);
            this.groupBox1.Controls.Add(this.CWP3_Update_Status);
            this.groupBox1.Controls.Add(this.CWP2_Update_Status);
            this.groupBox1.Controls.Add(this.CWP1_Update_Status);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(9, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(451, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Succefull Distribution";
            // 
            // label_CWP3_Update_Time
            // 
            this.label_CWP3_Update_Time.AutoSize = true;
            this.label_CWP3_Update_Time.Location = new System.Drawing.Point(301, 66);
            this.label_CWP3_Update_Time.Name = "label_CWP3_Update_Time";
            this.label_CWP3_Update_Time.Size = new System.Drawing.Size(30, 13);
            this.label_CWP3_Update_Time.TabIndex = 5;
            this.label_CWP3_Update_Time.Text = "N/A";
            // 
            // label_CWP2_Update_Time
            // 
            this.label_CWP2_Update_Time.AutoSize = true;
            this.label_CWP2_Update_Time.Location = new System.Drawing.Point(151, 63);
            this.label_CWP2_Update_Time.Name = "label_CWP2_Update_Time";
            this.label_CWP2_Update_Time.Size = new System.Drawing.Size(30, 13);
            this.label_CWP2_Update_Time.TabIndex = 4;
            this.label_CWP2_Update_Time.Text = "N/A";
            // 
            // label_CWP1_Update_Time
            // 
            this.label_CWP1_Update_Time.AutoSize = true;
            this.label_CWP1_Update_Time.Location = new System.Drawing.Point(5, 63);
            this.label_CWP1_Update_Time.Name = "label_CWP1_Update_Time";
            this.label_CWP1_Update_Time.Size = new System.Drawing.Size(30, 13);
            this.label_CWP1_Update_Time.TabIndex = 3;
            this.label_CWP1_Update_Time.Text = "N/A";
            // 
            // CWP3_Update_Status
            // 
            this.CWP3_Update_Status.BackColor = System.Drawing.Color.Red;
            this.CWP3_Update_Status.Enabled = false;
            this.CWP3_Update_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CWP3_Update_Status.Location = new System.Drawing.Point(304, 18);
            this.CWP3_Update_Status.Margin = new System.Windows.Forms.Padding(2);
            this.CWP3_Update_Status.Name = "CWP3_Update_Status";
            this.CWP3_Update_Status.Size = new System.Drawing.Size(138, 43);
            this.CWP3_Update_Status.TabIndex = 2;
            this.CWP3_Update_Status.Text = "CWP 3";
            this.CWP3_Update_Status.UseVisualStyleBackColor = false;
            // 
            // CWP2_Update_Status
            // 
            this.CWP2_Update_Status.BackColor = System.Drawing.Color.Red;
            this.CWP2_Update_Status.Enabled = false;
            this.CWP2_Update_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CWP2_Update_Status.Location = new System.Drawing.Point(154, 18);
            this.CWP2_Update_Status.Margin = new System.Windows.Forms.Padding(2);
            this.CWP2_Update_Status.Name = "CWP2_Update_Status";
            this.CWP2_Update_Status.Size = new System.Drawing.Size(138, 43);
            this.CWP2_Update_Status.TabIndex = 1;
            this.CWP2_Update_Status.Text = "CWP 2";
            this.CWP2_Update_Status.UseVisualStyleBackColor = false;
            // 
            // CWP1_Update_Status
            // 
            this.CWP1_Update_Status.BackColor = System.Drawing.Color.Red;
            this.CWP1_Update_Status.Enabled = false;
            this.CWP1_Update_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CWP1_Update_Status.Location = new System.Drawing.Point(4, 18);
            this.CWP1_Update_Status.Margin = new System.Windows.Forms.Padding(2);
            this.CWP1_Update_Status.Name = "CWP1_Update_Status";
            this.CWP1_Update_Status.Size = new System.Drawing.Size(138, 43);
            this.CWP1_Update_Status.TabIndex = 0;
            this.CWP1_Update_Status.Text = "CWP 1";
            this.CWP1_Update_Status.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(9, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Distribute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(364, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataDistributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 225);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxConnectionStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataDistributionForm";
            this.Text = "Data Distribution";
            this.Load += new System.EventHandler(this.DataDistributionForm_Load);
            this.groupBoxConnectionStatus.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button CWP1_Update_Status;
        private System.Windows.Forms.Button CWP3_Update_Status;
        private System.Windows.Forms.Button CWP2_Update_Status;
        private System.Windows.Forms.Label label_CWP2_Update_Time;
        private System.Windows.Forms.Label label_CWP1_Update_Time;
        private System.Windows.Forms.Label label_CWP3_Update_Time;
        private System.Windows.Forms.Button button2;
    }
}