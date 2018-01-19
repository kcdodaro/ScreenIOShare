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
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ScreenIOShare
{
    class Networking
    {
        #region globals
        public bool isConnected { get; set; }
        public TcpClient client = new TcpClient();
        #endregion

        #region information grabbing
        public string getInternalIPAddress()
        {
            var hostName = Dns.GetHostEntry(Dns.GetHostName());
            string InternalIP = null;

            foreach (var ip in hostName.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    InternalIP = ip.ToString();
                    break;
                }
                else
                {
                    InternalIP = null;
                }
            }

            if (InternalIP != null)
            {
                return InternalIP;
            }
            else
            {
                throw new InternalIPNotFound();
            }
        }

        public string getExternalIPAddress()
        {
            string ExtIPAddress = null;

            WebRequest WRrequest = WebRequest.Create("http://checkip.dyndns.org");
            WebResponse WRresponse = WRrequest.GetResponse();
            using (Stream st = WRresponse.GetResponseStream())
            {
                StreamReader sr = new StreamReader(st);
                string strResponse = sr.ReadToEnd().Trim();

                List<char> response = strResponse.ToList<char>();

                for (int i = 0; i < response.Count(); i++)
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
        #endregion

        #region data maniuplation
        public void sendData(Bitmap image, string address, string port)
        {
            int intPort = 0;

            try
            {
                intPort = int.Parse(port);
            }
            catch (Exception e)
            {
                Logging lg = new Logging();
                lg.logEvent(e.ToString());
            }
 
            try
            {
                
            }
            catch (Exception e)
            {
                Logging lg = new Logging();
                lg.logEvent(e.ToString());
            }  
        }

        public Image receiveData(string address, string port)
        {
            Image receivedImage = null;

            IPAddress ip = null;
            int intPort = 0;
            try
            {
                ip = IPAddress.Parse(address);
                intPort = int.Parse(port);
            }       
            catch (Exception e)
            {
                Logging lg = new Logging();
                lg.logEvent(e.ToString());
            }

            try
            {
                
            }
            catch (Exception e)
            {
                Logging lg = new Logging();
                lg.logEvent(e.ToString());
            }

            return receivedImage;
        }
        #endregion
    }
}
