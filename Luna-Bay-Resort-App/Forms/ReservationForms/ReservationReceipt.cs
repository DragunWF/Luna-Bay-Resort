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
    public partial class ReservationReceipt : Form
    {
        private string fullName, checkInDate, checkOutDate, roomType, numOfGuests;
        private string reservationNo, receiptNo;

        public ReservationReceipt(string fullName, string checkInDate, string checkOutDate, string roomType, string numOfGuests)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.fullName = fullName;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.roomType = roomType;
            this.numOfGuests = numOfGuests;

            // Receipt Data
            receiptNo = Utils.GenerateReceiptId();
            reservationNo = Utils.GenerateReservationNo();

            // Displays receipt data to the text labels
            DisplayReceiptData();
        }

        private void DisplayReceiptData()
        {
            // Receipt Details
            ReservationNoText.Text = reservationNo;
            ReceiptNoText.Text = receiptNo;
            DateTimeText.Text = Utils.GetCurrentDate();

            // Reservation Details
            FullNameText.Text = fullName;
            CheckInDateText.Text = checkInDate;
            CheckOutDateText.Text = checkOutDate;
            RoomTypeText.Text = roomType;
            NoOfGuestText.Text = numOfGuests;
        }
    }
}
