namespace Luna_Bay_Resort_App.Data
{
    internal class Guest
    {
        private string name, email, phone, checkIn, checkOut, status;
        private int guestId, reservationId, checkInId, checkOutId, room, numOfGuest, paymentTypeId;
        private double billAmount, balance;

        //All columns
        public Guest(int guestId, int reservationId, int checkInId, int checkOutId, string name,
            string email, string phone, int room, int numOfGuest, string checkIn, string checkOut,
            string status, double billAmount, double balance, int paymentTypeId)
        {
            this.guestId = guestId;
            this.reservationId = reservationId;
            this.checkInId = checkInId;
            this.checkOutId = checkOutId;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.room = room;
            this.numOfGuest = numOfGuest;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.status = status;
            this.billAmount = billAmount;
            this.balance = balance;
            this.paymentTypeId = paymentTypeId;
        }

        //For reservation receipts
        public Guest(int reservationId, string name,
            string checkIn, string checkOut, int room, int numOfGuest,
            double billAmount, double balance)
        {

            this.reservationId = reservationId;
            this.name = name;
            this.room = room;
            this.numOfGuest = numOfGuest;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.billAmount = billAmount;
            this.balance = balance;
        }

        //For check in receipt
        public Guest(int checkInId, int paymentTypeId, string name, string checkIn,
            string checkOut, int numOfGuest, int room, double billAmount, double balance)
        {
            this.checkInId = checkInId;
            this.paymentTypeId = paymentTypeId;
            this.name = name;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.numOfGuest = numOfGuest;
            this.room = room;
            this.billAmount = billAmount;
            this.balance = balance;

        }

        //For check-out receipt 
        public Guest(int checkOutId, string name, string checkIn, string checkOut,
           int numOfGuest, int room, double billAmount)
        {
            this.checkOutId = checkOutId;
            this.name = name;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.numOfGuest = numOfGuest;
            this.room = room;
            this.billAmount = billAmount;
        }

        public Guest(int reservationId, string name)
        {
            this.reservationId = reservationId;
            this.name = name;
        }
        public Guest(int reservationId, string name, string checkin)
        {
            this.reservationId = reservationId;
            this.name = name;
            this.checkIn= checkin;
        }

        public Guest(string name, int checkInId, string checkout)
        {
            this.name = name;
            this.checkInId = checkInId;
            this.checkOut = checkout;
        }

        public Guest(string name, string checkout, int checkOutId)
        {
            this.name = name;
            this.checkOutId = checkOutId;
            this.checkOut = checkout;
        }

        #region Getter Methods

        public int GetGuestId() => guestId;
        public int GetReservationId() => reservationId;
        public int GetCheckInId() => checkInId;
        public int GetCheckOutId() => checkOutId;
        public string GetName() => name;
        public string GetEmail() => email;
        public string GetPhone() => phone;
        public int GetRoomNo() => room;
        public int GetNumOfGuest() => numOfGuest;
        public string GetCheckIn() => checkIn;
        public string GetCheckOut() => checkOut;
        public string GetStatus() => status;
        public double GetBillAmount() => billAmount;
        public double GetBalance() => balance;
        public int GetPaymentTypeId() => paymentTypeId;

        #endregion
    }
}
