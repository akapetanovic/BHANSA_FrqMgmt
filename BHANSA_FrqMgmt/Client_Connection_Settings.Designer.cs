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
            this.comboBoxNetworkInterface = new System.Windows.Forms.ComboBox();
            this.txtboxIPAddress = new System.Windows.Forms.TextBox();
            this.textboxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Server_Interface = new System.Windows.Forms.Label();
            this.listBoxRcvData = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnectServerBroadcast);
            this.groupBox1.Controls.Add(this.comboBoxNetworkInterface);
            this.groupBox1.Controls.Add(this.txtboxIPAddress);
            this.groupBox1.Controls.Add(this.textboxPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Server_Interface);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Broadcast Connection Settings";
            // 
            // btnConnectServerBroadcast
            // 
            this.btnConnectServerBroadcast.BackColor = System.Drawing.Color.Red;
            this.btnConnectServerBroadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectServerBroadcast.Location = new System.Drawing.Point(10, 139);
            this.btnConnectServerBroadcast.Name = "btnConnectServerBroadcast";
            this.btnConnectServerBroadcast.Size = new System.Drawing.Size(404, 35);
            this.btnConnectServerBroadcast.TabIndex = 63;
            this.btnConnectServerBroadcast.Text = "Connect";
            this.btnConnectServerBroadcast.UseVisualStyleBackColor = false;
            this.btnConnectServerBroadcast.Click += new System.EventHandler(this.btnConnectServerBroadcast_Click);
            // 
            // comboBoxNetworkInterface
            // 
            this.comboBoxNetworkInterface.FormattingEnabled = true;
            this.comboBoxNetworkInterface.Location = new System.Drawing.Point(145, 29);
            this.comboBoxNetworkInterface.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNetworkInterface.Name = "comboBoxNetworkInterface";
            this.comboBoxNetworkInterface.Size = new System.Drawing.Size(269, 24);
            this.comboBoxNetworkInterface.TabIndex = 62;
            // 
            // txtboxIPAddress
            // 
            this.txtboxIPAddress.Location = new System.Drawing.Point(145, 66);
            this.txtboxIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxIPAddress.Name = "txtboxIPAddress";
            this.txtboxIPAddress.Size = new System.Drawing.Size(269, 22);
            this.txtboxIPAddress.TabIndex = 60;
            this.txtboxIPAddress.Text = "238.1.1.1";
            // 
            // textboxPort
            // 
            this.textboxPort.Location = new System.Drawing.Point(145, 99);
            this.textboxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPort.Name = "textboxPort";
            this.textboxPort.Size = new System.Drawing.Size(269, 22);
            this.textboxPort.TabIndex = 61;
            this.textboxPort.Text = "2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Multicast Addr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Port:";
            // 
            // Server_Interface
            // 
            this.Server_Interface.AutoSize = true;
            this.Server_Interface.Location = new System.Drawing.Point(7, 32);
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
            this.listBoxRcvData.Location = new System.Drawing.Point(12, 218);
            this.listBoxRcvData.Name = "listBoxRcvData";
            this.listBoxRcvData.Size = new System.Drawing.Size(432, 244);
            this.listBoxRcvData.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client_Connection_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 502);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxRcvData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Client_Connection_Settings";
            this.Text = "Connection Settings";
            this.Load += new System.EventHandler(this.Client_Connection_Settings_Load);
            this.VisibleChanged += new System.EventHandler(this.Client_Connection_Settings_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnectServerBroadcast;
        private System.Windows.Forms.ComboBox comboBoxNetworkInterface;
        private System.Windows.Forms.TextBox txtboxIPAddress;
        private System.Windows.Forms.TextBox textboxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Server_Interface;
        private System.Windows.Forms.ListBox listBoxRcvData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}