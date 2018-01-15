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
        double dblPort = 13336;
        string strExtIPAddress;
        string strIntIPAddress;
        #endregion

        public frmStreamFrom()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form screen = new frmScreenOutput();
            screen.Show();
        }

        private void frmStreamFrom_Load(object sender, EventArgs e)
        {
            dblScreenHeight = SystemParameters.VirtualScreenHeight;
            dblScreenWidth = SystemParameters.VirtualScreenWidth;
            strIntIPAddress = getIntIPAddress();
            strExtIPAddress = getExtIPAddress();

            lblScreenHeight.Text += dblScreenHeight;
            lblScreenWidth.Text += dblScreenWidth;
            lblIntIPAddress.Text += strIntIPAddress;
            lblExtIPAddress.Text += strExtIPAddress;
            lblPort.Text += dblPort;
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

        string getExtIPAddress()
        {
            string ExtIPAddress = null;

            WebRequest WRrequest = WebRequest.Create("http://checkip.dyndns.org");
            WebResponse WRresponse = WRrequest.GetResponse();
            using (Stream st = WRresponse.GetResponseStream())
            { 
                StreamReader sr = new StreamReader(st);
                string strResponse = sr.ReadToEnd().Trim();

                List<char> response = strResponse.ToList<char>();
                
                for(int i = 0; i < response.Count(); i++)
                {
                    if (!(Char.IsDigit(response[i])) && response[i] != '.')
                    {
                        response.RemoveAt(i);
                        i = -1;
                    }
                }

                for (int i = 0; i < response.Count(); i++)
                {
                    ExtIPAddress += response[i];
                }
            }

            return ExtIPAddress;
        }
    }
}
