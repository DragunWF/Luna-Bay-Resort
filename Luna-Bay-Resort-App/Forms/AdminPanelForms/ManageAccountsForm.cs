using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using MainForms;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    public partial class ManageAccountsForm : Form
    {
        private List<User> employees;
        private User currentUser;

        public ManageAccountsForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            currentUser = SessionData.GetCurrentUser();
            employees = DatabaseHelper.GetUsers();
            RefreshDataGrid();
            accountsDataGrid.AllowUserToAddRows = false;
        }

        private void RefreshDataGrid()
        {
            accountsDataGrid.Rows.Clear();
            foreach (User employee in employees)
            {
                if (employee.GetEmpId() != currentUser.GetEmpId())
                {
                    accountsDataGrid.Rows.Add(employee.GetEmpId(), employee.GetName(), employee.GetPosition(), false, false);
                }
            }
        }

        private List<string> SelectEmployees(string checkBoxColumnName)
        {
            List<string> empIds = new(); // Employees to select

            try
            {
                foreach (DataGridViewRow row in accountsDataGrid.Rows)
                {
                    // Skip new or uninitialized rows
                    if (row.IsNewRow || row.Cells[checkBoxColumnName].Value == null)
                        continue;

                    // Safely check the checkbox value
                    if (row.Cells[checkBoxColumnName].Value is bool isChecked && isChecked)
                    {
                        var empId = row.Cells["EmpID"].Value?.ToString();
                        if (!string.IsNullOrEmpty(empId))
                            empIds.Add(empId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return empIds;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<User> results = new();
            string query = SearchTxt.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(query))
            {
                accountsDataGrid.Rows.Clear();
                foreach (User user in DatabaseHelper.GetUsers())
                {
                    if (user.GetEmpId() == currentUser.GetEmpId())
                    {
                        continue;
                    }
                    if (user.GetName().ToLower().Contains(query) ||
                        user.GetPosition().ToLower().Contains(query))
                    {
                        results.Add(user);
                    }
                }
                employees.Clear();
                employees = results;
            }
            else
            {
                employees = DatabaseHelper.GetUsers();
            }
            RefreshDataGrid();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            List<string> empIds = SelectEmployees("ResetPassword"); // Employees to reset passwords on
            if (empIds.Count > 0)
            {
                // Prompt for a new password
                string newPassword = PromptForPassword();
                if (!string.IsNullOrEmpty(newPassword))
                {
                    // Reset passwords
                    DatabaseHelper.ResetUserPassword(empIds, newPassword);
                    RefreshDataGrid();
                    MessageBox.Show($"Selected account passwords have been reset to: {newPassword}");
                    DatabaseHelper.AddActivity($"Reset password for accounts with IDs: {string.Join(", ", empIds)}",
                                                Utils.GetCurrentDate());
                }
                else
                {
                    MessageBox.Show("Password reset operation was cancelled.");
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<string> empIds = SelectEmployees("Delete"); // IDs of employee accounts to delete
            if (empIds.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete these accounts? This critical action that cannot be undone",
                    "Confirm Accounts to Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteUserAccounts(empIds);
                    DatabaseHelper.AddActivity($"Deleted Accounts (IDs): {string.Join(", ", empIds)}",
                                                Utils.GetCurrentDate());
                    employees = DatabaseHelper.GetUsers();
                    RefreshDataGrid();
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private string PromptForPassword()
        {
            // Create a custom form
            Form prompt = new Form
            {
                Width = 350,
                Height = 200,
                Text = "Set New Password For Selected Accounts",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false
            };

            // Labels for instructions
            Label passwordLabel = new Label
            {
                Left = 10,
                Top = 10,
                Text = "Enter new password:",
                AutoSize = true
            };

            Label confirmPasswordLabel = new Label
            {
                Left = 10,
                Top = 60,
                Text = "Confirm new password:",
                AutoSize = true
            };

            // TextBox for the password
            TextBox passwordTextBox = new TextBox
            {
                Left = 10,
                Top = 30,
                Width = 300,
                UseSystemPasswordChar = true // Hides the password text
            };

            // TextBox for confirming the password
            TextBox confirmPasswordTextBox = new TextBox
            {
                Left = 10,
                Top = 80,
                Width = 300,
                UseSystemPasswordChar = true // Hides the password text
            };

            Button confirmation = new Button
            {
                Text = "OK",
                Left = 240,
                Width = 70,
                Top = 120,
                DialogResult = DialogResult.OK
            };

            // Add controls to the form
            prompt.Controls.Add(passwordLabel);
            prompt.Controls.Add(passwordTextBox);
            prompt.Controls.Add(confirmPasswordLabel);
            prompt.Controls.Add(confirmPasswordTextBox);
            prompt.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                if (passwordTextBox.Text == confirmPasswordTextBox.Text)
                {
                    return passwordTextBox.Text; // Return the new password
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return string.Empty; // Return empty if cancelled or passwords don't match
        }
    }
}
