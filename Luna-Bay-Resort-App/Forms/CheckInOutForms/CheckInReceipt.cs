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
    public partial class CheckInReceipt : Form
    {
        private readonly string fullName, checkInDate, checkOutDate, roomType, numOfGuests, roomNo;
        private readonly string checkInNo, receiptNo;

        public CheckInReceipt(string fullName, string checkInDate, string checkOutDate, 
            string roomType, string numOfGuests, string roomNo, string paymentMethod)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.fullName = fullName;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.roomType = roomType;
            this.numOfGuests = numOfGuests;
            this.roomNo = roomNo;

            // Receipt data
            checkInNo = Utils.GenerateCheckInOutNo();
            receiptNo = Utils.GenerateReceiptNo();

            // Displays the data to the text labels
            DisplayReceiptData();
        }

        public void DisplayReceiptData()
        {
            // Receipt Details
            CheckInNoText.Text = checkInNo;
            ReceiptNoText.Text = receiptNo;
            DateTimeText.Text = Utils.GetCurrentDate();

            // Check In Details
            NameText.Text = fullName;
            CheckInDateText.Text = checkInDate;
            CheckOutDateText.Text = checkOutDate;
            RoomTypeText.Text = roomType;
            NoOfGuestText.Text = numOfGuests;
            RoomNoText.Text = roomNo;

            // TODO: Amount Details
        }
    }
}
