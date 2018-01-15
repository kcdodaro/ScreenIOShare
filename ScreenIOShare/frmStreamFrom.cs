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
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ScreenIOShare
{
    public partial class frmStreamFrom : Form
    {
        #region globals
        double dblScreenHeight;
        double dblScreenWidth;
        double dblPort;
        string strExtIPAddress;
        string strIntIPAddress;
        #endregion

        public frmStreamFrom()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void frmStreamFrom_Load(object sender, EventArgs e)
        {
            dblScreenHeight = SystemParameters.VirtualScreenHeight;
            dblScreenWidth = SystemParameters.VirtualScreenWidth;
            strIntIPAddress = getIntIPAddress();

            lblScreenHeight.Text += dblScreenHeight;
            lblScreenWidth.Text += dblScreenWidth;
            lblIntIPAddress.Text += strIntIPAddress;
        }

        string getIntIPAddress()
        {
            string strIP = null;

            var HostName = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in HostName.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    strIP = ip.ToString();
                    break;
                }
                else
                {
                    strIP = "Error";
                }
            }

            if (strIP != "Error")
            {
                return strIP;
            }
            else
            {
                System.Windows.MessageBox.Show("No internal IP addresses found. Are you connected to the internet?");
                return null;
            }
        }
    }
}
