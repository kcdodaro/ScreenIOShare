namespace ScreenIOShare
{
    partial class frmStreamTo
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
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblExtIPAddress = new System.Windows.Forms.Label();
            this.lblIntIPAddress = new System.Windows.Forms.Label();
            this.lblScreenHeight = new System.Windows.Forms.Label();
            this.lblScreenWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtIP = new System.Windows.Forms.TextBox();
            this.txtIntIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInfo
            // 
            this.lstInfo.Enabled = false;
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(12, 249);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(354, 199);
            this.lstInfo.TabIndex = 5;
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.label4);
            this.grpSettings.Controls.Add(this.txtKey);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Controls.Add(this.txtPort);
            this.grpSettings.Controls.Add(this.label2);
            this.grpSettings.Controls.Add(this.txtIntIP);
            this.grpSettings.Controls.Add(this.txtExtIP);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.btnSubmit);
            this.grpSettings.Location = new System.Drawing.Point(12, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(560, 231);
            this.grpSettings.TabIndex = 4;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Connection settings";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(479, 202);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblPort);
            this.grpInfo.Controls.Add(this.lblExtIPAddress);
            this.grpInfo.Controls.Add(this.lblIntIPAddress);
            this.grpInfo.Controls.Add(this.lblScreenHeight);
            this.grpInfo.Controls.Add(this.lblScreenWidth);
            this.grpInfo.Location = new System.Drawing.Point(372, 249);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(200, 200);
            this.grpInfo.TabIndex = 3;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Computer information";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(7, 72);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            // 
            // lblExtIPAddress
            // 
            this.lblExtIPAddress.AutoSize = true;
            this.lblExtIPAddress.Location = new System.Drawing.Point(7, 59);
            this.lblExtIPAddress.Name = "lblExtIPAddress";
            this.lblExtIPAddress.Size = new System.Drawing.Size(101, 13);
            this.lblExtIPAddress.TabIndex = 3;
            this.lblExtIPAddress.Text = "External IP address:";
            // 
            // lblIntIPAddress
            // 
            this.lblIntIPAddress.AutoSize = true;
            this.lblIntIPAddress.Location = new System.Drawing.Point(7, 46);
            this.lblIntIPAddress.Name = "lblIntIPAddress";
            this.lblIntIPAddress.Size = new System.Drawing.Size(98, 13);
            this.lblIntIPAddress.TabIndex = 2;
            this.lblIntIPAddress.Text = "Internal IP address:";
            // 
            // lblScreenHeight
            // 
            this.lblScreenHeight.AutoSize = true;
            this.lblScreenHeight.Location = new System.Drawing.Point(7, 33);
            this.lblScreenHeight.Name = "lblScreenHeight";
            this.lblScreenHeight.Size = new System.Drawing.Size(76, 13);
            this.lblScreenHeight.TabIndex = 1;
            this.lblScreenHeight.Text = "Screen height:";
            // 
            // lblScreenWidth
            // 
            this.lblScreenWidth.AutoSize = true;
            this.lblScreenWidth.Location = new System.Drawing.Point(7, 20);
            this.lblScreenWidth.Name = "lblScreenWidth";
            this.lblScreenWidth.Size = new System.Drawing.Size(72, 13);
            this.lblScreenWidth.TabIndex = 0;
            this.lblScreenWidth.Text = "Screen width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "External IP address";
            // 
            // txtExtIP
            // 
            this.txtExtIP.Location = new System.Drawing.Point(111, 17);
            this.txtExtIP.Name = "txtExtIP";
            this.txtExtIP.Size = new System.Drawing.Size(100, 20);
            this.txtExtIP.TabIndex = 5;
            // 
            // txtIntIP
            // 
            this.txtIntIP.Location = new System.Drawing.Point(111, 43);
            this.txtIntIP.Name = "txtIntIP";
            this.txtIntIP.Size = new System.Drawing.Size(100, 20);
            this.txtIntIP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Internal IP address";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(111, 69);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(16, 110);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(195, 112);
            this.txtKey.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Key";
            // 
            // frmStreamTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.grpInfo);
            this.Name = "frmStreamTo";
            this.Text = "frmStreamTo";
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblExtIPAddress;
        private System.Windows.Forms.Label lblIntIPAddress;
        private System.Windows.Forms.Label lblScreenHeight;
        private System.Windows.Forms.Label lblScreenWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntIP;
        private System.Windows.Forms.TextBox txtExtIP;
        private System.Windows.Forms.Label label1;
    }
}