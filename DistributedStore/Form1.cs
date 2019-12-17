using DistributedStore.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace DistributedStore
{
    public partial class Form1 : Form
    {
        private readonly OracleConnection _connection;

        public Form1()
        {
            InitializeComponent();
            try
            {
                string constr = "user id=system;password=tiger111;data source=oracle";

                _connection = new OracleConnection(constr);
                _connection.Open();
                MessageBox.Show($"Connected to Oracle Database {_connection.ServerVersion}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
                _connection.Dispose();
            }
        }

        private void buttonGetProducts_Click(object sender, EventArgs e)
        {
            GetAllByTableName("V_PRODUCTS");
        }

        private void buttonGetClients_Click(object sender, EventArgs e)
        {
            GetAllByTableName("V_CLIENTS");
        }

        private void buttonGetProductStorages_Click(object sender, EventArgs e)
        {
            GetAllByTableName("V_PRODUCT_STORAGE");
        }

        private void buttonGetOrders_Click(object sender, EventArgs e)
        {
            GetAllByTableName("V_ORDERS");
        }

        private DataTable Get(string query)
        {
            OracleDataAdapter oda = new OracleDataAdapter(query, _connection);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            return dt;
        }

        private void Insert(string query)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(query, _connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
            }
        }

        private void GetAllByTableName(string tableName)
        {
            try
            {
                string query = $"SELECT * FROM {tableName}";

                dataGridView.DataSource = Get(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
                _connection.Dispose();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _connection.Dispose();
        }

        private void buttonInsertClient_Click(object sender, EventArgs e)
        {
            FormInsertClient form = new FormInsertClient();
            Client newClient = null;
            form.ClientAdded += (s, ea) =>
            {
                newClient = ea.ClientData;
            };

            form.ShowDialog();

            if (newClient != null)
            {
                string query = $"INSERT INTO V_CLIENTS VALUES({newClient.Id},'{newClient.Name}','{newClient.Surname}','{newClient.Email}','{newClient.Phone}')";
                Insert(query);
                buttonGetClients_Click(null, null);
            }
        }

        private void buttonInsertProduct_Click(object sender, EventArgs e)
        {
            FormInsertProduct form = new FormInsertProduct();
            Product newProduct = null;
            form.ProductAdded += (s, ea) =>
            {
                newProduct = ea.ProductData;
            };

            form.ShowDialog();

            if (newProduct != null)
            {
                string query = $"INSERT INTO V_PRODUCTS VALUES({newProduct.Id},'{newProduct.Name}','{newProduct.UnitCost}','{newProduct.CategoryId}')";
                Insert(query);
                buttonGetProducts_Click(null, null);
            }
        }

        private void buttonInsertProductStorage_Click(object sender, EventArgs e)
        {
            FormInsertProductStorage form = new FormInsertProductStorage();
            ProductStorage newProductStorage = null;
            form.ProductStorageAdded += (s, ea) =>
            {
                newProductStorage = ea.ProductStorageData;
            };

            form.ShowDialog();

            if (newProductStorage != null)
            {
                string query = $"INSERT INTO V_PRODUCT_STORAGE VALUES({newProductStorage.Id},{newProductStorage.ProductId},'{newProductStorage.LocationCode}',{newProductStorage.Quantity})";
                Insert(query);
                buttonGetProductStorages_Click(null, null);
            }
        }

        private void buttonInsertOrder_Click(object sender, EventArgs e)
        {
            FormInsertOrder form = new FormInsertOrder();
            Order newOrder = null;
            form.OrderAdded += (s, ea) =>
            {
                newOrder = ea.OrderData;
            };

            form.ShowDialog();

            if (newOrder != null)
            {
                string query = $"INSERT INTO V_ORDERS VALUES({newOrder.Id},'{newOrder.OrderDate.ToShortDateString()}',{newOrder.ClientId},{newOrder.ProductId},{newOrder.Quantity},{newOrder.StorageId})";
                Insert(query);
                buttonGetOrders_Click(null, null);
            }
        }
    }
}
