using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;

namespace MainForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            LoginPassword.UseSystemPasswordChar = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidTextBoxes())
                {
                    User user = DatabaseHelper.GetUser(LoginUsername.Text, LoginPassword.Text);
                    if (user != null)
                    {
                        MessageBox.Show($"Welcome, {user.GetName()}. Your position is {user.GetPosition()}.");
                        SessionData.LoginUser(user);
                        FormManager.OpenForm<Dashboard>();
                        Close();
                    }
                    else
                    {
                        Utils.ResetTextBoxes(new TextBox[] { LoginUsername, LoginPassword });
                        MessageBox.Show("Invalid credentials or user does not exist!");
                    }
                }
                else
                {
                    MessageBox.Show("Do not leave any of the text fields empty!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private bool IsValidTextBoxes()
        {
            return !(string.IsNullOrWhiteSpace(LoginUsername.Text) ||
                     string.IsNullOrWhiteSpace(LoginPassword.Text));
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoginPassword.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
    }
}
