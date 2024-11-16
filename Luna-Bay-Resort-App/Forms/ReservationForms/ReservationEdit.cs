using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms;
using Luna_Bay_Resort_App.Helpers;
using System.Data;
using System.Globalization;

namespace SubForms
{
    public partial class ReservationEdit : Form
    {
        private int reservationNo = -1;

        public ReservationEdit()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().Select(r => r.GetName()).ToArray());
        }

        public ReservationEdit(int reservationNo) : this()
        {
            this.reservationNo = reservationNo;
            ReservationNoText.Text = reservationNo.ToString();
            SelectBtn_Click(this, EventArgs.Empty);
        }

        // Changes text to reflect selected room name from RoomTypeCB
        private void RoomTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            Paxlbl.Text = DatabaseHelper.GetPax(RoomTypeCB.Text).ToString();
            TotalAmountText.Text = DatabaseHelper.GetRoomPrice(RoomTypeCB.Text).ToString();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            const string dateFormat = "M/dd/yyyy hh:mm";
            try
            {
                reservationNo = int.Parse(ReservationNoText.Text);
                Guest reservation = DatabaseHelper.GetReservation(reservationNo);
                if (reservation != null)
                {
                    CheckInPicker.Value = DateTime.ParseExact(reservation.GetCheckIn(), dateFormat, CultureInfo.InvariantCulture);
                    CheckOutPicker.Value = DateTime.ParseExact(reservation.GetCheckOut(), dateFormat, CultureInfo.InvariantCulture);
                    RoomTypeCB.Text = DatabaseHelper.GetRoomName(reservation.GetRoomNo());
                    Paxlbl.Text = reservation.GetNumOfGuest().ToString();
                    DepositText.Text = reservation.GetBillAmount().ToString();
                    TotalAmountText.Text = reservation.GetBalance().ToString();
                }
                else
                {
                    MessageBox.Show("Reservation cannot be found! Make sure you type in the correct reservation number.");
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("Please make sure to input a valid reservation number!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputValues = {
                    RoomTypeCB.Text,
                    Paxlbl.Text,
                    DepositText.Text,
                    TotalAmountText.Text,
                };
                if (reservationNo == -1)
                {
                    MessageBox.Show("Please make sure to select a reservation first!");
                }
                else if (Utils.IsTextBoxesNotEmpty(inputValues) &&
                         Utils.IsValidCheckInOut(CheckInPicker, CheckOutPicker))
                {
                    DatabaseHelper.UpdateReservation(
                        reservationNo,
                        CheckInPicker.Text.ToString(),
                        CheckOutPicker.Text.ToString(),
                        DatabaseHelper.GetRoomNo(RoomTypeCB.Text),
                        int.Parse(Paxlbl.Text),
                        double.Parse(DepositText.Text),
                        double.Parse(TotalAmountText.Text)
                    );
                    MessageBox.Show($"Reservation {reservationNo} has been successfully edited!");
                    reservationNo = -1;
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("Please make sure to input a valid deposit and payment amount!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void AddPaxbtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<AddPax>();
        }
    }
}
