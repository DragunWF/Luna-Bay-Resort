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
        }

        private void DisplayActivities()
        {

        }

        private void GetReservation()
        {
            List<Guest> reservations = DatabaseHelper.GetDashboardReservations(Utils.GetDateOnly());
            foreach (var reservation in reservations)
            {
                dataGridView2.Rows.Add(reservation.GetReservationId(), reservation.GetName());
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
