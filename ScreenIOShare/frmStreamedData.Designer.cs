namespace ScreenIOShare
{
    partial class frmStreamedData
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
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.tolStartStream = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStopStream = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maxAllowedResolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // picOutput
            // 
            this.picOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOutput.Enabled = false;
            this.picOutput.Location = new System.Drawing.Point(0, 0);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(946, 501);
            this.picOutput.TabIndex = 0;
            this.picOutput.TabStop = false;
            this.picOutput.Visible = false;
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStartStream,
            this.tolStopStream,
            this.windowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(944, 24);
            this.mnuOptions.TabIndex = 1;
            this.mnuOptions.Text = "menuStrip1";
            // 
            // tolStartStream
            // 
            this.tolStartStream.Name = "tolStartStream";
            this.tolStartStream.Size = new System.Drawing.Size(82, 20);
            this.tolStartStream.Text = "Start stream";
            this.tolStartStream.Click += new System.EventHandler(this.tolStartStream_Click);
            // 
            // tolStopStream
            // 
            this.tolStopStream.Name = "tolStopStream";
            this.tolStopStream.Size = new System.Drawing.Size(82, 20);
            this.tolStopStream.Text = "Stop stream";
            this.tolStopStream.Click += new System.EventHandler(this.tolStopStream_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToolStripMenuItem,
            this.maxAllowedResolutionToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            // 
            // enterToolStripMenuItem
            // 
            this.enterToolStripMenuItem.Name = "enterToolStripMenuItem";
            this.enterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enterToolStripMenuItem.Text = "Enter";
            this.enterToolStripMenuItem.Click += new System.EventHandler(this.enterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // maxAllowedResolutionToolStripMenuItem
            // 
            this.maxAllowedResolutionToolStripMenuItem.Name = "maxAllowedResolutionToolStripMenuItem";
            this.maxAllowedResolutionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.maxAllowedResolutionToolStripMenuItem.Text = "Max allowed resolution";
            this.maxAllowedResolutionToolStripMenuItem.Click += new System.EventHandler(this.maxAllowedResolutionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmStreamedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.mnuOptions);
            this.Controls.Add(this.picOutput);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmStreamedData";
            this.Text = "frmStreamedData";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStreamedData_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem tolStartStream;
        private System.Windows.Forms.ToolStripMenuItem tolStopStream;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxAllowedResolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}