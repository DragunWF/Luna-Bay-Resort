namespace SubForms
{
    partial class AmenitiesReceipt
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
            TotalText = new Label();
            VATText = new Label();
            SubTotalText = new Label();
            DateTimeText = new Label();
            ReceiptNoText = new Label();
            label = new Label();
            label12 = new Label();
            label11 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ItemsLV = new ListView();
            ItemName = new ColumnHeader();
            Quantity = new ColumnHeader();
            Price = new ColumnHeader();
            SuspendLayout();
            // 
            // TotalText
            // 
            TotalText.AutoSize = true;
            TotalText.Font = new Font("Consolas", 13F, FontStyle.Bold);
            TotalText.Location = new Point(324, 453);
            TotalText.Name = "TotalText";
            TotalText.Size = new Size(70, 22);
            TotalText.TabIndex = 107;
            TotalText.Text = "Amount";
            // 
            // VATText
            // 
            VATText.AutoSize = true;
            VATText.Font = new Font("Consolas", 8.5F);
            VATText.Location = new Point(121, 459);
            VATText.Name = "VATText";
            VATText.Size = new Size(49, 14);
            VATText.TabIndex = 106;
            VATText.Text = "Amount";
            // 
            // SubTotalText
            // 
            SubTotalText.AutoSize = true;
            SubTotalText.Font = new Font("Consolas", 8.5F);
            SubTotalText.Location = new Point(121, 436);
            SubTotalText.Name = "SubTotalText";
            SubTotalText.Size = new Size(49, 14);
            SubTotalText.TabIndex = 105;
            SubTotalText.Text = "Amount";
            // 
            // DateTimeText
            // 
            DateTimeText.AutoSize = true;
            DateTimeText.Font = new Font("Consolas", 10F);
            DateTimeText.Location = new Point(191, 90);
            DateTimeText.Name = "DateTimeText";
            DateTimeText.Size = new Size(96, 17);
            DateTimeText.TabIndex = 99;
            DateTimeText.Text = "Date && Time";
            // 
            // ReceiptNoText
            // 
            ReceiptNoText.AutoSize = true;
            ReceiptNoText.Font = new Font("Consolas", 10F);
            ReceiptNoText.Location = new Point(191, 73);
            ReceiptNoText.Name = "ReceiptNoText";
            ReceiptNoText.Size = new Size(88, 17);
            ReceiptNoText.TabIndex = 98;
            ReceiptNoText.Text = "Receipt No";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Consolas", 13F, FontStyle.Bold);
            label.Location = new Point(248, 453);
            label.Name = "label";
            label.Size = new Size(70, 22);
            label.TabIndex = 96;
            label.Text = "Total:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 8.5F);
            label12.Location = new Point(38, 459);
            label12.Name = "label12";
            label12.Size = new Size(35, 14);
            label12.TabIndex = 95;
            label12.Text = "VAT:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 8.5F);
            label11.Location = new Point(38, 436);
            label11.Name = "label11";
            label11.Size = new Size(77, 14);
            label11.TabIndex = 94;
            label11.Text = "Sub Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 10F);
            label4.Location = new Point(38, 90);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 87;
            label4.Text = "Date && Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10F);
            label3.Location = new Point(38, 73);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 86;
            label3.Text = "Receipt No.:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 21);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 84;
            label1.Text = "Luna Bay Resort";
            // 
            // ItemsLV
            // 
            ItemsLV.BorderStyle = BorderStyle.None;
            ItemsLV.Columns.AddRange(new ColumnHeader[] { ItemName, Quantity, Price });
            ItemsLV.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemsLV.Location = new Point(38, 121);
            ItemsLV.Name = "ItemsLV";
            ItemsLV.Size = new Size(401, 302);
            ItemsLV.TabIndex = 110;
            ItemsLV.UseCompatibleStateImageBehavior = false;
            ItemsLV.View = View.Details;
            // 
            // ItemName
            // 
            ItemName.Text = "Item Name:";
            ItemName.Width = 200;
            // 
            // Quantity
            // 
            Quantity.Text = "Qty:";
            Quantity.Width = 100;
            // 
            // Price
            // 
            Price.Text = "Price:";
            Price.Width = 100;
            // 
            // AmenitiesReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 511);
            Controls.Add(ItemsLV);
            Controls.Add(TotalText);
            Controls.Add(VATText);
            Controls.Add(SubTotalText);
            Controls.Add(DateTimeText);
            Controls.Add(ReceiptNoText);
            Controls.Add(label);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AmenitiesReceipt";
            Text = "AmenitiesReceipt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TotalText;
        private Label VATText;
        private Label SubTotalText;
        private Label DateTimeText;
        private Label ReceiptNoText;
        private Label label;
        private Label label12;
        private Label label11;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private ListView ItemsLV;
        private ColumnHeader ItemName;
        private ColumnHeader Quantity;
        private ColumnHeader Price;
    }
}