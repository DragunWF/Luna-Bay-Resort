using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using MainForms;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    public partial class ViewAccountsForm : Form
    {
        private List<User> employees;
        private const string defaultPassword = "Luna123";

        public ViewAccountsForm()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            employees = DatabaseHelper.GetUsers();

            // Add columns if not already added
            if (accountsDataGrid.Columns.Count == 0)
            {
                accountsDataGrid.Columns.Add("EmployeeID", "EmployeeID");
                accountsDataGrid.Columns.Add("Username", "Username");
                accountsDataGrid.Columns.Add("Position", "Position");

                var resetPasswordColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "ResetPassword",
                    HeaderText = "Reset Password"
                };
                accountsDataGrid.Columns.Add(resetPasswordColumn);

                var deleteColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete"
                };
                accountsDataGrid.Columns.Add(deleteColumn);
            }

            // Clear existing rows
            accountsDataGrid.Rows.Clear();

            // Add rows
            foreach (User employee in employees)
            {
                accountsDataGrid.Rows.Add(employee.GetEmpId(), employee.GetName(), employee.GetPosition(), false, false);
            }
        }

        private List<string> SelectEmployees(string checkBoxColumnName)
        {
            List<string> empIds = new(); // Employees' to select
            foreach (DataGridViewRow row in accountsDataGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[checkBoxColumnName].Value))
                {
                    empIds.Add(row.Cells["EmployeeID"].Value.ToString());
                }
            }
            return empIds;
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<User> results = new();
            string query = SearchTxt.Text.ToLower();
            foreach (DataGridViewRow row in accountsDataGrid.Rows)
            {
                string name = row["EmployeeID"].Value.ToString();
            }
            employees.Clear();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            List<string> empIds = SelectEmployees("ResetPassword"); // Employees to reset passwords on
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset the password of these accounts?",
                "Confirm Accounts to Reset Password",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // TODO:
                DatabaseHelper.ResetUserPasswords(empIds);
                FillDataGridView();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<string> empIds = SelectEmployees("Delete"); // IDs of employee accounts to delete
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete these accounts? This critical action that cannot be undone",
                "Confirm Accounts to Reset Password",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // TODO:
                DatabaseHelper.DeleteUserAccounts(empIds);
                FillDataGridView();
            }
        }
    }
}
