using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace ScreenIOShare
{
    public partial class frmStreamedData : Form
    {
        public frmStreamedData()
        {
            InitializeComponent();
        }

        private void tolStartStream_Click(object sender, EventArgs e)
        {

        }

        private void tolStopStream_Click(object sender, EventArgs e)
        {

        }

        private void maxAllowedResolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void frmStreamedData_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F8)
            {
                if (mnuOptions.Enabled == false && mnuOptions.Visible == false)
                {
                    mnuOptions.Enabled = true;
                    mnuOptions.Visible = true;
                }
                else
                {
                    mnuOptions.Enabled = false;
                    mnuOptions.Visible = false;
                }
            }
        }
    }
}
