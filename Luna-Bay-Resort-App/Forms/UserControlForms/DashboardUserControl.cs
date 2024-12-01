using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using System.Data;

namespace Luna_Bay_Resort_App.Forms.UserControlForms
{
    public partial class DashboardUserControl : UserControl
    {
        public DashboardUserControl()
        {
            InitializeComponent();

            GetReservation();
            StockLevels();
            DisplayActivities();
            DisplayRevenue();
        }

        private void DisplayActivities()
        {
            foreach (var activity in DatabaseHelper.GetActivities())
            {
                activitiesDataGrid.Rows.Add(activity.GetDescription(), activity.GetDate());
            }
        }

        private void DisplayRevenue()
        {
            List<Revenue> revenue = DatabaseHelper.GetRevenue();
            string today = Utils.GetDateOnly();
            DateTime todayDate = DateTime.ParseExact(today, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            double todayRevenue = 0;
            double weeklyRevenue = 0;
            double monthlyRevenue = 0;

            foreach (Revenue item in revenue)
            {
                DateTime itemDate = DateTime.ParseExact(item.GetDate(), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                // Today's revenue
                if (itemDate.Date == todayDate.Date)
                {
                    todayRevenue += item.GetRevenue();
                }

                // Weekly revenue (last 7 days, including today)
                if ((todayDate - itemDate).TotalDays <= 7 && (todayDate - itemDate).TotalDays >= 0)
                {
                    weeklyRevenue += item.GetRevenue();
                }

                // Monthly revenue (same month and year)
                if (itemDate.Year == todayDate.Year && itemDate.Month == todayDate.Month)
                {
                    monthlyRevenue += item.GetRevenue();
                }
            }

            // Update labels with formatted revenue
            todayLabel.Text = Utils.FormatCurrency(todayRevenue);
            weekLabel.Text = Utils.FormatCurrency(weeklyRevenue);
            monthLabel.Text = Utils.FormatCurrency(monthlyRevenue);
        }

        private void GetReservation()
        {
            List<Guest> reservations = DatabaseHelper.GetDashboardReservations(Utils.GetDateOnly());
            foreach (var reservation in reservations)
            {
                reservationsDataGrid.Rows.Add(reservation.GetReservationId(), reservation.GetName());
            }
        }

        private void StockLevels()
        {
            //Out of stock label
            outOfStockLabel.Text = $"{DatabaseHelper.GetOutofStock().ToString()} Items";
            //Low stock label
            lowStockLabel.Text = $"{DatabaseHelper.GetLowStock().ToString()} Items";
            //Full stock label
            fullStockLabel.Text = $"{DatabaseHelper.GetFullStock().ToString()} Items";
        }
    }
}
