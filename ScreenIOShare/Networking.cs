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
        string getInternalIPAddress()
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
                    throw new InternalIPNotFound();
                }
            }

            return InternalIP;
        }
    }
}
