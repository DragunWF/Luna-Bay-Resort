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
            label10.Text = $"{DatabaseHelper.GetOutofStock().ToString()} Items";
            //Low stock label
            label11.Text = $"{DatabaseHelper.GetLowStock().ToString()} Items";
            //Full stock label
            label12.Text = $"{DatabaseHelper.GetFullStock().ToString()} Items";
        }
    }
}
