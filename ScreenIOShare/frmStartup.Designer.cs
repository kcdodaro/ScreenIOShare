namespace ScreenIOShare
{
    partial class frmStartup
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
            this.btnStreamFrom = new System.Windows.Forms.Button();
            this.btnStreamTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStreamFrom
            // 
            this.btnStreamFrom.Location = new System.Drawing.Point(78, 12);
            this.btnStreamFrom.Name = "btnStreamFrom";
            this.btnStreamFrom.Size = new System.Drawing.Size(133, 23);
            this.btnStreamFrom.TabIndex = 0;
            this.btnStreamFrom.TabStop = false;
            this.btnStreamFrom.Text = "Stream from this machine";
            this.btnStreamFrom.UseVisualStyleBackColor = true;
            this.btnStreamFrom.Click += new System.EventHandler(this.btnStreamFrom_Click);
            // 
            // btnStreamTo
            // 
            this.btnStreamTo.Location = new System.Drawing.Point(78, 54);
            this.btnStreamTo.Name = "btnStreamTo";
            this.btnStreamTo.Size = new System.Drawing.Size(133, 23);
            this.btnStreamTo.TabIndex = 1;
            this.btnStreamTo.TabStop = false;
            this.btnStreamTo.Text = "Stream to this machine";
            this.btnStreamTo.UseVisualStyleBackColor = true;
            this.btnStreamTo.Click += new System.EventHandler(this.btnStreamTo_Click);
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnStreamTo);
            this.Controls.Add(this.btnStreamFrom);
            this.Name = "frmStartup";
            this.Text = "frmStartup";
            this.Load += new System.EventHandler(this.frmStartup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStreamFrom;
        private System.Windows.Forms.Button btnStreamTo;
    }
}