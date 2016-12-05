using System.Drawing;
using System.Windows.Forms;

/*
 *       Author: Justin Ellery 
 *         Date: Nov 24th 2016
 *  Description: Start Form offers selection to open a previous order or create a new one
 */
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
            ProductInfoForm infoForm = new ProductInfoForm();
            infoForm.previousForm = this;
            infoForm.Show();
            infoForm.OpenFile();
            this.Hide();
        }
        private void ButtonNewOrder_Click(object sender, System.EventArgs e)
        {   
            // Switch forms
            SelectForm selectForm = new SelectForm();
            selectForm.previousForm = this;
            selectForm.Show();
            this.Hide();
        }
    }
}
