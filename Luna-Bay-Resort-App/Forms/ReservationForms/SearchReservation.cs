using Luna_Bay_Resort_App.Data;
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
    public partial class SearchReservation : Form
    {
        private int reservationNo = -1;
        private int generatedCheckInId;

        public SearchReservation()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                reservationNo = int.Parse(ReservationNoText.Text);
                Guest reservation = DatabaseHelper.GetReservation(reservationNo);
                if (reservation != null)
                {
                    FullNameText.Text = reservation.GetName();
                    CheckInDateText.Text = reservation.GetCheckIn();
                    CheckOutDateText.Text = reservation.GetCheckOut();
                    RoomTypeText.Text = DatabaseHelper.GetRoomName(reservation.GetRoomNo());
                    NoOfGuestText.Text = reservation.GetNumOfGuest().ToString();
                }
                else
                {
                    MessageBox.Show("Reservation cannot be found! Make sure you input the correct number.");
                }

            }
            catch (FormatException err)
            {
                MessageBox.Show("Make you input a valid reservation number!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void CheckInBtn_Click(object sender, EventArgs e)
        {
            if (reservationNo != -1)
            {
                generatedCheckInId = Utils.GenerateCheckInOutNo();
                MessageBox.Show($"Reservation {reservationNo} has been checked in! Generated check-in ID: {generatedCheckInId}");
                DatabaseHelper.CheckInReservation(reservationNo, generatedCheckInId);
                ResetTextLabels();
                reservationNo = -1;
            }
            else
            {
                MessageBox.Show("Please search a reservation with a reservation number first before checking in");
            }
        }

        private void ResetTextLabels()
        {
            ReservationNoText.Text = "";
            FullNameText.Text = "-";
            CheckInDateText.Text = "-";
            CheckOutDateText.Text = "-";
            RoomTypeText.Text = "-";
            NoOfGuestText.Text = "-";
        }
    }
}
