using Luna_Bay_Resort_App.Helpers;

namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<CreateNewAccount>();
        }

        private void ViewAccountsBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<ManageAccountsForm>();
        }

        private void ResetAccountBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteAccountBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
