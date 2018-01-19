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
    class Standards
    {
        static Networking nt = new Networking();

        public int screenHeight = (int)SystemParameters.VirtualScreenHeight;
        public int screenWidth = (int)SystemParameters.VirtualScreenWidth;
        public int port = 8080;
        public static string configFolderLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "KCDev\\ScreenIOShare\\";
        public static string configFileLocation = configFolderLocation + "config.txt";
        public string logFileLocation = configFolderLocation + "log.txt";
        public string localExternalIP = nt.getExternalIPAddress();
        public string localInternalIP = nt.getInternalIPAddress();
    }
}
