using System;
using System.Drawing;
using System.Windows.Forms;

/*
 *       Author: Justin Ellery 
 *         Date: Nov 24th 2016
 *  Description: Order form summarizes the user's order
 */
namespace DollarComputers
{
    public partial class OrderForm : Form
    {
        public Form previousForm;
        public OrderForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void LoadProduct()
        {
            if (Program.selectedProduct != null)
            {
                var p = Program.selectedProduct;
                ConditionTextBox.Text = p.condition;
                PlatformTextBox.Text = p.platform;
                ManufacturerTextBox.Text = p.manufacturer;
                ModelTextBox.Text = p.model;
                LCDSizeTextBox.Text = p.screensize;
                MemoryTextBox.Text = p.RAM_size;
                CPUBrandTextBox.Text = p.CPU_brand;
                CPUTypeTextBox.Text = p.CPU_type;
                CPUNumberTextBox.Text = p.CPU_number;
                CPUSpeedTextBox.Text = p.CPU_speed;
                HDDTextBox.Text = p.HDD_size;
                GPUTypeTextBox.Text = p.GPU_Type;
                WebcamTextBox.Text = p.webcam;
                OSTextBox.Text = p.OS;
                DisplayPicture(p.manufacturer);
                CalculateCost(p);            
            }
        }
        private void DisplayPicture(string manufacturer)
        {
            switch(manufacturer)
            {
                case "Asus ":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("asus");
                    break;
                case "Acer":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("acer");
                    break;
                case "Toshiba ":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("toshiba");
                    break;
                case "Apple":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("appple2");
                    break;
                case "iBUYPOWER":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("ibuypower");
                    break;
                case "Gateway ":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("gateway");
                    break;
                case "CybertronPC":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("cybertronpc");
                    break;
                case "Lenovo ":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("lenovo");
                    break;
                case "HP ":
                    LogoPictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("hp");
                    break;
            }
        }
        private void CalculateCost(product p)
        {
            var tax = (double)p.cost*0.13;
            var total = (double)p.cost * 1.13;
            PriceTextBox.Text = "$" + p.cost.ToString();
            SalesTaxTextBox.Text = "$" + Math.Round(tax,2);
            TotalTextBox.Text = "$" + Math.Round(total,2);

        }

        // Event Handlers
        // ***************
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void backToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ProductInfoForm info = new ProductInfoForm();
            info.Show();
            info.DisplayProd();
            this.Hide();
        }
        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string text = "Dollars Computers" + "\nProduced by Justin Ellery\n" + "https://notapple.com\n" + "Tel: +1 705 527 1111";  
            MessageBox.Show(text,"About Dollar Computers");
        }
        private void printToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Your order has been sent to the printer.", "Order Printed!");
        }
        private void FinishButton_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thank you for your order!\n" + "\nYour order will be processed in 7-10 business days","Thank you for shopping at Dollar Computers", MessageBoxButtons.OK);

            if (dr == DialogResult.OK)
                Application.Exit();
        }
         
    }
}
