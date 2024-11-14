using Luna_Bay_Resort_App.Data;
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

        // Changes text to reflect selected room name from RoomTypeCB
        private void RoomTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            TotalAmountText.Text = DatabaseHelper.GetRoomPrice(RoomTypeCB.Text).ToString();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                reservationNo = int.Parse(ReservationNoText.Text);
                Guest reservation = DatabaseHelper.GetReservation(reservationNo);
                if (reservation != null)
                {
                    CheckInPicker.Value = DateTime.ParseExact(reservation.GetCheckIn(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                    CheckOutPicker.Value = DateTime.ParseExact(reservation.GetCheckOut(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                    RoomTypeCB.Text = DatabaseHelper.GetRoomName(reservation.GetRoomNo());
                    GuestNumText.Text = reservation.GetNumOfGuest().ToString();
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
            if (reservationNo != -1)
            {
                // TODO: Call DatabaseHelper here to change the reservation
                reservationNo = -1;
            }
            else
            {
                MessageBox.Show("Please make sure to select a reservation first!");
            }
        }
    }
}
