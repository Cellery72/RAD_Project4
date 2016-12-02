using System;
using System.Windows.Forms;

/*
 *       Author: Justin Ellery 
 *         Date: Nov 24th 2016
 *  Description: Splash Screen splashes the user with the company logo. Dollar Computers y'all.
 */
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
