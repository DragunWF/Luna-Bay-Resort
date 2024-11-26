using System.Globalization;
using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms;
using Luna_Bay_Resort_App.Helpers;

namespace SubForms
{
    public partial class ReservationEdit : Form
    {
        private int reservationNo = -1;
        Guest reservation;
        int newroomnum;

        public ReservationEdit()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().Select(r => r.GetName()).ToArray());

            SessionData.RoomPax = 0;
            SessionData.RoomCost = 0;
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
            SessionData.RoomPax = DatabaseHelper.GetPax(RoomTypeCB.Text);
            SessionData.RoomCost = DatabaseHelper.GetRoomPrice(RoomTypeCB.Text);
            UpdatePax();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            const string dateFormat = "M/dd/yyyy hh:mm";
            try
            {
                reservationNo = int.Parse(ReservationNoText.Text);
                reservation = DatabaseHelper.GetReservation(reservationNo);
                if (reservation != null)
                {
                    CheckInPicker.Value = DateTime.ParseExact(reservation.GetCheckIn(), dateFormat, CultureInfo.InvariantCulture);
                    CheckOutPicker.Value = DateTime.ParseExact(reservation.GetCheckOut(), dateFormat,CultureInfo.InvariantCulture);
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
                    string status = "Available";
                    DatabaseHelper.SetRoomStatus(status, reservation.GetRoomNo());
                    newroomnum = DatabaseHelper.GetRoomNo(RoomTypeCB.Text);
                    DatabaseHelper.UpdateReservation(
                        reservationNo,
                        CheckInPicker.Text.ToString(),
                        CheckOutPicker.Text.ToString(),
                        newroomnum,
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
                Paxlbl.Text = SessionData.GetRoomPax().ToString();
                TotalAmountText.Text = SessionData.GetRoomCost().ToString();
            }
        }

        //Updates label whenever it regains focus
        protected override void OnActivated(EventArgs e)
        {
            UpdatePax();
        }
    }
}
