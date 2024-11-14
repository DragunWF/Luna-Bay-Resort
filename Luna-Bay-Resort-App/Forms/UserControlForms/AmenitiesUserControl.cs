using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using Luna_Bay_Sub_Forms;
using SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class AmenitiesUserControl : UserControl
    {
        public AmenitiesUserControl()
        {
            InitializeComponent();
            InitializeAmenitiesLayout();
        }
        private void InitializeAmenitiesLayout()
        {
           
            TableLayoutPanel mainPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(10),
            };

            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40)); 

            
            Panel menuListPanel = CreateMenuListPanel();
            mainPanel.Controls.Add(menuListPanel, 0, 0);

            
            Panel checkoutPanel = CreateCheckoutPanel();
            mainPanel.Controls.Add(checkoutPanel, 1, 0);

            this.Controls.Add(mainPanel);
        }

        private Panel CreateMenuListPanel()
        {
            TableLayoutPanel menuPanel = new TableLayoutPanel
            {
                Width = 400,
                Height = 250,
                Dock = DockStyle.Fill,
                RowCount = 3,
            };

            
            menuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            menuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
            menuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));

           
            Label menuTitle = new Label
            {
                Text = "Menu List",
                Font = new Font("Consolas", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            menuPanel.Controls.Add(menuTitle, 0, 0);

            
            DataGridView menuTable = new DataGridView
            {
                ColumnHeadersVisible = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Dock = DockStyle.Fill,
            };
            menuTable.Columns.Add("Name", "Name");
            menuTable.Columns.Add("Price", "Price");
            menuPanel.Controls.Add(menuTable, 0, 1);

            
            FlowLayoutPanel bottomPanel = new FlowLayoutPanel
            {
                Height = 300,
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,

            };

            TextBox searchBox = new TextBox
            {
                PlaceholderText = "Search..",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                Height = 60, 
                Width = 827
            };

            Button searchButton = new Button
            {
                Text = "Search",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#2E2F5B"),
                Height = 35, 
                Width = 100, 
                ForeColor = Color.White
            };

            searchButton.Click += (sender, e) =>
            {
                SearchFood(searchBox.Text);
            };

            Button addOnButton = new Button
            {

                Text = "Add-On",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#3ADF00"),
                Height = 35, 
                Width = 100, 
                ForeColor = Color.White,
                Margin = new Padding(80, 0, 0, 0)
            };

            addOnButton.Click += (sender, e) =>
            {
                int foodtype = 4;
                DisplayFoodByFoodID(foodtype);
            };

            Button breakfastButton = new Button
            {
                Text = "Breakfast",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, 
                Width = 120,
                ForeColor = Color.Black
            };

            breakfastButton.Click += (sender, e) =>
            {
                int foodtype = 1;
                DisplayFoodByFoodID(foodtype);
            };

            Button lunchButton = new Button
            {
                Text = "Lunch",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, 
                Width = 100, 
                ForeColor = Color.Black
            };

            lunchButton.Click += (sender, e) =>
            {
                int foodtype = 2;
                DisplayFoodByFoodID(foodtype);
            };

            Button dinnerButton = new Button
            {
                Text = "Dinner",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, 
                Width = 100, 
                ForeColor = Color.Black
            };

            dinnerButton.Click += (sender, e) =>
            {
                int foodtype = 3;
                DisplayFoodByFoodID(foodtype);
            };

            Button beveragesButton = new Button
            {
                Text = "Beverages",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, 
                Width = 120, 
                ForeColor = Color.Black
            };

            beveragesButton.Click += (sender, e) =>
            {
                int foodtype = 6;
                DisplayFoodByFoodID(foodtype);
            };

            Button snacksButton = new Button
            {
                Text = "Snacks",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, 
                Width = 100, 
                ForeColor = Color.Black
            };

            snacksButton.Click += (sender, e) =>
            {
                int foodtype = 5;
                DisplayFoodByFoodID(foodtype);
            };

            Button cancelButton = new Button
            {
                Text = "Cancel",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#F50000"),
                Height = 35, 
                Width = 100, 
                ForeColor = Color.White,
                Margin = new Padding(450, 0, 0, 0)
            };


            bottomPanel.Controls.AddRange(new Control[]
            {
                searchBox,
                searchButton,
                addOnButton,
                breakfastButton,
                lunchButton,
                dinnerButton,
                beveragesButton,
                snacksButton,
                cancelButton
            });
            menuPanel.Controls.Add(bottomPanel, 0, 2);
            return menuPanel;

            void DisplayFoodByFoodID(int FoodType)
            {
                List<Food> foods = DatabaseHelper.getFoodbyType(FoodType);

                menuTable.Rows.Clear();

                foreach (var food in foods)
                {
                    string formattedPrice = Utils.FormatCurrency(food.getPrice());
                    menuTable.Rows.Add(food.getFoodName(), formattedPrice);
                }
            }

            void SearchFood(string FoodName)
            {
                List<Food> foods = DatabaseHelper.searchFood(FoodName);

                menuTable.Rows.Clear();

                foreach (var food in foods)
                {
                    string formattedPrice = Utils.FormatCurrency(food.getPrice());
                    menuTable.Rows.Add(food.getFoodName(), formattedPrice);
                }
            }
        }

        private Panel CreateCheckoutPanel()
        {
            TableLayoutPanel checkoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
            };
            checkoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            checkoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            checkoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

            
            Label checkoutTitle = new Label
            {
                Text = "Checkout",
                Font = new Font("Consolas", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            checkoutPanel.Controls.Add(checkoutTitle, 0, 0);

            
            DataGridView checkoutTable = new DataGridView
            {
                ColumnHeadersVisible = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Dock = DockStyle.Fill,
            };
            checkoutTable.Columns.Add("Name", "Name");
            checkoutTable.Columns.Add("Qty", "Qty");
            checkoutTable.Columns.Add("Price", "Price");
            checkoutPanel.Controls.Add(checkoutTable, 0, 1);

          
            TableLayoutPanel totalPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 4,
            };

            Label subTotalLabel = new Label { Text = "Sub Total: 200.00", Font = new Font("Consolas", 10) };
            Label vatLabel = new Label { Text = "VAT: 24.00", Font = new Font("Consolas", 10) };
            Label totalLabel = new Label { Text = "Total: 224.00", Font = new Font("Consolas", 14, FontStyle.Bold), Margin = new Padding(0, 10, 0, 0), };

            Button payButton = new Button
            {
                Width = 740,
                Text = "Pay Order",
                Font = new Font("Consolas", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#FFDA00"),
                ForeColor = Color.Black,
                Height = 40,
                Margin = new Padding(0, 20, 0, 0),

            };

            payButton.Click += (sender, e) =>
            {
                FormManager.OpenForm<AmenitiesReceipt>();
            };


            totalPanel.Controls.Add(subTotalLabel, 0, 1);
            totalPanel.Controls.Add(vatLabel, 0, 2);
            totalPanel.Controls.Add(totalLabel, 0, 3);
            totalPanel.Controls.Add(payButton, 0, 4);
            checkoutPanel.Controls.Add(totalPanel, 0, 2);
            return checkoutPanel;
        }
    }
}
