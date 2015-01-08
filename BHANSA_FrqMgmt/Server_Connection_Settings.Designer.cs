﻿namespace BHANSA_FrqMgmt
{
    partial class Server_Connection_Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnectServerBroadcast = new System.Windows.Forms.Button();
            this.comboBoxNetworkInterface = new System.Windows.Forms.ComboBox();
            this.txtboxIPAddress = new System.Windows.Forms.TextBox();
            this.textboxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Server_Interface = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConnectCWP1 = new System.Windows.Forms.Button();
            this.txtMulticastCWP1 = new System.Windows.Forms.TextBox();
            this.txtPortCWP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConnectCWP2 = new System.Windows.Forms.Button();
            this.txtMulticastCWP2 = new System.Windows.Forms.TextBox();
            this.txtPortCWP2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnConnectCWP3 = new System.Windows.Forms.Button();
            this.txtMulticastCWP3 = new System.Windows.Forms.TextBox();
            this.txtPortCWP3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewReceivedData = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(314, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Settings";
            // 
            // btnConnectServerBroadcast
            // 
            this.btnConnectServerBroadcast.BackColor = System.Drawing.Color.Red;
            this.btnConnectServerBroadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectServerBroadcast.Location = new System.Drawing.Point(10, 128);
            this.btnConnectServerBroadcast.Name = "btnConnectServerBroadcast";
            this.btnConnectServerBroadcast.Size = new System.Drawing.Size(288, 35);
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
            this.comboBoxNetworkInterface.Size = new System.Drawing.Size(153, 24);
            this.comboBoxNetworkInterface.TabIndex = 62;
            // 
            // txtboxIPAddress
            // 
            this.txtboxIPAddress.Location = new System.Drawing.Point(145, 66);
            this.txtboxIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxIPAddress.Name = "txtboxIPAddress";
            this.txtboxIPAddress.Size = new System.Drawing.Size(153, 22);
            this.txtboxIPAddress.TabIndex = 60;
            this.txtboxIPAddress.Text = "238.1.1.1";
            // 
            // textboxPort
            // 
            this.textboxPort.Location = new System.Drawing.Point(145, 99);
            this.textboxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPort.Name = "textboxPort";
            this.textboxPort.Size = new System.Drawing.Size(153, 22);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnectCWP1);
            this.groupBox2.Controls.Add(this.txtMulticastCWP1);
            this.groupBox2.Controls.Add(this.txtPortCWP1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client (CWP 1)";
            // 
            // btnConnectCWP1
            // 
            this.btnConnectCWP1.BackColor = System.Drawing.Color.Red;
            this.btnConnectCWP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCWP1.Location = new System.Drawing.Point(6, 88);
            this.btnConnectCWP1.Name = "btnConnectCWP1";
            this.btnConnectCWP1.Size = new System.Drawing.Size(288, 35);
            this.btnConnectCWP1.TabIndex = 63;
            this.btnConnectCWP1.Text = "Connect";
            this.btnConnectCWP1.UseVisualStyleBackColor = false;
            this.btnConnectCWP1.Click += new System.EventHandler(this.btnConnectCWP1_Click);
            // 
            // txtMulticastCWP1
            // 
            this.txtMulticastCWP1.Location = new System.Drawing.Point(145, 26);
            this.txtMulticastCWP1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMulticastCWP1.Name = "txtMulticastCWP1";
            this.txtMulticastCWP1.Size = new System.Drawing.Size(153, 22);
            this.txtMulticastCWP1.TabIndex = 60;
            this.txtMulticastCWP1.Text = "238.1.1.1";
            this.txtMulticastCWP1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPortCWP1
            // 
            this.txtPortCWP1.Location = new System.Drawing.Point(145, 59);
            this.txtPortCWP1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortCWP1.Name = "txtPortCWP1";
            this.txtPortCWP1.Size = new System.Drawing.Size(153, 22);
            this.txtPortCWP1.TabIndex = 61;
            this.txtPortCWP1.Text = "2001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Multicast Addr:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Port:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConnectCWP2);
            this.groupBox3.Controls.Add(this.txtMulticastCWP2);
            this.groupBox3.Controls.Add(this.txtPortCWP2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client (CWP 2)";
            // 
            // btnConnectCWP2
            // 
            this.btnConnectCWP2.BackColor = System.Drawing.Color.Red;
            this.btnConnectCWP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCWP2.Location = new System.Drawing.Point(10, 88);
            this.btnConnectCWP2.Name = "btnConnectCWP2";
            this.btnConnectCWP2.Size = new System.Drawing.Size(288, 35);
            this.btnConnectCWP2.TabIndex = 63;
            this.btnConnectCWP2.Text = "Connect";
            this.btnConnectCWP2.UseVisualStyleBackColor = false;
            // 
            // txtMulticastCWP2
            // 
            this.txtMulticastCWP2.Location = new System.Drawing.Point(145, 26);
            this.txtMulticastCWP2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMulticastCWP2.Name = "txtMulticastCWP2";
            this.txtMulticastCWP2.Size = new System.Drawing.Size(153, 22);
            this.txtMulticastCWP2.TabIndex = 60;
            this.txtMulticastCWP2.Text = "238.1.1.1";
            // 
            // txtPortCWP2
            // 
            this.txtPortCWP2.Location = new System.Drawing.Point(145, 59);
            this.txtPortCWP2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortCWP2.Name = "txtPortCWP2";
            this.txtPortCWP2.Size = new System.Drawing.Size(153, 22);
            this.txtPortCWP2.TabIndex = 61;
            this.txtPortCWP2.Text = "2002";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Multicast Addr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Port:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnConnectCWP3);
            this.groupBox4.Controls.Add(this.txtMulticastCWP3);
            this.groupBox4.Controls.Add(this.txtPortCWP3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 455);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 124);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client (CWP 3)";
            // 
            // btnConnectCWP3
            // 
            this.btnConnectCWP3.BackColor = System.Drawing.Color.Red;
            this.btnConnectCWP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCWP3.Location = new System.Drawing.Point(10, 81);
            this.btnConnectCWP3.Name = "btnConnectCWP3";
            this.btnConnectCWP3.Size = new System.Drawing.Size(288, 35);
            this.btnConnectCWP3.TabIndex = 63;
            this.btnConnectCWP3.Text = "Connect";
            this.btnConnectCWP3.UseVisualStyleBackColor = false;
            // 
            // txtMulticastCWP3
            // 
            this.txtMulticastCWP3.Location = new System.Drawing.Point(145, 19);
            this.txtMulticastCWP3.Margin = new System.Windows.Forms.Padding(4);
            this.txtMulticastCWP3.Name = "txtMulticastCWP3";
            this.txtMulticastCWP3.Size = new System.Drawing.Size(153, 22);
            this.txtMulticastCWP3.TabIndex = 60;
            this.txtMulticastCWP3.Text = "238.1.1.1";
            // 
            // txtPortCWP3
            // 
            this.txtPortCWP3.Location = new System.Drawing.Point(145, 52);
            this.txtPortCWP3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortCWP3.Name = "txtPortCWP3";
            this.txtPortCWP3.Size = new System.Drawing.Size(153, 22);
            this.txtPortCWP3.TabIndex = 61;
            this.txtPortCWP3.Text = "2003";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Multicast Addr:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Port:";
            // 
            // listViewReceivedData
            // 
            this.listViewReceivedData.Location = new System.Drawing.Point(332, 32);
            this.listViewReceivedData.Name = "listViewReceivedData";
            this.listViewReceivedData.Size = new System.Drawing.Size(520, 539);
            this.listViewReceivedData.TabIndex = 65;
            this.listViewReceivedData.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Received Data";
            // 
            // Server_Connection_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 577);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewReceivedData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server_Connection_Settings";
            this.Text = "Connection Settings";
            this.Load += new System.EventHandler(this.Server_Connection_Settings_Load);
            this.VisibleChanged += new System.EventHandler(this.Server_Connection_Settings_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxNetworkInterface;
        private System.Windows.Forms.TextBox txtboxIPAddress;
        private System.Windows.Forms.TextBox textboxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Server_Interface;
        private System.Windows.Forms.Button btnConnectServerBroadcast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnectCWP1;
        private System.Windows.Forms.TextBox txtMulticastCWP1;
        private System.Windows.Forms.TextBox txtPortCWP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConnectCWP2;
        private System.Windows.Forms.TextBox txtMulticastCWP2;
        private System.Windows.Forms.TextBox txtPortCWP2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnConnectCWP3;
        private System.Windows.Forms.TextBox txtMulticastCWP3;
        private System.Windows.Forms.TextBox txtPortCWP3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewReceivedData;
        private System.Windows.Forms.Label label5;
    }
}