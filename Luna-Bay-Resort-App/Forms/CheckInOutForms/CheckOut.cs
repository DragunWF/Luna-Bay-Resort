using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;

namespace SubForms
{
    public partial class CheckOut : Form
    {
        private int checkInNo = -1;
        string status = "Cleaning";
        Guest checkin;
        public CheckOut()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CheckInNoText.Text))
                {
                    MessageBox.Show("Do not leave the check-in text box empty!");
                }
                else
                {
                    checkInNo = int.Parse(CheckInNoText.Text);
                    checkin = DatabaseHelper.GetCheckIn(checkInNo);
                    if (checkin != null)
                    {
                        NameText.Text = checkin.GetName();
                        CheckInDate.Text = checkin.GetCheckIn();
                        CheckOutDate.Text = checkin.GetCheckOut();
                        RoomTypeText.Text = DatabaseHelper.GetRoomName(checkin.GetRoomNo());
                        GuestNumText.Text = checkin.GetNumOfGuest().ToString();
                        BillAmountText.Text = checkin.GetBillAmount().ToString();
                        AmountDueText.Text = checkin.GetBalance().ToString();
                    }
                    else
                    {
                        MessageBox.Show("Check in cannot be found! Make sure you input the correct number.");
                    }
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("Please enter a valid check-in nuber!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInNo != -1)
                {
                    if(AmountDueText.Text == "0" || AmountPaidText.Text == AmountDueText.Text)
                    {
                        int generatedCheckOutId = Utils.GenerateCheckInOutNo(); 
                        DatabaseHelper.CheckOutGuest(checkInNo, generatedCheckOutId);
                        DatabaseHelper.SetRoomStatus(status, checkin.GetRoomNo());
                        DatabaseHelper.AddRevenue(Utils.GetDateOnly(), double.Parse(BillAmountText.Text));
                        FormManager.OpenForm<CheckOutReceipt>(
                        generatedCheckOutId, NameText.Text, CheckInDate.Text, CheckOutDate.Text, RoomTypeText.Text, 
                        int.Parse(GuestNumText.Text), checkin.GetRoomNo(), double.Parse(BillAmountText.Text)
                        );
                        ResetTextLabels();
                        ResetTextBoxes();
                        checkInNo = -1;
                    }
                    else
                    {
                        MessageBox.Show("Settle the balance first before checking out");
                    }
                }
                else
                {
                    MessageBox.Show("Make sure to search a check-in number first!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void ResetTextLabels()
        {
            CheckInNoText.Text = "";
            NameText.Text = "-";
            CheckInDate.Text = "-";
            CheckOutDate.Text = "-";
            RoomTypeText.Text = "-";
            GuestNumText.Text = "-";
        }
        private void ResetTextBoxes()
        {
            AmountDueText.Text = "";
            AmountPaidText.Text = "";
            BillAmountText.Text = "";
        }
    }
}
