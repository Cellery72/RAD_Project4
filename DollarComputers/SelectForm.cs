using System;
using System.Collections.Generic;
using System.Linq;
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
        public Form previousForm;
        private DatabaseContext db = new DatabaseContext();
        private product selectedProduct;
        public SelectForm()
        {
            InitializeComponent();

            this.productsTableAdapter.Fill(this.dollar_computersDataSet.products);

            List<product> ProductList = (from product in db.products
                                         select product).ToList();
            // Round 
            foreach(product p in ProductList)
            {
                Decimal x = (Decimal)p.cost;
                p.cost = Decimal.Round(x, 2);
            }
            ProductsGridView.DataSource = ProductList;
        }

        // Public 
        // ******
        public void DisplayProduct()
        {
            if (Program.selectedProduct != null)
            {
                selectedProduct = Program.selectedProduct;
                NextButton.Enabled = true;
                foreach (DataGridViewRow dg in ProductsGridView.Rows)
                {
                    product selected = (product)dg.DataBoundItem;
                    if (selected.productID == selectedProduct.productID)
                        dg.Selected = true;
                }
            }
            string outputText = selectedProduct.manufacturer + " " + selectedProduct.model + " Priced at: $" + selectedProduct.cost;
            SelectionTextBox.Text = outputText;
        }

        // Event Handlers
        // **************
        private void SelectForm_Load(object sender, System.EventArgs e)
        {

            ProductsGridView.ClearSelection();
            ProductsGridView.CellClick += new DataGridViewCellEventHandler(ProductsGridView_CellClick);
        }
        private void ProductsGridView_CellClick(object sender, EventArgs e)
        {
            if (ProductsGridView.SelectedRows.Count > 0)
            {
                var selectedRow = (sender as DataGridView).SelectedRows[0];
                product theProd = (product)selectedRow.DataBoundItem;
                Program.selectedProduct = theProd;
                DisplayProduct();
                NextButton.Enabled = true;
            }
        }
        // Buttons
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void NextButton_Click(object sender, System.EventArgs e)
        {
            ProductInfoForm info = new ProductInfoForm();
            info.previousForm = this;
            info.Show();
            this.Hide();
        }
    }
}
    