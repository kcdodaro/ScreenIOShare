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
    static class Standards
    {
        static Networking nt = new Networking();

        public static int screenHeight = (int)SystemParameters.VirtualScreenHeight;
        public static int screenWidth = (int)SystemParameters.VirtualScreenWidth;
        public static int port = 8080;
        public static string configFolderLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "KCDev\\ScreenIOShare\\";
        public static string configFileLocation = configFolderLocation + "config.txt";
        public static string logFileLocation = configFolderLocation + "log.txt";
        public static string localExternalIP = nt.getExternalIPAddress();
        public static string localInternalIP = nt.getInternalIPAddress();
    }
}
