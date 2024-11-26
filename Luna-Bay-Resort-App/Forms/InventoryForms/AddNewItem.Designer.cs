namespace Luna_Bay_Resort_App.Forms.InventoryForms
{
    partial class AddNewItem
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
            CategoryCB = new ComboBox();
            ItemNametxt = new TextBox();
            Pricetxt = new TextBox();
            Stocktxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddItembtn = new Button();
            FoodCategorylbl = new Label();
            FoodCategoryCB = new ComboBox();
            Servinglbl = new Label();
            Servingtxt = new TextBox();
            SuspendLayout();
            // 
            // CategoryCB
            // 
            CategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryCB.Font = new Font("Consolas", 9F);
            CategoryCB.FormattingEnabled = true;
            CategoryCB.Items.AddRange(new object[] { "Food", "Product" });
            CategoryCB.Location = new Point(151, 19);
            CategoryCB.Name = "CategoryCB";
            CategoryCB.Size = new Size(163, 22);
            CategoryCB.TabIndex = 0;
            CategoryCB.SelectedValueChanged += CategoryCB_SelectedValueChanged;
            // 
            // ItemNametxt
            // 
            ItemNametxt.Font = new Font("Consolas", 9F);
            ItemNametxt.Location = new Point(151, 48);
            ItemNametxt.Name = "ItemNametxt";
            ItemNametxt.Size = new Size(163, 22);
            ItemNametxt.TabIndex = 1;
            // 
            // Pricetxt
            // 
            Pricetxt.Font = new Font("Consolas", 9F);
            Pricetxt.Location = new Point(151, 77);
            Pricetxt.Name = "Pricetxt";
            Pricetxt.Size = new Size(163, 22);
            Pricetxt.TabIndex = 2;
            // 
            // Stocktxt
            // 
            Stocktxt.Font = new Font("Consolas", 9F);
            Stocktxt.Location = new Point(151, 106);
            Stocktxt.Name = "Stocktxt";
            Stocktxt.Size = new Size(163, 22);
            Stocktxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 4;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 5;
            label2.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 7;
            label4.Text = "Stock";
            // 
            // AddItembtn
            // 
            AddItembtn.BackColor = Color.Teal;
            AddItembtn.Font = new Font("Consolas", 10F);
            AddItembtn.ForeColor = SystemColors.Control;
            AddItembtn.Location = new Point(213, 216);
            AddItembtn.Name = "AddItembtn";
            AddItembtn.Size = new Size(101, 36);
            AddItembtn.TabIndex = 8;
            AddItembtn.Text = "Add Item";
            AddItembtn.UseVisualStyleBackColor = false;
            AddItembtn.Click += AddItembtn_Click;
            // 
            // FoodCategorylbl
            // 
            FoodCategorylbl.AutoSize = true;
            FoodCategorylbl.Font = new Font("Consolas", 12F);
            FoodCategorylbl.Location = new Point(12, 134);
            FoodCategorylbl.Name = "FoodCategorylbl";
            FoodCategorylbl.Size = new Size(126, 19);
            FoodCategorylbl.TabIndex = 10;
            FoodCategorylbl.Text = "Food Category";
            // 
            // FoodCategoryCB
            // 
            FoodCategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            FoodCategoryCB.Font = new Font("Consolas", 9F);
            FoodCategoryCB.FormattingEnabled = true;
            FoodCategoryCB.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner", "Rice Addons", "Snacks And Desserts", "Beverages" });
            FoodCategoryCB.Location = new Point(151, 135);
            FoodCategoryCB.Name = "FoodCategoryCB";
            FoodCategoryCB.Size = new Size(163, 22);
            FoodCategoryCB.TabIndex = 11;
            FoodCategoryCB.SelectedValueChanged += FoodCategoryCB_SelectedValueChanged;
            // 
            // Servinglbl
            // 
            Servinglbl.AutoSize = true;
            Servinglbl.Font = new Font("Consolas", 12F);
            Servinglbl.Location = new Point(12, 163);
            Servinglbl.Name = "Servinglbl";
            Servinglbl.Size = new Size(72, 19);
            Servinglbl.TabIndex = 12;
            Servinglbl.Text = "Serving";
            // 
            // Servingtxt
            // 
            Servingtxt.Font = new Font("Consolas", 9F);
            Servingtxt.Location = new Point(151, 164);
            Servingtxt.Name = "Servingtxt";
            Servingtxt.Size = new Size(163, 22);
            Servingtxt.TabIndex = 13;
            // 
            // AddNewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 268);
            Controls.Add(Servingtxt);
            Controls.Add(Servinglbl);
            Controls.Add(FoodCategoryCB);
            Controls.Add(FoodCategorylbl);
            Controls.Add(AddItembtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Stocktxt);
            Controls.Add(Pricetxt);
            Controls.Add(ItemNametxt);
            Controls.Add(CategoryCB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddNewItem";
            Text = "Add new item to inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryCB;
        private TextBox ItemNametxt;
        private TextBox Pricetxt;
        private TextBox Stocktxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddItembtn;
        private Label FoodCategorylbl;
        private ComboBox FoodCategoryCB;
        private Label Servinglbl;
        private TextBox Servingtxt;
    }
}