using System;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SplashScreen : Form
    {
        public bool isClosed = false;

        public SplashScreen()
        {
            InitializeComponent();
            this.SplashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            Timer tim = sender as Timer;
            tim.Stop();
            StartForm startForm = new StartForm();
            isClosed = true;
            startForm.previousForm = this;
            startForm.Show();
            this.Hide();
        }
    }
}
