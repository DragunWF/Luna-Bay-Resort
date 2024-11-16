using Luna_Bay_Resort_App.Forms;
using Luna_Bay_Resort_App.Forms.CheckInOutForms;
using Luna_Bay_Resort_App.Helpers;
using MainForms;
using System.Data;

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
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().Select(r => r.GetName()).ToArray());
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
                    Paxlbl.Text,
                    TotalPaymentAmountText.Text,
                    TotalBillAmountText.Text
                };
                double paymentAmount = double.Parse(TotalPaymentAmountText.Text);
                double billAmount = double.Parse(TotalBillAmountText.Text);
                double amountDue = billAmount - paymentAmount;
                if (amountDue < 0)
                {
                    amountDue = 0;
                }
                if (paymentAmount > billAmount)
                {
                    paymentAmount = billAmount;
                    TotalPaymentAmountText.Text = paymentAmount.ToString();
                    MessageBox.Show("Payment amount has been set to the exact bill amount to prevent overpayment");
                }
                
                if (paymentAmount < 0 || billAmount < 0)
                {
                    MessageBox.Show("Total amount and the bill amount cannot be negative!");
                }
                else if (!CashCheckBox.Checked && !OnlinePaymentCheckBox.Checked && !CardCheckBox.Checked)
                {
                    MessageBox.Show("Please make sure to choose a payment method!");
                }
                else if (Utils.IsValidFormData(inputValues, EmailText.Text, ContactNoText.Text) &&
                         Utils.IsValidCheckInOut(CheckInPicker, CheckOutPicker))
                {
                    string fullName = $"{FirstNameText.Text} {LastNameText.Text}";
                    FormManager.OpenForm<CheckInReceipt>(
                        fullName, CheckInPicker.Text, CheckOutPicker.Text,
                        RoomTypeCB.Text, Paxlbl.Text, DatabaseHelper.GetRoomNo(RoomTypeCB.Text).ToString(),
                        paymentMethod, paymentAmount, billAmount, amountDue
                    );
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("Please make sure to input a valid number for the total amount");
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

                FormManager.OpenForm<OnlinePaymentReference>();
            }
        }

        private void CardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CardCheckBox.Checked)
            {
                paymentMethod = "Debit/Credit Card";
                CashCheckBox.Checked = false;
                OnlinePaymentCheckBox.Checked = false;

                FormManager.OpenForm<CardReference>();
            }
        }

        #endregion

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // TODO: Implement search functionality
            MessageBox.Show("No function yet. Still in development!");
        }

        // Changes text to reflect selected room name from RoomTypeCB
        private void RoomTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            Paxlbl.Text = DatabaseHelper.GetPax(RoomTypeCB.Text).ToString();
            TotalBillAmountText.Text = DatabaseHelper.GetRoomPrice(RoomTypeCB.Text).ToString();
        }
    }
}
