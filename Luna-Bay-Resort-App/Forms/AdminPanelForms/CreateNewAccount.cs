using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using MainForms;

namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    public partial class CreateNewAccount : Form
    {
        public CreateNewAccount()
        {
            InitializeComponent();
            TxtPassword.UseSystemPasswordChar = true;
            TxtConfirmPassword.UseSystemPasswordChar = true;

            foreach (string position in DatabaseHelper.GetPositions())
            {
                PositionCB.Items.Add(position);
            }
            PositionCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (IsUsernameAvailable())
            {
                MessageBox.Show($"The username '{TxtUsername.Text}' is already taken, please type a distinct username.");
            }
            else if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                MessageBox.Show("Password and confirm password fields do not match!");
            }
            else if (Utils.IsTextBoxesNotEmpty(new string[] { TxtUsername.Text, TxtPassword.Text, TxtConfirmPassword.Text, PositionCB.Text }))
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to create this account with the name of {TxtUsername.Text}?",
                    "Confirm Account Creation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string position = PositionCB.Text;
                    int authId = DatabaseHelper.GetAuthId(position);
                    User user = new User(TxtUsername.Text, position, authId);
                    DatabaseHelper.AddUser(user.GetName(), TxtPassword.Text, authId);
                    ResetTextBoxes();
                    MessageBox.Show($"Account named '{user.GetName()}' with the position '{position}' has been created!");
                }
            }
        }

        private void ResetTextBoxes()
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtConfirmPassword.Text = "";
            PositionCB.Text = "";
        }

        private bool IsUsernameAvailable()
        {
            bool isUsernameTaken = false;
            foreach (User user in DatabaseHelper.GetUsers())
            {
                if (user.GetName() == TxtUsername.Text)
                {
                    isUsernameTaken = true;
                    break;
                }
            }
            return isUsernameTaken;
        }
    }
}
