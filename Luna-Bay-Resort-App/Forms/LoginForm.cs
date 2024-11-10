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
            new Dashboard().Show();
        }
    }
}
