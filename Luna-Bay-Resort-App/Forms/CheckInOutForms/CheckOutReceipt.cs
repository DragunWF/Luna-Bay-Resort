using Luna_Bay_Resort_App.Helpers;

namespace SubForms
{
    public partial class CheckOutReceipt : Form
    {
        private readonly string fullName, checkInDate, checkOutDate, roomType;
        private readonly string receiptNo;
        private readonly int checkOutNo, numOfGuests, roomNo, amountPaid;

        public CheckOutReceipt(int checkoutNo, string fullName, string checkInDate, string checkOutDate,
            string roomType, int numOfGuests, int roomNo, int amountPaid)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.checkOutNo = checkoutNo;
            this.fullName = fullName;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.roomType = roomType;
            this.numOfGuests = numOfGuests;
            this.roomNo = roomNo;
            this.amountPaid = amountPaid;

            // Check out details
            receiptNo = Utils.GenerateReceiptNo();

            // Outputs receipt data to the text labels
            DisplayReceiptData();
        }

        private void DisplayReceiptData()
        {
            // Receipt Data
            CheckOutNoText.Text = checkOutNo.ToString();
            ReceiptNoText.Text = receiptNo;
            DateTimeText.Text = Utils.GetCurrentDate();

            // Check Out Details
            NameText.Text = fullName;
            CheckInDateText.Text = checkInDate;
            CheckOutDateText.Text = checkOutDate;
            RoomTypeText.Text = roomType;
            RoomNoText.Text = roomNo.ToString();

            // Amount Details
            AmountPaidText.Text = Utils.FormatCurrency(amountPaid);
        }
    }
}
