namespace Luna_Bay_Resort_App.Forms.InventoryForms
{
    partial class EditItem
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
            Categorycb = new ComboBox();
            label1 = new Label();
            Pricetxt = new TextBox();
            ItemNamecb = new ComboBox();
            Confirmbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Categorycb
            // 
            Categorycb.DropDownStyle = ComboBoxStyle.DropDownList;
            Categorycb.Font = new Font("Consolas", 10F);
            Categorycb.FormattingEnabled = true;
            Categorycb.Items.AddRange(new object[] { "Products", "Food" });
            Categorycb.Location = new Point(107, 28);
            Categorycb.Name = "Categorycb";
            Categorycb.Size = new Size(187, 23);
            Categorycb.TabIndex = 0;
            Categorycb.SelectedValueChanged += Categorycb_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10F);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // Pricetxt
            // 
            Pricetxt.Font = new Font("Consolas", 10F);
            Pricetxt.Location = new Point(107, 128);
            Pricetxt.Name = "Pricetxt";
            Pricetxt.Size = new Size(187, 23);
            Pricetxt.TabIndex = 2;
            // 
            // ItemNamecb
            // 
            ItemNamecb.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemNamecb.Font = new Font("Consolas", 10F);
            ItemNamecb.FormattingEnabled = true;
            ItemNamecb.Location = new Point(107, 77);
            ItemNamecb.Name = "ItemNamecb";
            ItemNamecb.Size = new Size(187, 23);
            ItemNamecb.TabIndex = 3;
            ItemNamecb.SelectedValueChanged += ItemNamecb_SelectedValueChanged;
            // 
            // Confirmbtn
            // 
            Confirmbtn.BackColor = Color.DimGray;
            Confirmbtn.Font = new Font("Consolas", 10F);
            Confirmbtn.ForeColor = SystemColors.ControlLight;
            Confirmbtn.Location = new Point(197, 184);
            Confirmbtn.Name = "Confirmbtn";
            Confirmbtn.Size = new Size(97, 35);
            Confirmbtn.TabIndex = 4;
            Confirmbtn.Text = "Confrim";
            Confirmbtn.UseVisualStyleBackColor = false;
            Confirmbtn.Click += Confirmbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10F);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 5;
            label2.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10F);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // EditItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 240);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Confirmbtn);
            Controls.Add(ItemNamecb);
            Controls.Add(Pricetxt);
            Controls.Add(label1);
            Controls.Add(Categorycb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditItem";
            Text = "Edit Item Infomration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Categorycb;
        private Label label1;
        private TextBox Pricetxt;
        private ComboBox ItemNamecb;
        private Button Confirmbtn;
        private Label label2;
        private Label label3;
    }
}