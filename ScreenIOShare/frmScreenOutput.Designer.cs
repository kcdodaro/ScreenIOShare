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
            ((System.ComponentModel.ISupportInitialize)(this.picScreenOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // picScreenOutput
            // 
            this.picScreenOutput.Location = new System.Drawing.Point(12, 12);
            this.picScreenOutput.Name = "picScreenOutput";
            this.picScreenOutput.Size = new System.Drawing.Size(100, 50);
            this.picScreenOutput.TabIndex = 0;
            this.picScreenOutput.TabStop = false;
            // 
            // frmScreenOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.picScreenOutput);
            this.Name = "frmScreenOutput";
            this.Text = "frmScreenOutput";
            this.Load += new System.EventHandler(this.frmScreenOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScreenOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picScreenOutput;
    }
}