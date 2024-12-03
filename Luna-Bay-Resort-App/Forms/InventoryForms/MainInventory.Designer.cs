namespace Luna_Bay_Resort_App.Forms.InventoryForms
{
    partial class MainInventory
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
            inventoryDataGrid = new DataGridView();
            itemName = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            PurchaseOrderBtn = new Button();
            txtSearch = new TextBox();
            SearchBtn = new Button();
            AddItemBtn = new Button();
            EditItemBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // inventoryDataGrid
            // 
            inventoryDataGrid.AllowUserToAddRows = false;
            inventoryDataGrid.AllowUserToDeleteRows = false;
            inventoryDataGrid.AllowUserToResizeColumns = false;
            inventoryDataGrid.AllowUserToResizeRows = false;
            inventoryDataGrid.Columns.AddRange(new DataGridViewColumn[] { itemName, price, quantity });
            inventoryDataGrid.Location = new Point(28, 25);
            inventoryDataGrid.Margin = new Padding(3, 2, 3, 2);
            inventoryDataGrid.Name = "inventoryDataGrid";
            inventoryDataGrid.RowHeadersWidth = 51;
            inventoryDataGrid.Size = new Size(832, 351);
            inventoryDataGrid.TabIndex = 0;
            // 
            // itemName
            // 
            itemName.HeaderText = "Item Name";
            itemName.MinimumWidth = 6;
            itemName.Name = "itemName";
            itemName.Width = 482;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 173;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Width = 125;
            // 
            // PurchaseOrderBtn
            // 
            PurchaseOrderBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PurchaseOrderBtn.Location = new Point(475, 398);
            PurchaseOrderBtn.Margin = new Padding(3, 2, 3, 2);
            PurchaseOrderBtn.Name = "PurchaseOrderBtn";
            PurchaseOrderBtn.Size = new Size(137, 31);
            PurchaseOrderBtn.TabIndex = 1;
            PurchaseOrderBtn.Text = "Purchase Order";
            PurchaseOrderBtn.UseVisualStyleBackColor = true;
            PurchaseOrderBtn.Click += PurchaseOrderBtn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(28, 403);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 23);
            txtSearch.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(235, 403);
            SearchBtn.Margin = new Padding(3, 2, 3, 2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(82, 26);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // AddItemBtn
            // 
            AddItemBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddItemBtn.Location = new Point(627, 398);
            AddItemBtn.Margin = new Padding(3, 2, 3, 2);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(109, 31);
            AddItemBtn.TabIndex = 4;
            AddItemBtn.Text = "Add Item";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // EditItemBtn
            // 
            EditItemBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditItemBtn.Location = new Point(751, 398);
            EditItemBtn.Margin = new Padding(3, 2, 3, 2);
            EditItemBtn.Name = "EditItemBtn";
            EditItemBtn.Size = new Size(109, 31);
            EditItemBtn.TabIndex = 5;
            EditItemBtn.Text = "Edit Item";
            EditItemBtn.UseVisualStyleBackColor = true;
            EditItemBtn.Click += EditItemBtn_Click;
            // 
            // MainInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 472);
            Controls.Add(EditItemBtn);
            Controls.Add(AddItemBtn);
            Controls.Add(SearchBtn);
            Controls.Add(txtSearch);
            Controls.Add(PurchaseOrderBtn);
            Controls.Add(inventoryDataGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainInventory";
            Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)inventoryDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView inventoryDataGrid;
        private Button PurchaseOrderBtn;
        private TextBox txtSearch;
        private Button SearchBtn;
        private Button AddItemBtn;
        private Button EditItemBtn;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
    }
}