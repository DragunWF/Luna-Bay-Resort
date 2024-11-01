using System.Windows;
using Luna_Bay_Resort.Controls;

namespace Luna_Bay_Resort
{
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            NavBar.ButtonClicked += NavBar_ButtonClicked; // Subscribe to the event
        }

        private void NavBar_ButtonClicked(string view)
        {
            ChangeContent(view);
        }

        public void ChangeContent(string view)
        {
            switch (view)
            {
                case "Booking":
                    MainContent.Content = new BookingUserControl();
                    break;
                case "POS":
                    MainContent.Content = new POSUserControl();
                    break;
                case "Maintenance":
                    MainContent.Content = new MaintenanceUserControl();
                    break;
                case "FinancialReports":
                    MainContent.Content = new FinancialReportsUserControl();
                    break;
                default:
                    break;
            }
        }
    }
}
