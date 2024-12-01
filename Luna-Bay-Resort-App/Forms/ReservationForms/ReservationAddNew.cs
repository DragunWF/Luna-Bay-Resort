using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms;
using Luna_Bay_Resort_App.Forms.CheckInOutForms;
using Luna_Bay_Resort_App.Helpers;
using SubForms;

namespace Luna_Bay_Sub_Forms
{
    public partial class ReservationAddNew : Form
    {
        private int PaymentID;
        private double depositAmount;

        public ReservationAddNew()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().Select(r => r.GetName()).ToArray());

            SessionData.RoomPax = 0;
            SessionData.RoomCost = 0;
            PaymentMethods.paymentreference = "";
            PaymentMethods.ifPayed = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = $"{FirstNameText.Text} {LastNameText.Text}";
                string[] inputValues = {
                    FirstNameText.Text,
                    LastNameText.Text,
                    EmailText.Text,
                    ContactNoText.Text,
                    RoomTypeCB.Text,
                    Paxlbl.Text,
                    CheckInPicker.Text,
                    CheckOutPicker.Text,
                    DepositText.Text,
                    TotalAmountText.Text
                };

                double totalAmount = double.Parse(TotalAmountText.Text);
                double remainingBalance = totalAmount - Double.Parse(DepositText.Text);

                if (remainingBalance < 0)
                {
                    MessageBox.Show("Deposit amount cannot be greater than the total amount!");
                }
                else if (!OnlinePaymentCheckBox.Checked && !CardCheckBox.Checked)
                {
                    MessageBox.Show("Please make sure to choose a payment method!");
                }
                else if(PaymentMethods.ifPayed == false)
                {
                    MessageBox.Show("Please enter a Reference Number from your payment method first");
                }
                else if (Utils.IsValidFormData(inputValues, EmailText.Text, ContactNoText.Text) &&
                         Utils.IsValidCheckInOut(CheckInPicker, CheckOutPicker))
                {
                    int reservationNo = Utils.GenerateReservationNo();
                    FormManager.OpenForm<ReservationReceipt>(
                        reservationNo, fullName, CheckInPicker.Text, CheckOutPicker.Text,
                        RoomTypeCB.Text, Paxlbl.Text, totalAmount, depositAmount,
                        remainingBalance
                    );

                    // Database Operations
                    DatabaseHelper.AddRevenue(Utils.GetDateOnly(), totalAmount);
                    DatabaseHelper.AddReservation(
                        reservationNo, fullName, EmailText.Text, ContactNoText.Text, RoomTypeCB.Text,
                        int.Parse(Paxlbl.Text), CheckInPicker.Text, CheckOutPicker.Text,
                        totalAmount, remainingBalance, PaymentID, PaymentMethods.paymentreference
                    );

                    // Textbox Operations
                    Utils.ResetTextBoxes(new TextBox[] {
                        FirstNameText, LastNameText, EmailText, ContactNoText,
                        DepositText, TotalAmountText
                    });
                    Paxlbl.Text = "0"; // Reset Pax Label    
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show(err.Message);
                MessageBox.Show("Please make sure you input valid numbers for the deposit and total amount textboxes!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        // Changes text to reflect selected room name from RoomTypeCB, can change output label in the future
        private void RoomTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            SessionData.RoomPax = DatabaseHelper.GetPax(RoomTypeCB.Text);
            SessionData.RoomCost = DatabaseHelper.GetRoomPrice(RoomTypeCB.Text);
            UpdatePax();
        }

        private void AddPaxbtn_Click(object sender, EventArgs e)
        {
            if (Paxlbl.Text == "0")
            {
                MessageBox.Show("Select a Room first before adding additional Pax");
            }
            else
            {
                FormManager.OpenForm<AddPax>();
            }
        }

        public void UpdatePax()
        {
            if (RoomTypeCB.SelectedItem != null)
            {
                depositAmount = SessionData.GetRoomCost() * .5;
                DepositText.Text = depositAmount.ToString();
                TotalAmountText.Text = SessionData.GetRoomCost().ToString();
                Paxlbl.Text = SessionData.GetRoomPax().ToString();
            }
        }

        // Updates label whenever it regains focus
        protected override void OnActivated(EventArgs e)
        {
            UpdatePax();
        }

        private void OnlinePaymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlinePaymentCheckBox.Checked)
            {
                PaymentID = 2;
                CardCheckBox.Checked = false;
                FormManager.OpenForm<OnlinePaymentReference>();
            }
        }
        private void CardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CardCheckBox.Checked)
            {
                PaymentID = 3;
                OnlinePaymentCheckBox.Checked = false;
                FormManager.OpenForm<CardReference>();
            }
        }

    }
}
