using Luna_Bay_Resort_App;
using Luna_Bay_Resort_App.Helpers;
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
    public partial class CheckIn : Form
    {
        private string paymentMethod;

        public CheckIn()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().ToArray());
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputValues =
                {
                    FirstNameText.Text,
                    LastNameText.Text,
                    EmailText.Text,
                    ContactNoText.Text,
                    CheckInPicker.Text,
                    CheckOutPicker.Text,
                    RoomTypeCB.Text,
                    GuestNumText.Text,
                };
                if (!CashCheckBox.Checked && !OnlinePaymentCheckBox.Checked && !CardCheckBox.Checked)
                {
                    MessageBox.Show("Please make sure to choose a payment method!");
                }
                else if (Utils.IsValidFormData(inputValues, EmailText.Text, ContactNoText.Text))
                {
                    string fullName = $"{FirstNameText.Text} {LastNameText.Text}";
                    // TODO: Add Room Number text field in form to match the receipt's data fields
                    FormManager.OpenForm<CheckInReceipt>(
                        fullName, CheckInPicker.Text, CheckOutPicker.Text,
                        RoomTypeCB.Text, GuestNumText.Text, "1", // Room number is temporary
                        paymentMethod
                    );
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err}");
            }
        }

        #region Checkboxes - Programmed to act like radio buttons

        private void CashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CashCheckBox.Checked)
            {
                paymentMethod = "Cash";
                OnlinePaymentCheckBox.Checked = false;
                CardCheckBox.Checked = false;
            }
        }

        private void OnlinePaymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlinePaymentCheckBox.Checked)
            {
                paymentMethod = "Online Payment";
                CashCheckBox.Checked = false;
                CardCheckBox.Checked = false;
            }
        }

        private void CardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CardCheckBox.Checked)
            {
                paymentMethod = "Card";
                CashCheckBox.Checked = false;
                OnlinePaymentCheckBox.Checked = false;
            }
        }

        #endregion

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // TODO: Implement search functionality
            MessageBox.Show("No function yet. Still in development!");
        }
    }
}
