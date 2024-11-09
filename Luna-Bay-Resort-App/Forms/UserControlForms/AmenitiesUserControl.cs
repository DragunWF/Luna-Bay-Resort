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
            // Main panel for layout
            TableLayoutPanel mainPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(10),
            };

            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60)); // Menu List side
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40)); // Checkout side

            // Menu List panel
            Panel menuListPanel = CreateMenuListPanel();
            mainPanel.Controls.Add(menuListPanel, 0, 0);

            // Checkout panel
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

            // Define row heights: 10% for title, 70% for DataGridView, 20% for controls
            menuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            menuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
            menuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));

            // Title label for Menu List
            Label menuTitle = new Label
            {
                Text = "Menu List",
                Font = new Font("Consolas", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            menuPanel.Controls.Add(menuTitle, 0, 0);

            // Table for menu items with controlled size
            DataGridView menuTable = new DataGridView
            {
                ColumnHeadersVisible = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Dock = DockStyle.Fill,
            };
            menuTable.Columns.Add("Name", "Name");
            menuTable.Columns.Add("Price", "Price");
            menuPanel.Controls.Add(menuTable, 0, 1);

            // Add bottom controls like search, add-ons, categories
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
                Height = 60, // Increased the height for better visibility
                Width = 827
            };

            Button searchButton = new Button
            {
                Text = "Search",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#2E2F5B"),
                Height = 35, // Increased the height
                Width = 100, // Custom width for consistency
                ForeColor = Color.White
            };

            Button addOnButton = new Button
            {

                Text = "Add-On",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#3ADF00"),
                Height = 35, // Increased the height
                Width = 100, // Custom width for consistency
                ForeColor = Color.White,
                Margin = new Padding(80, 0, 0, 0)
            };

            Button breakfastButton = new Button
            {
                Text = "Breakfast",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, // Increased the height
                Width = 120, // Custom width for consistency
                ForeColor = Color.Black
            };

            Button lunchButton = new Button
            {
                Text = "Lunch",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, // Increased the height
                Width = 100, // Custom width for consistency
                ForeColor = Color.Black
            };

            Button dinnerButton = new Button
            {
                Text = "Dinner",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, // Increased the height
                Width = 100, // Custom width for consistency
                ForeColor = Color.Black
            };

            Button beveragesButton = new Button
            {
                Text = "Beverages",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, // Increased the height
                Width = 120, // Custom width for consistency
                ForeColor = Color.Black
            };

            Button snacksButton = new Button
            {
                Text = "Snacks",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Height = 35, // Increased the height
                Width = 100, // Custom width for consistency
                ForeColor = Color.Black
            };

            Button cancelButton = new Button
            {
                Text = "Cancel Order",
                Font = new Font("Consolas", 12, FontStyle.Regular),
                BackColor = ColorTranslator.FromHtml("#F50000"),
                Height = 35, // Increased the height
                Width = 150, // Custom width to accommodate the text
                ForeColor = Color.White,
                Margin = new Padding(215, 0, 0, 0)
            };

            // Add all controls to bottomPanel
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

            // Add bottomPanel to menuPanel at the specified grid location
            menuPanel.Controls.Add(bottomPanel, 0, 2);


            return menuPanel;
        }

        private Panel CreateCheckoutPanel()
        {
            TableLayoutPanel checkoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
            };

            // Define row heights: 10% for title, 70% for DataGridView, 20% for totals and button
            checkoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            checkoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            checkoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

            // Title label for Checkout
            Label checkoutTitle = new Label
            {
                Text = "Checkout",
                Font = new Font("Consolas", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            checkoutPanel.Controls.Add(checkoutTitle, 0, 0);

            // Table for checkout items with controlled size
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

            // Total and Pay Order button at bottom
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

            totalPanel.Controls.Add(subTotalLabel, 0, 1);
            totalPanel.Controls.Add(vatLabel, 0, 2);
            totalPanel.Controls.Add(totalLabel, 0, 3);
            totalPanel.Controls.Add(payButton, 0, 4);



            checkoutPanel.Controls.Add(totalPanel, 0, 2);

            return checkoutPanel;
        }
    }
}
