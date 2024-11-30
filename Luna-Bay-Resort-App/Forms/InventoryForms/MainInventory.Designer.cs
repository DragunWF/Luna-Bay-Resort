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
            dgvInventory = new DataGridView();
            purchaseOrderBtn = new Button();
            txtSearch = new TextBox();
            searchBtn = new Button();
            addItemBtn = new Button();
            editItemBtn = new Button();
            itemName = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { itemName, price, quantity });
            dgvInventory.Location = new Point(32, 33);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(951, 468);
            dgvInventory.TabIndex = 0;
            // 
            // purchaseOrderBtn
            // 
            purchaseOrderBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            purchaseOrderBtn.Location = new Point(543, 530);
            purchaseOrderBtn.Name = "purchaseOrderBtn";
            purchaseOrderBtn.Size = new Size(157, 41);
            purchaseOrderBtn.TabIndex = 1;
            purchaseOrderBtn.Text = "Purchase Order";
            purchaseOrderBtn.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(32, 537);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(269, 537);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 27);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // addItemBtn
            // 
            addItemBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addItemBtn.Location = new Point(717, 530);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(125, 41);
            addItemBtn.TabIndex = 4;
            addItemBtn.Text = "Add Item";
            addItemBtn.UseVisualStyleBackColor = true;
            // 
            // editItemBtn
            // 
            editItemBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editItemBtn.Location = new Point(858, 530);
            editItemBtn.Name = "editItemBtn";
            editItemBtn.Size = new Size(125, 41);
            editItemBtn.TabIndex = 5;
            editItemBtn.Text = "Edit Item";
            editItemBtn.UseVisualStyleBackColor = true;
            // 
            // itemName
            // 
            itemName.HeaderText = "Item Name";
            itemName.MinimumWidth = 6;
            itemName.Name = "itemName";
            itemName.Width = 600;
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
            // MainInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 630);
            Controls.Add(editItemBtn);
            Controls.Add(addItemBtn);
            Controls.Add(searchBtn);
            Controls.Add(txtSearch);
            Controls.Add(purchaseOrderBtn);
            Controls.Add(dgvInventory);
            Name = "MainInventory";
            Text = "MainInventory";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventory;
        private Button purchaseOrderBtn;
        private TextBox txtSearch;
        private Button searchBtn;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private Button addItemBtn;
        private Button editItemBtn;
    }
}