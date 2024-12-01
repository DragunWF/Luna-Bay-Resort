using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms.AdminPanelForms;
using Luna_Bay_Resort_App.Forms.ProfileForms;
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
                FormManager.CloseAllForms();
                FormManager.OpenForm<LoginForm>();
                Close();
            }
        }

        private void AdminPanelBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<AdminPanel>();
            Close();
        }

        private void CreditsBtn_Click(object sender, EventArgs e)
        {
            string creditsText = "Developers of the App:\n" +
                                 "1. Marc Plarisan | DragunWF - Lead Developer\n" +
                                 "2. Isaac Severino | Aysaaak - Developer, Database Administrator\n" +
                                 "3. Jay Arnon Sinahunon | JasDevPH - Developer, UI/UX Designer\n" +
                                 "4. Bastian Kyle Aguilar - Documentation\n" +
                                 "5. Daniel Kurt Buante - Assistant\n\n" +
                                 "GitHub Repository: https://github.com/DragunWF/Luna-Bay-Resort";

            using (var dialog = new CreditsDialog(creditsText, "Visit GitHub", "Close"))
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        var psi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = "https://github.com/DragunWF/Luna-Bay-Resort",
                            UseShellExecute = true
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to open the link. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
