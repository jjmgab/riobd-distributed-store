using DistributedStore.Models;
using System;
using System.Windows.Forms;

namespace DistributedStore
{
    public partial class FormInsertProduct : Form
    {
        public event AddProductEventHandler ProductAdded;

        public FormInsertProduct()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool idParsed = int.TryParse(textBoxId.Text, out int id);
            string name = textBoxName.Text;
            bool unitCostParsed = int.TryParse(textBoxCost.Text, out int unitCost);
            bool categoryIdParsed = int.TryParse(textBoxCategoryId.Text, out int categoryId);

            if (!idParsed || !unitCostParsed || !categoryIdParsed || categoryId < 0 || unitCost < 1 || name == "")
                return;

            AddProductEventArgs args = new AddProductEventArgs(new Product(id, name, unitCost, categoryId));
            ProductAdded?.Invoke(this, args);
            Close();
        }
    }

    public delegate void AddProductEventHandler(object sender, AddProductEventArgs e);

    public class AddProductEventArgs : EventArgs
    {
        private Product _productData;
        public Product ProductData => _productData;

        public AddProductEventArgs(Product productData)
        {
            _productData = productData;
        }
    }
}
