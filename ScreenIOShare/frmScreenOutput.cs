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
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace ScreenIOShare
{
    public partial class frmScreenOutput : Form
    {
        #region globals
        int intFPS = 0;
        int intFPSCounter = 0;
        #endregion

        public frmScreenOutput()
        {
            InitializeComponent();
        }

        private void frmScreenOutput_Load(object sender, EventArgs e)
        {
             
        }

        void captureScreen()
        {
            while (true)
            {
                try
                {
                    Bitmap image = new Bitmap((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight);
                    Size s = new Size(image.Width, image.Height);

                    Graphics graphics = picScreenOutput.CreateGraphics();
                    graphics.CopyFromScreen(0, 0, 0, 0, s);

                    intFPSCounter++;

                    Thread.Sleep(1);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
                catch (Exception e)
                {
                    //insert error logging here
                }     
            }
        }

        void countFPS()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += new EventHandler(updateFPS);
        }

        void updateFPS(object sender, EventArgs e)
        {
            intFPS = intFPSCounter;
            intFPSCounter = 0;
            lblFPS.Text = "FPS: " + intFPS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Size s = new Size((int)SystemParameters.VirtualScreenWidth / 2, (int)SystemParameters.VirtualScreenHeight / 2);
            picScreenOutput.Width = (int)SystemParameters.VirtualScreenWidth;
            picScreenOutput.Height = (int)SystemParameters.VirtualScreenHeight;
            //picScreenOutput.MaximumSize = s;
            //picScreenOutput.Size = s;

            Thread sc = new Thread(captureScreen);
            sc.Start();

            //Thread fps = new Thread(countFPS);
            //fps.Start();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += new EventHandler(updateFPS);
        }
    }
}
