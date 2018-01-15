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

                    //Graphics graphics = Graphics.FromImage(image);
                    Graphics graphics = picScreenOutput.CreateGraphics();
                    graphics.CopyFromScreen(0, 0, 0, 0, s);


                    //Bitmap screen = new Bitmap((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight, graphics);

                    //picScreenOutput.Image = screen;

                    Thread.Sleep(15);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
                catch
                {

                }     
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picScreenOutput.Width = (int)SystemParameters.VirtualScreenWidth / 2;
            picScreenOutput.Height = (int)SystemParameters.VirtualScreenHeight / 2;

            Thread sc = new Thread(captureScreen);
            sc.Start();
        }
    }
}
