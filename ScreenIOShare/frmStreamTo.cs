using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace ScreenIOShare
{
    public partial class frmStreamTo : Form
    {
        #region globals
        ArrayList sockets;
        string strExternalIP;
        string strInternalIP;
        string strPort;
        string strKey;
        Networking nt = new Networking();
        #endregion

        public frmStreamTo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            strExternalIP = txtExtIP.Text;
            strInternalIP = txtIntIP.Text;
            strPort = txtPort.Text;
            strKey = txtKey.Text;

            if (strExternalIP != "" && strInternalIP != "" && strPort != "" && strKey != "")
            {
                picTest.Image = nt.receiveData(strInternalIP, strPort);
            }
            else
            {
                MessageBox.Show("Not all required information was entered. Ensure that you have put information in all boxes.");
            }
        }

        private void frmStreamTo_Load(object sender, EventArgs e)
        {
            Networking nt = new Networking();

            lblScreenHeight.Text += Standards.screenHeight.ToString();
            lblScreenWidth.Text += Standards.screenWidth.ToString();
            lblPort.Text += Standards.port.ToString();
            lblExtIPAddress.Text += nt.getExternalIPAddress();
            lblIntIPAddress.Text += nt.getInternalIPAddress();
            lblIsConnected.Text += nt.isConnected.ToString();
        }
    }
}
