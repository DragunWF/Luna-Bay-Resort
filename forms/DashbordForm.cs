using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luna_Bay_Resort.UserControl;



namespace Luna_Bay_Resort.forms
{
    public partial class DashbordForm : Form
    {
        public DashbordForm()
        {
            InitializeComponent();
        }
        private void LoadUserControl(System.Windows.Forms.UserControl userControl)
        {
            // Clear any existing controls in the panel
            userControlPanel.Controls.Clear();
            // Dock the user control to fill the panel
            userControl.Dock = DockStyle.Fill;
            // Add the new user control to the panel
            userControlPanel.Controls.Add(userControl);
        }

        private void DashbordForm_Load(object sender, EventArgs e)
        {

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BookingControl());
        }

        private void posBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new PosControl());
        }

        private void maintenanceBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MaintenaceControl());
        }

        private void financialBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FinancialControl());
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new EmployeeControl());
        }
    }
}
