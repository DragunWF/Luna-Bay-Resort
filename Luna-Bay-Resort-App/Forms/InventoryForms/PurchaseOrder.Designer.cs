namespace Luna_Bay_Resort_App.Forms.InventoryForms
{
    partial class PurchaseOrder
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
            dgvPurchaseOrder = new DataGridView();
            selectItem = new DataGridViewCheckBoxColumn();
            itemName = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cbItemName = new ComboBox();
            cbCategory = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            submitBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            cbStatus = new ComboBox();
            confirmBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvPurchaseOrder
            // 
            dgvPurchaseOrder.AllowUserToAddRows = false;
            dgvPurchaseOrder.AllowUserToDeleteRows = false;
            dgvPurchaseOrder.AllowUserToResizeColumns = false;
            dgvPurchaseOrder.AllowUserToResizeRows = false;
            dgvPurchaseOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseOrder.Columns.AddRange(new DataGridViewColumn[] { selectItem, itemName, quantity, status });
            dgvPurchaseOrder.Location = new Point(24, 22);
            dgvPurchaseOrder.Margin = new Padding(3, 2, 3, 2);
            dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            dgvPurchaseOrder.RowHeadersWidth = 51;
            dgvPurchaseOrder.Size = new Size(646, 302);
            dgvPurchaseOrder.TabIndex = 0;
            // 
            // selectItem
            // 
            selectItem.HeaderText = "*";
            selectItem.MinimumWidth = 6;
            selectItem.Name = "selectItem";
            selectItem.Width = 80;
            // 
            // itemName
            // 
            itemName.HeaderText = "Item Name";
            itemName.MinimumWidth = 6;
            itemName.Name = "itemName";
            itemName.Width = 300;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Width = 80;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(719, 153);
            label1.Name = "label1";
            label1.Size = new Size(135, 19);
            label1.TabIndex = 1;
            label1.Text = "*Add New Order";
            // 
            // cbItemName
            // 
            cbItemName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItemName.FormattingEnabled = true;
            cbItemName.Location = new Point(816, 220);
            cbItemName.Margin = new Padding(3, 2, 3, 2);
            cbItemName.Name = "cbItemName";
            cbItemName.Size = new Size(133, 23);
            cbItemName.TabIndex = 2;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Products", "Foods" });
            cbCategory.Location = new Point(816, 189);
            cbCategory.Margin = new Padding(3, 2, 3, 2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(133, 23);
            cbCategory.TabIndex = 3;
            cbCategory.SelectedValueChanged += cbCategory_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(719, 220);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 4;
            label2.Text = "Item Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(719, 189);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 5;
            label3.Text = "Category:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(816, 254);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(133, 23);
            txtQuantity.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(719, 256);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 7;
            label4.Text = "Quantity:";
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitBtn.Location = new Point(719, 296);
            submitBtn.Margin = new Padding(3, 2, 3, 2);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(229, 27);
            submitBtn.TabIndex = 8;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(719, 22);
            label5.Name = "label5";
            label5.Size = new Size(135, 19);
            label5.TabIndex = 9;
            label5.Text = "*Change Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(719, 59);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 10;
            label6.Text = "Status:";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Failed", "Delivered" });
            cbStatus.Location = new Point(816, 57);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(133, 23);
            cbStatus.TabIndex = 11;
            // 
            // confirmBtn
            // 
            confirmBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmBtn.Location = new Point(719, 100);
            confirmBtn.Margin = new Padding(3, 2, 3, 2);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(229, 27);
            confirmBtn.TabIndex = 12;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // PurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 348);
            Controls.Add(confirmBtn);
            Controls.Add(cbStatus);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(submitBtn);
            Controls.Add(label4);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbCategory);
            Controls.Add(cbItemName);
            Controls.Add(label1);
            Controls.Add(dgvPurchaseOrder);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PurchaseOrder";
            Text = "PurchaseOrder";
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPurchaseOrder;
        private Label label1;
        private ComboBox cbItemName;
        private ComboBox cbCategory;
        private Label label2;
        private Label label3;
        private TextBox txtQuantity;
        private Label label4;
        private Button submitBtn;
        private Label label5;
        private Label label6;
        private ComboBox cbStatus;
        private Button confirmBtn;
        private DataGridViewCheckBoxColumn selectItem;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn status;
    }
}