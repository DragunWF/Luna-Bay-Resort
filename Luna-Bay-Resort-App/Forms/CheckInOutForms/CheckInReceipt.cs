using Luna_Bay_Resort_App.Helpers;

namespace SubForms
{
    public partial class CheckInReceipt : Form
    {
        private readonly string fullName, checkInDate, checkOutDate, roomType, numOfGuests, roomNo, paymentMethod;
        private readonly double paymentAmount, billAmount, amountDue;
        private readonly string receiptNo;
        private readonly int checkInNo;

        public CheckInReceipt(int checkinNo, string fullName, string checkInDate, string checkOutDate,
            string roomType, string numOfGuests, string roomNo, string paymentMethod,
            double paymentAmount, double billAmount, double amountDue)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.checkInNo = checkinNo;
            this.fullName = fullName;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.roomType = roomType;
            this.numOfGuests = numOfGuests;
            this.roomNo = roomNo;
            this.paymentMethod = paymentMethod;
            this.paymentAmount = paymentAmount;
            this.billAmount = billAmount;
            this.amountDue = amountDue;

            // Receipt data
            receiptNo = Utils.GenerateReceiptNo();

            // Displays the data to the text labels
            DisplayReceiptData();

            DatabaseHelper.AddActivity($"Generated Check-in ID: {checkInNo}", Utils.GetCurrentDate());
        }

        public void DisplayReceiptData()
        {
            // Receipt Details
            CheckInNoText.Text = checkInNo.ToString();
            ReceiptNoText.Text = receiptNo;
            PaymentMethodText.Text = paymentMethod;
            DateTimeText.Text = Utils.GetCurrentDate();

            // Check In Details
            NameText.Text = fullName;
            CheckInDateText.Text = checkInDate;
            CheckOutDateText.Text = checkOutDate;
            RoomTypeText.Text = roomType;
            NoOfGuestText.Text = numOfGuests;
            RoomNoText.Text = roomNo;

            // Amount Details
            AmountPaidText.Text = Utils.FormatCurrency(paymentAmount);
            BillAmountText.Text = Utils.FormatCurrency(billAmount);
            AmountDueText.Text = Utils.FormatCurrency(amountDue);
        }
    }
}
