using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms
{
    public partial class OnlinePaymentReference : Form
    {
        public OnlinePaymentReference()
        {
            InitializeComponent();
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty((ReferenceTxt.Text)))
                {
                    MessageBox.Show("Please enter the reference number from your preferred mode of payment");
                }
                else
                {
                    PaymentMethods.paymentreference = ReferenceTxt.Text;
                    this.Close();
                }
            }
            catch (FormatException eee)
            {
                MessageBox.Show("Input Number Only");
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
    }
}
