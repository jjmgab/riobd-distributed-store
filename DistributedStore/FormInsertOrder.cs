using DistributedStore.Models;
using System;
using System.Windows.Forms;

namespace DistributedStore
{
    public partial class FormInsertOrder : Form
    {
        public event AddOrderEventHandler OrderAdded;

        public FormInsertOrder()
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
            bool dateParsed = DateTime.TryParse(textBoxDate.Text, out DateTime date);
            bool clientIdParsed = int.TryParse(textBoxClientId.Text, out int clientId);
            bool productIdParsed = int.TryParse(textBoxProductId.Text, out int productId);
            bool quantityParsed = int.TryParse(textBoxQuantity.Text, out int quantity);
            bool storageIdParsed = int.TryParse(textBoxStorageId.Text, out int storageId);

            if (!idParsed || !dateParsed || !clientIdParsed || !productIdParsed || !quantityParsed || !storageIdParsed)
                return;

            AddOrderEventArgs args = new AddOrderEventArgs(new Order(id, date, clientId, productId, quantity, storageId));
            OrderAdded?.Invoke(this, args);
            Close();
        }
    }

    public delegate void AddOrderEventHandler(object sender, AddOrderEventArgs e);

    public class AddOrderEventArgs : EventArgs
    {
        private Order _orderData;
        public Order OrderData => _orderData;

        public AddOrderEventArgs(Order orderData)
        {
            _orderData = orderData;
        }
    }
}
