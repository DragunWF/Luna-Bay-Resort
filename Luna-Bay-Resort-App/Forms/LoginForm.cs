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
            // temporary code
            FormManager.OpenForm<Dashboard>();
        }
    }
}
