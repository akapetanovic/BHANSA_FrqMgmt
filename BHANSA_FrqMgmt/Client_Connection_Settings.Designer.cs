namespace BHANSA_FrqMgmt
{
    partial class Client_Connection_Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnectServerBroadcast = new System.Windows.Forms.Button();
            this.txtboxServerMulticastAddress = new System.Windows.Forms.TextBox();
            this.textboxServerMulticastPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNetworkInterface = new System.Windows.Forms.ComboBox();
            this.Server_Interface = new System.Windows.Forms.Label();
            this.listBoxRcvData = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxClientMulticastAddress = new System.Windows.Forms.TextBox();
            this.textBoxClientMulticastPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnectServerBroadcast);
            this.groupBox1.Controls.Add(this.txtboxServerMulticastAddress);
            this.groupBox1.Controls.Add(this.textboxServerMulticastPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Broadcast Connection Settings";
            // 
            // btnConnectServerBroadcast
            // 
            this.btnConnectServerBroadcast.BackColor = System.Drawing.Color.Red;
            this.btnConnectServerBroadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectServerBroadcast.Location = new System.Drawing.Point(10, 80);
            this.btnConnectServerBroadcast.Name = "btnConnectServerBroadcast";
            this.btnConnectServerBroadcast.Size = new System.Drawing.Size(289, 35);
            this.btnConnectServerBroadcast.TabIndex = 63;
            this.btnConnectServerBroadcast.Text = "Connect";
            this.btnConnectServerBroadcast.UseVisualStyleBackColor = false;
            this.btnConnectServerBroadcast.Click += new System.EventHandler(this.btnConnectServerBroadcast_Click);
            // 
            // txtboxServerMulticastAddress
            // 
            this.txtboxServerMulticastAddress.Location = new System.Drawing.Point(144, 18);
            this.txtboxServerMulticastAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxServerMulticastAddress.Name = "txtboxServerMulticastAddress";
            this.txtboxServerMulticastAddress.Size = new System.Drawing.Size(155, 22);
            this.txtboxServerMulticastAddress.TabIndex = 60;
            this.txtboxServerMulticastAddress.Text = "238.1.1.1";
            // 
            // textboxServerMulticastPort
            // 
            this.textboxServerMulticastPort.Location = new System.Drawing.Point(144, 51);
            this.textboxServerMulticastPort.Margin = new System.Windows.Forms.Padding(4);
            this.textboxServerMulticastPort.Name = "textboxServerMulticastPort";
            this.textboxServerMulticastPort.Size = new System.Drawing.Size(155, 22);
            this.textboxServerMulticastPort.TabIndex = 61;
            this.textboxServerMulticastPort.Text = "2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Multicast Addr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Port:";
            // 
            // comboBoxNetworkInterface
            // 
            this.comboBoxNetworkInterface.FormattingEnabled = true;
            this.comboBoxNetworkInterface.Location = new System.Drawing.Point(156, 5);
            this.comboBoxNetworkInterface.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNetworkInterface.Name = "comboBoxNetworkInterface";
            this.comboBoxNetworkInterface.Size = new System.Drawing.Size(158, 24);
            this.comboBoxNetworkInterface.TabIndex = 62;
            // 
            // Server_Interface
            // 
            this.Server_Interface.AutoSize = true;
            this.Server_Interface.Location = new System.Drawing.Point(9, 8);
            this.Server_Interface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Server_Interface.Name = "Server_Interface";
            this.Server_Interface.Size = new System.Drawing.Size(139, 17);
            this.Server_Interface.TabIndex = 26;
            this.Server_Interface.Text = "Local Interface Addr:";
            // 
            // listBoxRcvData
            // 
            this.listBoxRcvData.FormattingEnabled = true;
            this.listBoxRcvData.ItemHeight = 16;
            this.listBoxRcvData.Location = new System.Drawing.Point(328, 5);
            this.listBoxRcvData.Name = "listBoxRcvData";
            this.listBoxRcvData.Size = new System.Drawing.Size(294, 276);
            this.listBoxRcvData.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(618, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBoxClientMulticastAddress);
            this.groupBox2.Controls.Add(this.textBoxClientMulticastPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 122);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Broadcast Connection Settings";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 35);
            this.button2.TabIndex = 63;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBoxClientMulticastAddress
            // 
            this.textBoxClientMulticastAddress.Location = new System.Drawing.Point(144, 18);
            this.textBoxClientMulticastAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClientMulticastAddress.Name = "textBoxClientMulticastAddress";
            this.textBoxClientMulticastAddress.Size = new System.Drawing.Size(155, 22);
            this.textBoxClientMulticastAddress.TabIndex = 60;
            this.textBoxClientMulticastAddress.Text = "238.1.1.1";
            // 
            // textBoxClientMulticastPort
            // 
            this.textBoxClientMulticastPort.Location = new System.Drawing.Point(144, 51);
            this.textBoxClientMulticastPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClientMulticastPort.Name = "textBoxClientMulticastPort";
            this.textBoxClientMulticastPort.Size = new System.Drawing.Size(155, 22);
            this.textBoxClientMulticastPort.TabIndex = 61;
            this.textBoxClientMulticastPort.Text = "2001";
            this.textBoxClientMulticastPort.TextChanged += new System.EventHandler(this.textBoxClientMulticastPort_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Multicast Addr:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Port:";
            // 
            // Client_Connection_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 320);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxNetworkInterface);
            this.Controls.Add(this.listBoxRcvData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Server_Interface);
            this.Name = "Client_Connection_Settings";
            this.Text = "Connection Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_Connection_Settings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_Connection_Settings_FormClosed);
            this.Load += new System.EventHandler(this.Client_Connection_Settings_Load);
            this.VisibleChanged += new System.EventHandler(this.Client_Connection_Settings_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnectServerBroadcast;
        private System.Windows.Forms.ComboBox comboBoxNetworkInterface;
        private System.Windows.Forms.TextBox txtboxServerMulticastAddress;
        private System.Windows.Forms.TextBox textboxServerMulticastPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Server_Interface;
        private System.Windows.Forms.ListBox listBoxRcvData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxClientMulticastAddress;
        private System.Windows.Forms.TextBox textBoxClientMulticastPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}