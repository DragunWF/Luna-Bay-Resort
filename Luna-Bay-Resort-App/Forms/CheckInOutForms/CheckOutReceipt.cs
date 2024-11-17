using Luna_Bay_Resort_App.Helpers;

namespace SubForms
{
    public partial class CheckOutReceipt : Form
    {
        private readonly string fullName, checkInDate, checkOutDate, roomType, numOfGuests, roomNo;
        private readonly string receiptNo;
        private readonly int checkOutNo;

        public CheckOutReceipt(string fullName, string checkInDate, string checkOutDate,
            string roomType, string numOfGuests, string roomNo)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.fullName = fullName;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.roomType = roomType;
            this.numOfGuests = numOfGuests;
            this.roomNo = roomNo;

            // Check out details
            checkOutNo = Utils.GenerateCheckInOutNo();
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
            RoomNoText.Text = roomNo;

            // Amount Details

        }
    }
}
