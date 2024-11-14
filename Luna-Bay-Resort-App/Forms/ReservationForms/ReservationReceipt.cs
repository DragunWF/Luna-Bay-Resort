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
        private readonly string fullName, checkInDate, checkOutDate, roomType, numOfGuests;
        private readonly double depositAmount, totalAmount, remainingBalance;
        private readonly string reservationNo, receiptNo;

        public ReservationReceipt(int reservationNo, string fullName, string checkInDate, string checkOutDate, 
            string roomType, string numOfGuests, double totalAmount, double depositAmount, double remainingBalance)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.fullName = fullName;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.roomType = roomType;
            this.numOfGuests = numOfGuests;
            this.totalAmount = totalAmount;
            this.depositAmount = depositAmount;
            this.remainingBalance = remainingBalance;

            // Receipt Data
            receiptNo = Utils.GenerateReceiptNo();
            this.reservationNo = reservationNo.ToString();

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

            // Amount Details
            TotalAmountText.Text = Utils.FormatCurrency(totalAmount);
            DepositAmountText.Text = Utils.FormatCurrency(depositAmount);
            RemainingBalanceText.Text = Utils.FormatCurrency(remainingBalance);
        }
    }
}
