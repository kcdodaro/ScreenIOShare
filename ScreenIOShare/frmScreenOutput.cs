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

                    Graphics graphics = picScreenOutput.CreateGraphics();
                    graphics.CopyFromScreen(0, 0, 0, 0, s);

                    Thread.Sleep(15);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
                catch (Exception e)
                {
                    
                }     
            }
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
        }
    }
}
