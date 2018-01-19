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

namespace ScreenIOShare
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void btnStreamFrom_Click(object sender, EventArgs e)
        {
            /*Thread th = new Thread(startStreamFrom);
            th.Start();*/

            Form streamFrom = new frmStreamFrom();
            streamFrom.Show();
            this.Hide();
        }

        private void btnStreamTo_Click(object sender, EventArgs e)
        {
            /*Thread th = new Thread(startStreamTo);
            th.Start();*/

            Form streamTo = new frmStreamTo();
            streamTo.Show();
            this.Hide();
        }

        void startStreamTo()
        {
            Form streamTo = new frmStreamTo();
            streamTo.Show();
            this.Hide();
        }

        void startStreamFrom()
        {
            Form streamFrom = new frmStreamFrom();
            streamFrom.Show();
            this.Hide();
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            createConfig();
        }

        void createConfig()
        {
            Logging lg = new Logging();

            lg.checkDirectory(Standards.configFolderLocation, true);
        }
    }
}
