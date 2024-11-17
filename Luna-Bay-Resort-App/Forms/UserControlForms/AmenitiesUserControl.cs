using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using SubForms;

namespace MainForms
{
    public partial class AmenitiesUserControl : UserControl
    {
        private DataGridView checkoutTable;

        private Label subTotalLabel;
        private Label vatLabel;
        private Label totalLabel;

        private double subtotal, vat, total;

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
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
                Dock = DockStyle.Fill,    
            };
            menuTable.Columns.Add("Name", "Name");
            menuTable.Columns.Add("Qty", "Qty");
            menuTable.Columns.Add("Price", "Price");
            menuPanel.Controls.Add(menuTable, 0, 1);

            menuTable.Columns["Name"].Width = 700;
            menuTable.Columns["Qty"].Width = 100;
            menuTable.Columns["Price"].Width = 275;

            menuTable.Columns["Name"].ReadOnly = true;
            menuTable.Columns["Qty"].ReadOnly = true;
            menuTable.Columns["Price"].ReadOnly = true;

            //Click Option Event
            menuTable.CellClick += (sender, e) =>
            {
                string itemName = menuTable.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                string itemPriceText = menuTable.Rows[e.RowIndex].Cells["Price"].Value?.ToString();

                if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(itemPriceText))
                {
                    return;
                }

                // Remove "PHP" from the price
                decimal itemPrice = 0;
                if (decimal.TryParse(itemPriceText.Replace("PHP", "").Trim(), out decimal price))
                {
                    itemPrice = price;
                }

                // Check if the item already exists in the checkoutTable
                bool itemExists = false;
                foreach (DataGridViewRow row in checkoutTable.Rows)
                {
                    if (row.Cells["Name"].Value?.ToString() == itemName)
                    {
                        int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                        row.Cells["Qty"].Value = currentQty + 1;
                        row.Cells["Price"].Value = (currentQty + 1) * itemPrice;
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    checkoutTable.Rows.Add(itemName, 1, itemPrice);
                }

                UpdateTotal();
            };

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
                DisplayFoodByFoodID(4);

                GetProduct();

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
                DisplayFoodByFoodID(1);
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
                DisplayFoodByFoodID(2);
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
                DisplayFoodByFoodID(3);
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
                DisplayFoodByFoodID(6);
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
                DisplayFoodByFoodID(5);
            };
            Button swimWearButton = new Button
            {
                Text = "Swimwear",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35,
                Width = 120,
                ForeColor = Color.Black,
                
            };

            Button cancelButton = new Button
            {
                Text = "Cancel",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#F50000"),
                Height = 35,
                Width = 100,
                ForeColor = Color.White,
                Margin = new Padding(323, 0, 0, 0)
            };

            cancelButton.Click += (sender, e) =>
            {
                checkoutTable.Rows.Clear();
                UpdateTotal();
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
                swimWearButton,
                cancelButton
            });
            menuPanel.Controls.Add(bottomPanel, 0, 2);
            return menuPanel;

            void DisplayFoodByFoodID(int FoodType)
            {
                List<Food> foods = DatabaseHelper.GetFoodbyType(FoodType);

                menuTable.Rows.Clear();

                foreach (var food in foods)
                {
                    string formattedPrice = Utils.FormatCurrency(food.getPrice());
                    menuTable.Rows.Add(food.getFoodName(), formattedPrice);
                }
            }

            void SearchFood(string FoodName)
            {
                List<Food> foods = DatabaseHelper.SearchFood(FoodName);

                menuTable.Rows.Clear();

                foreach (var food in foods)
                {
                    string formattedPrice = Utils.FormatCurrency(food.getPrice());
                    menuTable.Rows.Add(food.getFoodName(), formattedPrice);
                }
            }

            void GetProduct()
            {
                List<Product> products = DatabaseHelper.GetProduct();

                foreach (var product in products)
                {
                    string formattedPrice = Utils.FormatCurrency(product.getPrice());
                    menuTable.Rows.Add(product.getProductName(), formattedPrice);
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


            checkoutTable = new DataGridView
            {
                ColumnHeadersVisible = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Dock = DockStyle.Fill,
            };
            checkoutTable.Columns.Add("Name", "Name");
            checkoutTable.Columns.Add("Qty", "Qty");
            checkoutTable.Columns.Add("Price", "Price");
            checkoutPanel.Controls.Add(checkoutTable, 0, 1);

            checkoutTable.Columns["Name"].Width =300;
            checkoutTable.Columns["Qty"].Width = 50;
            checkoutTable.Columns["Price"].Width = 80;


            checkoutTable.Columns["Name"].ReadOnly = true;
            checkoutTable.Columns["Qty"].ReadOnly = true;
            checkoutTable.Columns["Price"].ReadOnly = true;

            //Remove quantity in checkout table
            checkoutTable.CellClick += (sender, e) =>
            {
                string itemName = checkoutTable.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                string qtyText = checkoutTable.Rows[e.RowIndex].Cells["Qty"].Value?.ToString();
                string itemPriceText = checkoutTable.Rows[e.RowIndex].Cells["Price"].Value?.ToString();

                if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(qtyText))
                {
                    return;
                }
                int quantity = Convert.ToInt32(qtyText);
                int totalItemPrice = Convert.ToInt32(itemPriceText);
                int itemUnitPrice = totalItemPrice / quantity;

                if (quantity > 1)
                {
                    quantity--;
                    checkoutTable.Rows[e.RowIndex].Cells["Qty"].Value = quantity;
                    checkoutTable.Rows[e.RowIndex].Cells["Price"].Value = quantity * itemUnitPrice;
                }
                else
                {
                    checkoutTable.Rows.RemoveAt(e.RowIndex);
                }
                UpdateTotal();
            };

            TableLayoutPanel totalPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 4,
            };

            subTotalLabel = new Label { Text = "Sub Total:", Font = new Font("Consolas", 10), AutoSize = true };
            vatLabel = new Label { Text = "VAT:", Font = new Font("Consolas", 10), AutoSize = true };
            totalLabel = new Label { Text = "Total:", Font = new Font("Consolas", 14, FontStyle.Bold), Margin = new Padding(0, 10, 0, 0), AutoSize = true };

            Button payButton = new Button
            {
                Width = 743,
                Text = "Pay Order",
                Font = new Font("Consolas", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#FFDA00"),
                ForeColor = Color.Black,
                Height = 40,
                Margin = new Padding(0, 20, 0, 0),

            };

            payButton.Click += (sender, e) =>
            {
                List<Amenity> amenities = new();
                try
                {
                    foreach (DataGridViewRow row in checkoutTable.Rows)
                    {
                        if (row.Cells["Name"].Value != null)
                        {
                            amenities.Add(new Amenity(
                                row.Cells["Name"].Value.ToString(),
                                int.Parse(row.Cells["Qty"].Value.ToString()),
                                double.Parse(row.Cells["Price"].Value.ToString())
                           ));
                        }
                    }
                    if (amenities.Count > 0)
                    {
                        SessionData.FillAmenities(amenities);
                        FormManager.OpenForm<AmenitiesReceipt>();
                        checkoutTable.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("There are no items in the cart!");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"An unexpected error has occured: {err.Message}");
                }
            };

            totalPanel.Controls.Add(subTotalLabel, 0, 1);
            totalPanel.Controls.Add(vatLabel, 0, 2);
            totalPanel.Controls.Add(totalLabel, 0, 3);
            totalPanel.Controls.Add(payButton, 0, 4);
            checkoutPanel.Controls.Add(totalPanel, 0, 2);
            return checkoutPanel;
        }

        private void UpdateTotal()
        {
            subtotal = 0;

            foreach (DataGridViewRow row in checkoutTable.Rows)
            {
                if (int.TryParse(row.Cells["Price"].Value?.ToString(), out int price))
                {
                    subtotal += price;
                }
            }
            vat = subtotal * 0.10;
            total = subtotal + vat;

            subTotalLabel.Text = $"Sub Total: {Utils.FormatCurrency(subtotal)}";
            vatLabel.Text = $"VAT: {Utils.FormatCurrency(vat)}";
            totalLabel.Text = $"Total: {Utils.FormatCurrency(total)}";
        }
    }
}
