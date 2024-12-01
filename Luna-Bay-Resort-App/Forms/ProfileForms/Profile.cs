using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using MainForms;

namespace Luna_Bay_Resort_App.Forms
{
    public partial class Profile : Form
    {
        public Profile()
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

        private void LogoutBtn_Click(object sender, EventArgs e)
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
                FormManager.CloseAllForms();
                FormManager.OpenForm<LoginForm>();
                Close();
            }
        }
    }
}
