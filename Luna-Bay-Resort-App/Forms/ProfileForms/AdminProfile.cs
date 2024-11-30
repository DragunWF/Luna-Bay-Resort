using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms.AdminPanelForms;
using Luna_Bay_Resort_App.Helpers;
using MainForms;

namespace Luna_Bay_Resort_App.Forms
{
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            User currentUser = SessionData.GetCurrentUser();
            if (currentUser != null)
            {
                NameText.Text = $"Name: {SessionData.GetCurrentUser().GetName()}";
                PositionText.Text = $"Position: {SessionData.GetCurrentUser().GetPosition()}";
            }
            else
            {
                NameText.Text = "Name: [Test Mode]";
                PositionText.Text = "Position: [Test Mode]";
            }
        }

        private void LogoutAdminBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                SessionData.LogoutUser();
                FormManager.OpenForm<LoginForm>();
                FormManager.CloseForm<Dashboard>();
                Close();
            }
        }

        private void AdminPanelBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<AdminPanel>();
            Close();
        }
    }
}
