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
    public partial class frmStreamTo : Form
    {
        public frmStreamTo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strExternalIP = txtExtIP.Text;
            string strInternalIP = txtIntIP.Text;
            string strPort = txtPort.Text;
            string strKey = txtKey.Text;
            bool success = false;

            if (strExternalIP != "" && strInternalIP != "" && strPort != "" && strKey != "")
            {
                success = attemptConnection(strExternalIP, strInternalIP, strPort, strKey);
                if (success)
                {
                    Form streamedData = new frmStreamedData();
                    streamedData.Show();
                }
            }
            else
            {
                MessageBox.Show("Not all required information was entered. Ensure that you have put information in all boxes.");
            }
        }

        bool attemptConnection(string ExternalIP, string InternalIP, string Port, string Key)
        {
            return true;
        }
    }
}
