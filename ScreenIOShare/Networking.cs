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

namespace ScreenIOShare
{
    class Networking
    {
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

        void sendData(Bitmap image)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Png);

                byte[] buffer = new byte[ms.Length];
                ms.Read(buffer, 0, (int)ms.Length);
            }
            catch (Exception e)
            {
                //insert logging here
            }
        }

        public void clientConnect(string Address, string port)
        {
            double ip = 0;
            int intPort = 0;

            try
            {
                intPort = int.Parse(port);
            }
            catch (Exception e)
            {
                //logging here
            }

            //bool isNumeric = double.TryParse(Address, out ip);

            /*if (isNumeric)
            {
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse(Address), intPort);
            }*/

            try
            {
                TcpClient client = new TcpClient();
                client.Connect(Address, intPort);
                //insert logging here of connection event
            }
            catch
            {

            }
            
        }

        void handleData()
        {

        }
    }
}
