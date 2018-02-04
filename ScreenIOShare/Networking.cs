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
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPAddress ip = IPAddress.Parse(address);
                byte[] buffer = imageToBytes(image);
                IPEndPoint endPoint = new IPEndPoint(ip, intPort);
                sock.SendTo(buffer, endPoint);
            }
            catch (Exception e)
            {
                Logging lg = new Logging();
                lg.logEvent(e.ToString());
            }  
        }

        public void sendData(Graphics image, string address, string port)
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
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPAddress ip = IPAddress.Parse(address);
                byte[] buffer = graphicsToBytes(image);
                IPEndPoint endPoint = new IPEndPoint(ip, intPort);
                sock.SendTo(buffer, endPoint);
            }
            catch (Exception e)
            {
                Logging lg = new Logging();
                lg.logEvent(e.ToString());
            }
        }

        public Bitmap receiveData(string address, string port)
        {
            Bitmap receivedImage = null;
            IPAddress ip = null;
            int intPort = 0;
            bool done = false;
            UdpClient listener = new UdpClient(intPort);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, intPort);

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
                while (!done)
                {
                    byte[] returnedData = listener.Receive(ref endPoint);
                    return bytesToBitmap(returnedData);
                }
            }
            catch (Exception e)
            {
                Logging lg = new Logging();
                lg.logEvent(e.ToString());
            }
            finally
            {
                listener.Close();
            }

            return receivedImage;
        }

        public Graphics receieveData(string address, string port)
        {
            Graphics receivedImage = null;
            IPAddress ip = null;
            int intPort = 0;
            bool done = false;
            UdpClient listener = new UdpClient(intPort);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, intPort);

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
                while (!done)
                {
                    byte[] returnedData = listener.Receive(ref endPoint);
                    return bytesToGraphics(returnedData);
                }
            }
            catch (Exception e)
            {
                Logging lg = new Logging();
                lg.logEvent(e.ToString());
            }
            finally
            {
                listener.Close();
            }

            return receivedImage;
        }

        public byte[] imageToBytes(Bitmap img)
        {
            byte[] buffer;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Bmp);
                buffer = ms.ToArray();
            }
            return buffer;
        }

        public Bitmap bytesToBitmap(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer))
            {
                return (Bitmap)Image.FromStream(ms);
            }
        }

        public Graphics bytesToGraphics(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer))
            {
                return Graphics.FromImage(Image.FromStream(ms));
            }
        }

        public byte[] graphicsToBytes(Graphics img)
        {
            /*byte[] buffer;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Bmp);
                buffer = ms.ToArray();
            }
            return buffer;*/
            ImageConverter ic = new ImageConverter();
            byte[] buffer = (byte[])ic.ConvertTo(img, typeof(byte[]));
            return buffer;
        }
        #endregion
    }
}
