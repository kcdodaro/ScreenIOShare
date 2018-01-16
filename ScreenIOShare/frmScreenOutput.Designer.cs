namespace ScreenIOShare
{
    partial class frmScreenOutput
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
            this.picScreenOutput = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFPS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // picScreenOutput
            // 
            this.picScreenOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picScreenOutput.Location = new System.Drawing.Point(12, 12);
            this.picScreenOutput.Name = "picScreenOutput";
            this.picScreenOutput.Size = new System.Drawing.Size(960, 540);
            this.picScreenOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScreenOutput.TabIndex = 0;
            this.picScreenOutput.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1028, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(0, -1);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(33, 13);
            this.lblFPS.TabIndex = 2;
            this.lblFPS.Text = "FPS: ";
            // 
            // frmScreenOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 637);
            this.Controls.Add(this.lblFPS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picScreenOutput);
            this.Name = "frmScreenOutput";
            this.Text = "frmScreenOutput";
            this.Load += new System.EventHandler(this.frmScreenOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScreenOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picScreenOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFPS;
    }
}