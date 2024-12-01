using Luna_Bay_Resort_App.Helpers;
using Luna_Bay_Resort_App.Data;

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

            
            // Add title and cards panel to mainContainer
            mainContainer.Controls.Add(revenueTitle, 0, 0);
            mainContainer.Controls.Add(CreateRevenueCardsPanel(), 0, 1);

            // Add mainContainer to the form's controls
            this.Controls.Add(mainContainer);
        }

        private TableLayoutPanel CreateRevenueCardsPanel()
        {
            Dictionary<string, double> revenueByDate = new(); // date, revenue
            List<Revenue> revenue = DatabaseHelper.GetRevenue();

            foreach (Revenue item in revenue)
            {
                if (revenueByDate.ContainsKey(item.GetDate()))
                {
                    double currentRevenue = revenueByDate[item.GetDate()];
                    revenueByDate.Add(item.GetDate(), currentRevenue + item.GetRevenue());
                }
                else
                {
                    revenueByDate.Add(item.GetDate(), item.GetRevenue());
                }
            }

            // TableLayoutPanel for the revenue cards
            TableLayoutPanel cardsPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                AutoSize = true,
                BackColor = Color.Transparent,
                Padding = new Padding(10)
            };

            // Add revenue cards to the panel
            const int columnsPerRow = 5;
            for (int column = 0, row = 0; column < revenueByDate.Keys.Count; column++, row++)
            {
                string date = revenueByDate.Keys.ElementAt<string>(column);
                string formattedRevenue = Utils.FormatCurrency(revenueByDate[date]);
                cardsPanel.Controls.Add(CreateVerticalRevenueCard(
                    date, "Revenue for this day", formattedRevenue, "Total Revenue Gained", Color.Green
                ), column, row / (columnsPerRow - 1));
            }

            return cardsPanel;
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
