using System.Windows.Forms;

/*
 *       Author: Justin Ellery 
 *         Date: Nov 24th 2016
 *  Description: Select Form allows the user to make a choice from the options in the grid.
 *  
 */
namespace DollarComputers
{
    public partial class SelectForm : Form
    {

        public StartForm previousForm;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void ProductsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = (DataGridView)sender;
        }
    }
}
