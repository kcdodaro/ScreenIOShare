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
    public partial class frmScreenOutput : Form
    {
        public frmScreenOutput()
        {
            InitializeComponent();
        }

        private void frmScreenOutput_Load(object sender, EventArgs e)
        {
            picScreenOutput.Width = (int)SystemParameters.VirtualScreenWidth / 2;
            picScreenOutput.Width = (int)SystemParameters.VirtualScreenHeight / 2;
        }
    }
}
