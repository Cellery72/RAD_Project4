using System.Windows.Forms;

namespace DollarComputers
{
    public partial class StartForm : Form
    {
        public SplashScreen previousForm;

        public StartForm()
        {
            InitializeComponent();
        }





        // EVENT HANDLERS
        // --------------
        private void ButtonExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonSavedOrder_Click(object sender, System.EventArgs e)
        {

        }
        private void ButtonNewOrder_Click(object sender, System.EventArgs e)
        {

        }
    }
}
