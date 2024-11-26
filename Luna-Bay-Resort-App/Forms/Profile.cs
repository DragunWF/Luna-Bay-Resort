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
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            SessionData.LogoutUser();
            FormManager.OpenForm<LoginForm>();
            FormManager.CloseForm<Dashboard>();
            Close();
        }
    }
}
