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
        #endregion

        public frmStreamTo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sockets = new ArrayList();
            strExternalIP = txtExtIP.Text;
            strInternalIP = txtIntIP.Text;
            strPort = txtPort.Text;
            strKey = txtKey.Text;
            bool success = false;

            if (strExternalIP != "" && strInternalIP != "" && strPort != "" && strKey != "")
            {
                Thread tlisten = new Thread(listener);
                tlisten.Start();

                /*if (success)
                {
                    Form streamedData = new frmStreamedData();
                    streamedData.Show();
                }*/
            }
            else
            {
                MessageBox.Show("Not all required information was entered. Ensure that you have put information in all boxes.");
            }
        }

        /*void listener()
        {
            try
            {
                IPAddress intIP = IPAddress.Parse(strInternalIP);
                TcpListener listen = new TcpListener(intIP, Convert.ToInt32(strPort));
                listen.Start();

                while (true)
                {
                    Socket handler = listen.AcceptSocket();
                    if (handler.Connected)
                    {
                        CheckForIllegalCrossThreadCalls = false;
                        lock (this)
                        {
                            sockets.Add(handler);
                        }
                        Thread thandler = new Thread(handle);
                        thandler.Start();
                    }
                }

            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
                //insert logging here
            }

        }

        void handle()
        {
            Random rng = new Random();
            while (true)
            {
                Socket handler = (Socket)sockets[sockets.Count - 1];
                NetworkStream ns = new NetworkStream(handler);

                int thisRead = 0;
                Byte[] dataByte = new Byte[1024];

                lock (this)
                {
                    Stream fileStream = File.OpenWrite("C://Users//kcdod//Desktop//test//" + DateTime.Now.ToString() + rng.Next(0, int.MaxValue).ToString() + ".png");
                    while (true)
                    {
                        thisRead = ns.Read(dataByte, 0, 1024);
                        fileStream.Write(dataByte, 0, thisRead);
                        if (thisRead == 0)
                        {
                            break;
                        }
                    }
                    fileStream.Close();
                }
                handler = null;
            }
        }*/

        void listener()
        {

        }

        void handle()
        {

        }
    }
}
