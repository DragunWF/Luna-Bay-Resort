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

        private void FoodListTestbtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<GetFoodsTest>();
        }

        private void roomStatusChangeTest_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<RoomStatusChangeTest>();
        }
    }
}
