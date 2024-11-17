namespace MainForms
{
    public partial class FinancialReportsUserControl : UserControl
    {
        public FinancialReportsUserControl()
        {
            InitializeComponent();
            SetupFinancialLayout();
        }
        private void SetupFinancialLayout()
        {
            // Main container to hold both the title and the cards
            TableLayoutPanel mainContainer = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1,
                BackColor = Color.FromArgb(240, 240, 240),
                Padding = new Padding(10),
            };
            mainContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // Row for the title
            mainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // Row for the cards

            // Revenue title label
            Label revenueTitle = new Label
            {
                Text = "Revenue",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 10, 0, 10)
            };

            // TableLayoutPanel for the revenue cards
            TableLayoutPanel cardsPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                AutoSize = true,
                BackColor = Color.Transparent,
                Padding = new Padding(10)
            };


            // Add three cards to the panel
            cardsPanel.Controls.Add(CreateVerticalRevenueCard("Today", "As of 8:00am, 09-10-2024", "PHP 9,000.00", "14% greater than yesterday", Color.Green), 0, 0);
            cardsPanel.Controls.Add(CreateVerticalRevenueCard("This Week", "From 07 to 13-10-2024", "PHP 25,000.00", "9% more than last week", Color.Green), 1, 0);
            cardsPanel.Controls.Add(CreateVerticalRevenueCard("This Month", "October, 2024", "PHP 25,000.00", "-50% less than last month", Color.Red), 2, 0);

            // Add title and cards panel to mainContainer
            mainContainer.Controls.Add(revenueTitle, 0, 0);
            mainContainer.Controls.Add(cardsPanel, 0, 1);

            // Add mainContainer to the form's controls
            this.Controls.Add(mainContainer);
        }

        private Panel CreateVerticalRevenueCard(string title, string dateRange, string amount, string comparisonText, Color percentageColor)
        {
            // Card container
            Panel cardPanel = new Panel
            {
                Padding = new Padding(15),
                Margin = new Padding(15),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(300, 170) // Adjusted size for vertical layout
            };

            // Use a TableLayoutPanel for vertical alignment of content
            TableLayoutPanel tablePanel = new TableLayoutPanel
            {
                RowCount = 4,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(0),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            // Title label
            Label titleLabel = new Label
            {
                Text = title,
                Font = new Font("Consolas", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5)
            };

            // Date range label
            Label dateLabel = new Label
            {
                Text = dateRange,
                Font = new Font("Consolas", 8, FontStyle.Regular),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5)
            };

            // Amount label
            Label amountLabel = new Label
            {
                Text = amount,
                Font = new Font("Consolas", 14, FontStyle.Bold),
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5)
            };

            // Comparison label
            Label comparisonLabel = new Label
            {
                Text = comparisonText,
                Font = new Font("Consolas", 9, FontStyle.Regular),
                ForeColor = percentageColor,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5)
            };

            // Add labels to the TableLayoutPanel in separate rows
            tablePanel.Controls.Add(titleLabel, 0, 0);
            tablePanel.Controls.Add(dateLabel, 0, 1);
            tablePanel.Controls.Add(amountLabel, 0, 2);
            tablePanel.Controls.Add(comparisonLabel, 0, 3);

            // Add TableLayoutPanel to the card panel
            cardPanel.Controls.Add(tablePanel);

            return cardPanel;
        }
    }
}
