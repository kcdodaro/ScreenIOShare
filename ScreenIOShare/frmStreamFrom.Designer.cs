﻿namespace ScreenIOShare
{
    partial class frmStreamFrom
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.radScreenOnly = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radAllShare = new System.Windows.Forms.RadioButton();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Location = new System.Drawing.Point(372, 249);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(200, 200);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Computer information";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnSubmit);
            this.grpSettings.Controls.Add(this.radAllShare);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.radScreenOnly);
            this.grpSettings.Location = new System.Drawing.Point(12, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(560, 231);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Connection settings";
            // 
            // radScreenOnly
            // 
            this.radScreenOnly.AutoSize = true;
            this.radScreenOnly.Location = new System.Drawing.Point(10, 59);
            this.radScreenOnly.Name = "radScreenOnly";
            this.radScreenOnly.Size = new System.Drawing.Size(110, 17);
            this.radScreenOnly.TabIndex = 0;
            this.radScreenOnly.TabStop = true;
            this.radScreenOnly.Text = "Screen share only";
            this.radScreenOnly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Workability";
            // 
            // radAllShare
            // 
            this.radAllShare.AutoSize = true;
            this.radAllShare.Location = new System.Drawing.Point(10, 36);
            this.radAllShare.Name = "radAllShare";
            this.radAllShare.Size = new System.Drawing.Size(125, 17);
            this.radAllShare.TabIndex = 2;
            this.radAllShare.TabStop = true;
            this.radAllShare.Text = "Screen and IO Share";
            this.radAllShare.UseVisualStyleBackColor = true;
            // 
            // lstInfo
            // 
            this.lstInfo.Enabled = false;
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(12, 249);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(354, 199);
            this.lstInfo.TabIndex = 2;
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
            // frmStreamFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.grpInfo);
            this.Name = "frmStreamFrom";
            this.Text = "frmStreamFrom";
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.RadioButton radAllShare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radScreenOnly;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstInfo;
    }
}