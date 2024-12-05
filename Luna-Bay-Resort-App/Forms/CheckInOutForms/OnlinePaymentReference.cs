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
        private const int characterLimit = 40;

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
                else if (ReferenceTxt.Text.Length > characterLimit)
                {
                    MessageBox.Show($"Online payment reference ID cannot be greater than {characterLimit} characters!");
                }
                else
                {
                    PaymentMethods.paymentreference = ReferenceTxt.Text;
                    PaymentMethods.ifPayed = true;
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
