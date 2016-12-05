using System.IO;
using System.Windows.Forms;

/*
 *       Author: Justin Ellery 
 *         Date: Nov 24th 2016
 *  Description: Product Info Form displays information about the order 
 */
namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {

        public Form previousForm;
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        // Public Functions
        // ****************
        public void OpenFile()
        {
            int size;

            DialogResult result = PreviousOrderOpenFileDialog.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                string file = PreviousOrderOpenFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
        }
        public void SaveFile()
        {
            int size;
            DialogResult result = SaveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = SaveFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
        }
        public void DisplayProd()
        {
            DisplayProduct(Program.selectedProduct);
        }
        // Private functions
        // *****************
        private void DisplayProduct(product p)
        {
            if (p != null)
            {
                ProductIDTextBox.Text = p.productID.ToString();
                ConditionTextBox.Text = p.condition;
                CostTextBox.Text = "$" + p.cost.ToString();


                // Product Info
                PlatformTextBox.Text = p.platform;
                OSTextBox.Text = p.OS;
                ManufacturerTextBox.Text = p.manufacturer;
                ModelTextBox.Text = p.model;


                // Tech Specs
                MemoryTextBox.Text = p.RAM_size;
                LCDSizeTextBox.Text = p.screensize;
                HDDTextBox.Text = p.HDD_size;

                CPUBrandTextBox.Text = p.CPU_brand;
                CPUNumberTexBox.Text = p.CPU_number;
                GPUTypeTextBox.Text = p.GPU_Type;

                CPUTypeTextBox.Text = p.CPU_type;
                CPUSpeedTextBox.Text = p.CPU_speed;
                WebcamTextBox.Text = p.webcam;
                NextButton.Enabled = true;
            }
            else
            {
                ProductIDTextBox.Clear();
                ConditionTextBox.Clear();
                CostTextBox.Clear();


                // Product Info
                PlatformTextBox.Clear();
                OSTextBox.Clear();
                ManufacturerTextBox.Clear();


                // Tech Specs
                MemoryTextBox.Clear();
                LCDSizeTextBox.Clear();
                HDDTextBox.Clear();

                CPUBrandTextBox.Clear();
                CPUNumberTexBox.Clear();
                GPUTypeTextBox.Clear();

                CPUTypeTextBox.Clear();
                CPUSpeedTextBox.Clear();
                WebcamTextBox.Clear();
                NextButton.Enabled = false;
            }

        }

        // Event Handlers
        // **************          
        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFile();
        }
        private void AnotherProductButton_Click(object sender, System.EventArgs e)
        {
            SelectForm form = new SelectForm();
            form.Show();
            form.previousForm = this;
            form.DisplayProduct();
            this.Hide();
        }
        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFile();
        }
        private void ProductInfoForm_Load(object sender, System.EventArgs e)
        {
            DisplayProduct(Program.selectedProduct);
        }        
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void NextButton_Click(object sender, System.EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.previousForm = this;
            order.Show();
            this.Hide();
        }
    }
}
