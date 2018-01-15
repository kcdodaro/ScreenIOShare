using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenIOShare
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void btnStreamFrom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form streamFrom = new frmStreamFrom();
            streamFrom.Show();
        }

        private void btnStreamTo_Click(object sender, EventArgs e)
        {

        }
    }
}
