namespace DistributedStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxInsert = new System.Windows.Forms.GroupBox();
            this.buttonInsertOrder = new System.Windows.Forms.Button();
            this.buttonInsertProductStorage = new System.Windows.Forms.Button();
            this.buttonInsertClient = new System.Windows.Forms.Button();
            this.buttonInsertProduct = new System.Windows.Forms.Button();
            this.groupBoxGet = new System.Windows.Forms.GroupBox();
            this.buttonGetOrders = new System.Windows.Forms.Button();
            this.buttonGetProductStorages = new System.Windows.Forms.Button();
            this.buttonGetClients = new System.Windows.Forms.Button();
            this.buttonGetProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxInsert.SuspendLayout();
            this.groupBoxGet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(250, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(538, 426);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxInsert);
            this.panel1.Controls.Add(this.groupBoxGet);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 426);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxInsert
            // 
            this.groupBoxInsert.Controls.Add(this.buttonInsertOrder);
            this.groupBoxInsert.Controls.Add(this.buttonInsertProductStorage);
            this.groupBoxInsert.Controls.Add(this.buttonInsertClient);
            this.groupBoxInsert.Controls.Add(this.buttonInsertProduct);
            this.groupBoxInsert.Location = new System.Drawing.Point(3, 207);
            this.groupBoxInsert.Name = "groupBoxInsert";
            this.groupBoxInsert.Size = new System.Drawing.Size(226, 216);
            this.groupBoxInsert.TabIndex = 1;
            this.groupBoxInsert.TabStop = false;
            this.groupBoxInsert.Text = "Insert";
            // 
            // buttonInsertOrder
            // 
            this.buttonInsertOrder.Location = new System.Drawing.Point(6, 106);
            this.buttonInsertOrder.Name = "buttonInsertOrder";
            this.buttonInsertOrder.Size = new System.Drawing.Size(214, 23);
            this.buttonInsertOrder.TabIndex = 7;
            this.buttonInsertOrder.Text = "Orders";
            this.buttonInsertOrder.UseVisualStyleBackColor = true;
            this.buttonInsertOrder.Click += new System.EventHandler(this.buttonInsertOrder_Click);
            // 
            // buttonInsertProductStorage
            // 
            this.buttonInsertProductStorage.Location = new System.Drawing.Point(6, 77);
            this.buttonInsertProductStorage.Name = "buttonInsertProductStorage";
            this.buttonInsertProductStorage.Size = new System.Drawing.Size(214, 23);
            this.buttonInsertProductStorage.TabIndex = 6;
            this.buttonInsertProductStorage.Text = "Product Storages";
            this.buttonInsertProductStorage.UseVisualStyleBackColor = true;
            this.buttonInsertProductStorage.Click += new System.EventHandler(this.buttonInsertProductStorage_Click);
            // 
            // buttonInsertClient
            // 
            this.buttonInsertClient.Location = new System.Drawing.Point(6, 48);
            this.buttonInsertClient.Name = "buttonInsertClient";
            this.buttonInsertClient.Size = new System.Drawing.Size(214, 23);
            this.buttonInsertClient.TabIndex = 5;
            this.buttonInsertClient.Text = "Clients";
            this.buttonInsertClient.UseVisualStyleBackColor = true;
            this.buttonInsertClient.Click += new System.EventHandler(this.buttonInsertClient_Click);
            // 
            // buttonInsertProduct
            // 
            this.buttonInsertProduct.Location = new System.Drawing.Point(6, 19);
            this.buttonInsertProduct.Name = "buttonInsertProduct";
            this.buttonInsertProduct.Size = new System.Drawing.Size(214, 23);
            this.buttonInsertProduct.TabIndex = 4;
            this.buttonInsertProduct.Text = "Products";
            this.buttonInsertProduct.UseVisualStyleBackColor = true;
            this.buttonInsertProduct.Click += new System.EventHandler(this.buttonInsertProduct_Click);
            // 
            // groupBoxGet
            // 
            this.groupBoxGet.Controls.Add(this.buttonGetOrders);
            this.groupBoxGet.Controls.Add(this.buttonGetProductStorages);
            this.groupBoxGet.Controls.Add(this.buttonGetClients);
            this.groupBoxGet.Controls.Add(this.buttonGetProducts);
            this.groupBoxGet.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGet.Name = "groupBoxGet";
            this.groupBoxGet.Size = new System.Drawing.Size(226, 198);
            this.groupBoxGet.TabIndex = 0;
            this.groupBoxGet.TabStop = false;
            this.groupBoxGet.Text = "Get";
            // 
            // buttonGetOrders
            // 
            this.buttonGetOrders.Location = new System.Drawing.Point(6, 106);
            this.buttonGetOrders.Name = "buttonGetOrders";
            this.buttonGetOrders.Size = new System.Drawing.Size(214, 23);
            this.buttonGetOrders.TabIndex = 3;
            this.buttonGetOrders.Text = "Orders";
            this.buttonGetOrders.UseVisualStyleBackColor = true;
            this.buttonGetOrders.Click += new System.EventHandler(this.buttonGetOrders_Click);
            // 
            // buttonGetProductStorages
            // 
            this.buttonGetProductStorages.Location = new System.Drawing.Point(6, 77);
            this.buttonGetProductStorages.Name = "buttonGetProductStorages";
            this.buttonGetProductStorages.Size = new System.Drawing.Size(214, 23);
            this.buttonGetProductStorages.TabIndex = 2;
            this.buttonGetProductStorages.Text = "Product Storages";
            this.buttonGetProductStorages.UseVisualStyleBackColor = true;
            this.buttonGetProductStorages.Click += new System.EventHandler(this.buttonGetProductStorages_Click);
            // 
            // buttonGetClients
            // 
            this.buttonGetClients.Location = new System.Drawing.Point(6, 48);
            this.buttonGetClients.Name = "buttonGetClients";
            this.buttonGetClients.Size = new System.Drawing.Size(214, 23);
            this.buttonGetClients.TabIndex = 1;
            this.buttonGetClients.Text = "Clients";
            this.buttonGetClients.UseVisualStyleBackColor = true;
            this.buttonGetClients.Click += new System.EventHandler(this.buttonGetClients_Click);
            // 
            // buttonGetProducts
            // 
            this.buttonGetProducts.Location = new System.Drawing.Point(6, 19);
            this.buttonGetProducts.Name = "buttonGetProducts";
            this.buttonGetProducts.Size = new System.Drawing.Size(214, 23);
            this.buttonGetProducts.TabIndex = 0;
            this.buttonGetProducts.Text = "Products";
            this.buttonGetProducts.UseVisualStyleBackColor = true;
            this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "DistributedStore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxInsert.ResumeLayout(false);
            this.groupBoxGet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.GroupBox groupBoxGet;
        private System.Windows.Forms.Button buttonGetOrders;
        private System.Windows.Forms.Button buttonGetProductStorages;
        private System.Windows.Forms.Button buttonGetClients;
        private System.Windows.Forms.Button buttonGetProducts;
        private System.Windows.Forms.Button buttonInsertOrder;
        private System.Windows.Forms.Button buttonInsertProductStorage;
        private System.Windows.Forms.Button buttonInsertClient;
        private System.Windows.Forms.Button buttonInsertProduct;
    }
}

