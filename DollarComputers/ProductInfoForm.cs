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
    }
}
