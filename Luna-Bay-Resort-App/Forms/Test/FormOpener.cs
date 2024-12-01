using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms.AdminPanelForms;
using Luna_Bay_Resort_App.Forms.InventoryForms;
using Luna_Bay_Resort_App.Helpers;
using Luna_Bay_Sub_Forms;
using MainForms;
using SubForms;

namespace Luna_Bay_Resort_App.Forms.Test
{
    public partial class FormOpener : Form
    {
        public FormOpener()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<LoginForm>();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            SessionData.LoginUser(new User("9999", "Test Admin", "Test User", 1));
            FormManager.OpenForm<Dashboard>();
        }

        private void AddReservationBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<ReservationAddNew>();
        }

        private void EditReservationBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<ReservationEdit>();
        }

        private void SearchReservationBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<SearchReservation>();
        }

        private void CheckInBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<CheckIn>();
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<CheckOut>();
        }

        private void roomStatusChangeTest_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<RoomStatusChangeTest>();
        }

        private void AdminPanelBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<AdminPanel>();
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<MainInventory>();
        }
    }
}
