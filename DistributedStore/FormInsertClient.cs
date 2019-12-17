using DistributedStore.Models;
using System;
using System.Windows.Forms;

namespace DistributedStore
{
    public partial class FormInsertClient : Form
    {
        public event AddClientEventHandler ClientAdded;

        public FormInsertClient()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool idParsed = int.TryParse(textBoxId.Text, out int id);
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            if (!idParsed || name == "" || surname == "" || email == "" || phone == "")
                return;

            AddClientEventArgs args = new AddClientEventArgs(new Client(id, name, surname, email, phone));
            ClientAdded?.Invoke(this, args);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public delegate void AddClientEventHandler(object sender, AddClientEventArgs e);

    public class AddClientEventArgs : EventArgs
    {
        private Client _clientData;
        public Client ClientData => _clientData;

        public AddClientEventArgs(Client clientData)
        {
            _clientData = clientData;
        }
    }
}
