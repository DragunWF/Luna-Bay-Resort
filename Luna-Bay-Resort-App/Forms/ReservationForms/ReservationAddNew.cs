using Luna_Bay_Resort_App.Forms;
using Luna_Bay_Resort_App.Helpers;
using SubForms;

namespace Luna_Bay_Sub_Forms
{
    public partial class ReservationAddNew : Form
    {
        public ReservationAddNew()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().Select(r => r.GetName()).ToArray());
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
                double depositAmount = double.Parse(DepositText.Text);
                double remainingBalance = totalAmount - depositAmount;

                if (remainingBalance < 0)
                {
                    MessageBox.Show("Deposit amount cannot be greater than the total amount!");
                }
                else if (Utils.IsValidFormData(inputValues, EmailText.Text, ContactNoText.Text) &&
                         Utils.IsValidCheckInOut(CheckInPicker, CheckOutPicker))
                {
                    // TODO: Uncomment database helper in the future after testing
                    // DatabaseHelper.AddReservation(
                    //     fullName,
                    //     EmailText.Text,
                    //     ContactNoText.Text,
                    //     RoomTypeCB.Text,
                    //     int.Parse(Paxlbl.Text),
                    //     CheckInPicker.Text,
                    //     CheckOutPicker.Text
                    // );
                    int reservationNo = Utils.GenerateReservationNo();
                    FormManager.OpenForm<ReservationReceipt>(
                        reservationNo, fullName, CheckInPicker.Text, CheckOutPicker.Text,
                        RoomTypeCB.Text, Paxlbl.Text, totalAmount, depositAmount,
                        remainingBalance
                    );
                    DatabaseHelper.AddReservation(
                        reservationNo, fullName, EmailText.Text, ContactNoText.Text, RoomTypeCB.Text,
                        int.Parse(Paxlbl.Text), CheckInPicker.Text, CheckOutPicker.Text,
                        depositAmount, remainingBalance
                    );
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
            Paxlbl.Text = DatabaseHelper.GetPax(RoomTypeCB.Text).ToString();
            DepositText.Text = DatabaseHelper.GetRoomPrice(RoomTypeCB.Text).ToString();
        }

        private void AddPaxbtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<AddPax>();
        }
    }
}
