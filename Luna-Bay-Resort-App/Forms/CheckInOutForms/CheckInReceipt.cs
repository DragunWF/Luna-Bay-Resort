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
        private string fullName, checkInDate, checkOutDate, roomType, numOfGuests, roomNo;
        private string checkInNo, receiptNo;

        public CheckInReceipt(string fullName, string checkInDate, string checkOutDate, string roomType, string numOfGuests, string roomNo)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.fullName = fullName;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.roomType = roomType;
            this.numOfGuests = numOfGuests;
            this.roomNo = roomNo;

            checkInNo = Utils.GenerateCheckInOutNo();
            receiptNo = Utils.GenerateReceiptNo();

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
