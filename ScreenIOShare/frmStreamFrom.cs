﻿using System;
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
    public partial class frmStreamFrom : Form
    {
        #region globals
        double dblScreenHeight;
        double dblScreenWidth;
        double dblPort = 8080;
        string strExtIPAddress;
        string strIntIPAddress;

        Networking nt = new Networking();
        #endregion

        public frmStreamFrom()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtInfo.Enabled = true;
            txtInfo.Text += "Give this key to the receiving computer: " + createKey();
            //Form screen = new frmScreenOutput();
            //screen.Show();

            while (true)
            {
                nt.sendData(captureScreen(), nt.getExternalIPAddress(), Standards.port.ToString());
            }
        }

        private void frmStreamFrom_Load(object sender, EventArgs e)
        {
            dblScreenHeight = SystemParameters.VirtualScreenHeight;
            dblScreenWidth = SystemParameters.VirtualScreenWidth;
            strIntIPAddress = nt.getInternalIPAddress().ToString();
            strExtIPAddress = nt.getExternalIPAddress().ToString();

            lblScreenHeight.Text += dblScreenHeight;
            lblScreenWidth.Text += dblScreenWidth;
            lblIntIPAddress.Text += strIntIPAddress;
            lblExtIPAddress.Text += strExtIPAddress;
            lblPort.Text += dblPort;
        }

        string createKey()
        {
            string strKey = null;
            Random r = new Random();

            for (int i = 0; i < 250; i++)
            {
                strKey += r.Next(0, 10).ToString();
            }

            return strKey;
        }

        Graphics captureScreen()
        {
            /*Bitmap image = new Bitmap((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight);
            Size s = new Size(image.Width, image.Height);

            using (Bitmap bm = new Bitmap((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight))
            {
                using (Graphics graphics = Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, s);
                }
                return bm;
            }*/

            Bitmap image = new Bitmap((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight);
            Size s = new Size(image.Width, image.Height);

            //Graphics graphics = picScreenOutput.CreateGraphics();
            //graphics.CopyFromScreen(0, 0, 0, 0, s);
            Graphics graphics = this.CreateGraphics();
            graphics.CopyFromScreen(0, 0, 0, 0, s);

            return graphics;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gp = pic.CreateGraphics();
            gp = captureScreen();
        }
    }
}