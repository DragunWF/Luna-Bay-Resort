using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubForms
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CheckInNoText.Text))
            {
                MessageBox.Show("Do not leave the check-in text box empty!");
            }
            else
            {

            }
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
