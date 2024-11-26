using Luna_Bay_Resort_App.Helpers;

namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (Utils.IsTextBoxesNotEmpty(new string[] 
                { TxtUsername.Text, TxtPassword.Text, TxtConfirmPassword.Text, PositionCB.Text }
            ))
            {

            }
        }
    }
}
