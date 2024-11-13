namespace Luna_Bay_Resort_App.Forms
{
    partial class GetFoodsTest
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
            ListViewItem listViewItem1 = new ListViewItem("test");
            listView1 = new ListView();
            FoodName = new ColumnHeader();
            Price = new ColumnHeader();
            Breakfastbtn = new Button();
            LunchBtn = new Button();
            Dinnerbtn = new Button();
            Beveragesbtn = new Button();
            Snacksbtn = new Button();
            FoodSearchtxt = new TextBox();
            foodSearchbtn = new Button();
            RiceAddonsbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { FoodName, Price });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(102, 97);
            listView1.Name = "listView1";
            listView1.Size = new Size(418, 276);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // FoodName
            // 
            FoodName.Text = "FoodName";
            FoodName.Width = 300;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 100;
            // 
            // Breakfastbtn
            // 
            Breakfastbtn.Location = new Point(72, 393);
            Breakfastbtn.Name = "Breakfastbtn";
            Breakfastbtn.Size = new Size(75, 23);
            Breakfastbtn.TabIndex = 1;
            Breakfastbtn.Text = "Breakfast";
            Breakfastbtn.UseVisualStyleBackColor = true;
            Breakfastbtn.Click += Breakfastbtn_Click;
            // 
            // LunchBtn
            // 
            LunchBtn.Location = new Point(153, 393);
            LunchBtn.Name = "LunchBtn";
            LunchBtn.Size = new Size(75, 23);
            LunchBtn.TabIndex = 2;
            LunchBtn.Text = "Lunch";
            LunchBtn.UseVisualStyleBackColor = true;
            LunchBtn.Click += LunchBtn_Click;
            // 
            // Dinnerbtn
            // 
            Dinnerbtn.Location = new Point(234, 393);
            Dinnerbtn.Name = "Dinnerbtn";
            Dinnerbtn.Size = new Size(75, 23);
            Dinnerbtn.TabIndex = 3;
            Dinnerbtn.Text = "Dinner";
            Dinnerbtn.UseVisualStyleBackColor = true;
            Dinnerbtn.Click += Dinnerbtn_Click;
            // 
            // Beveragesbtn
            // 
            Beveragesbtn.Location = new Point(315, 393);
            Beveragesbtn.Name = "Beveragesbtn";
            Beveragesbtn.Size = new Size(75, 23);
            Beveragesbtn.TabIndex = 4;
            Beveragesbtn.Text = "Beverages";
            Beveragesbtn.UseVisualStyleBackColor = true;
            Beveragesbtn.Click += Beveragesbtn_Click;
            // 
            // Snacksbtn
            // 
            Snacksbtn.Location = new Point(396, 393);
            Snacksbtn.Name = "Snacksbtn";
            Snacksbtn.Size = new Size(75, 23);
            Snacksbtn.TabIndex = 5;
            Snacksbtn.Text = "Snacks";
            Snacksbtn.UseVisualStyleBackColor = true;
            Snacksbtn.Click += Snacksbtn_Click;
            // 
            // FoodSearchtxt
            // 
            FoodSearchtxt.Location = new Point(72, 431);
            FoodSearchtxt.Name = "FoodSearchtxt";
            FoodSearchtxt.Size = new Size(227, 23);
            FoodSearchtxt.TabIndex = 6;
            // 
            // foodSearchbtn
            // 
            foodSearchbtn.Location = new Point(305, 431);
            foodSearchbtn.Name = "foodSearchbtn";
            foodSearchbtn.Size = new Size(75, 23);
            foodSearchbtn.TabIndex = 7;
            foodSearchbtn.Text = "Snacks";
            foodSearchbtn.UseVisualStyleBackColor = true;
            foodSearchbtn.Click += foodSearchbtn_Click;
            // 
            // RiceAddonsbtn
            // 
            RiceAddonsbtn.Location = new Point(477, 393);
            RiceAddonsbtn.Name = "RiceAddonsbtn";
            RiceAddonsbtn.Size = new Size(75, 23);
            RiceAddonsbtn.TabIndex = 8;
            RiceAddonsbtn.Text = "RiceAddons";
            RiceAddonsbtn.UseVisualStyleBackColor = true;
            RiceAddonsbtn.Click += RiceAddonsbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 9;
            label1.Text = "Menu List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(566, 15);
            label2.TabIndex = 10;
            label2.Text = "This is a implementation concept for the searching and displaying of food menus in the Amenities Section";
            // 
            // GetFoodsTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 495);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RiceAddonsbtn);
            Controls.Add(foodSearchbtn);
            Controls.Add(FoodSearchtxt);
            Controls.Add(Snacksbtn);
            Controls.Add(Beveragesbtn);
            Controls.Add(Dinnerbtn);
            Controls.Add(LunchBtn);
            Controls.Add(Breakfastbtn);
            Controls.Add(listView1);
            Name = "GetFoodsTest";
            Text = "GetFoodsTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button Breakfastbtn;
        private ColumnHeader FoodName;
        private ColumnHeader Price;
        private Button LunchBtn;
        private Button Dinnerbtn;
        private Button Beveragesbtn;
        private Button Snacksbtn;
        private TextBox FoodSearchtxt;
        private Button foodSearchbtn;
        private Button RiceAddonsbtn;
        private Label label1;
        private Label label2;
    }
}