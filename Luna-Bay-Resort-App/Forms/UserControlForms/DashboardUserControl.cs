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
            Refresh();
        }

        private void DisplayActivities()
        {
            activitiesDataGrid.Rows.Clear();
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
            double yearlyRevenue = 0;

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

                // Yearly revenue
                if (itemDate.Year == todayDate.Year)
                {
                    yearlyRevenue += item.GetRevenue();
                }
            }

            // Update labels with formatted revenue
            todayLabel.Text = Utils.FormatCurrency(todayRevenue);
            weekLabel.Text = Utils.FormatCurrency(weeklyRevenue);
            monthLabel.Text = Utils.FormatCurrency(monthlyRevenue);
            yearLabel.Text = Utils.FormatCurrency(yearlyRevenue);
        }

        private void DisplayReservations()
        {
            reservationsDataGrid.Rows.Clear();
            List<Guest> reservations = DatabaseHelper.GetDashboardReservations(Utils.GetDateOnly());
            foreach (var reservation in reservations)
            {
                reservationsDataGrid.Rows.Add(reservation.GetReservationId(), reservation.GetName());
            }
        }

        private void DisplayStockLevels()
        {
            // Out of stock label
            outOfStockLabel.Text = $"{DatabaseHelper.GetOutofStock()} Items";
            // Low stock label
            lowStockLabel.Text = $"{DatabaseHelper.GetLowStock()} Items";
            // Full stock label
            fullStockLabel.Text = $"{DatabaseHelper.GetFullStock()} Items";
        }

        private void Refresh()
        {
            DisplayReservations();
            DisplayStockLevels();
            DisplayActivities();
            DisplayRevenue();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void CheckInBtn_Click(object sender, EventArgs e)
        {
            const string checkBoxColumnName = "Select";
            try
            {
                List<int> reservationIds = new(); // Reservations to select

                foreach (DataGridViewRow row in reservationsDataGrid.Rows)
                {
                    // Skip new or uninitialized rows
                    if (row.IsNewRow || row.Cells[checkBoxColumnName].Value == null)
                        continue;

                    // Safely check the checkbox value
                    if (row.Cells[checkBoxColumnName].Value is bool isChecked && isChecked)
                    {
                        var reservationId = row.Cells["ReservationId"].Value?.ToString();
                        if (!string.IsNullOrEmpty(reservationId))
                            reservationIds.Add(int.Parse(reservationId));
                    }
                }

                if (reservationIds.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to check-in the selected reservations?",
                        "Confirm Check-in of Selected Reservations",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        DatabaseHelper.CheckInReservations(reservationIds);
                        DatabaseHelper.AddActivity($"Checked in {reservationIds.Count} reservation(s)", Utils.GetCurrentDate());
                        Refresh();
                        MessageBox.Show("Selected reservations have been checked-in");
                    }
                }
                else
                {
                    MessageBox.Show("There are no selected reservations to check-in!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearActivitiesBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to clear the activity log?",
                "Confirm Check-in of Selected Reservations",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.ClearActivities();
                Refresh();
                MessageBox.Show("Activities have been cleared!");
            }
        }
    }
}
