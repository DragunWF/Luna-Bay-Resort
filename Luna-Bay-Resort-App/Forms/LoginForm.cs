using Luna_Bay_Resort_App.Helpers;

namespace MainForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (IsValidTextBoxes())
            {
                // TODO: Implement login authentication
                FormManager.OpenForm<Dashboard>();
            }
            else
            {
                MessageBox.Show("Do not leave any of the text fields empty!");
            }
        }

        private bool IsValidTextBoxes()
        {
            return !(string.IsNullOrWhiteSpace(LoginPassword.Text) || 
                     string.IsNullOrWhiteSpace(LoginPassword.Text));
        }
    }
}
