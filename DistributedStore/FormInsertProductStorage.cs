using DistributedStore.Models;
using System;
using System.Windows.Forms;

namespace DistributedStore
{
    public partial class FormInsertProductStorage : Form
    {
        public event AddProductStorageEventHandler ProductStorageAdded;

        public FormInsertProductStorage()
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
            bool productIdParsed = int.TryParse(textBoxProductId.Text, out int productId);
            string locationCode = textBoxLocationCode.Text;
            bool quantityParsed = int.TryParse(textBoxQuantity.Text, out int quantity);

            if (!idParsed || !productIdParsed || !quantityParsed || id < 0 || productId < 0 || quantity < 0 || locationCode == "")
                return;

            AddProductStorageEventArgs args = new AddProductStorageEventArgs(new ProductStorage(id, productId, locationCode, quantity));
            ProductStorageAdded?.Invoke(this, args);
            Close();
        }
    }

    public delegate void AddProductStorageEventHandler(object sender, AddProductStorageEventArgs e);

    public class AddProductStorageEventArgs : EventArgs
    {
        private ProductStorage _productStorageData;
        public ProductStorage ProductStorageData => _productStorageData;

        public AddProductStorageEventArgs(ProductStorage ProductStorageData)
        {
            _productStorageData = ProductStorageData;
        }
    }
}
