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
            LoginPassword.PasswordChar = '*';
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
                        MessageBox.Show($"Welcome, {user.getName()}. Your position is {user.getPosition()}.");
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
    }
}
