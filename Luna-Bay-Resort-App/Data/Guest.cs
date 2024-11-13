using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Data
{
    internal class Guest
    {
        private string name, email, phone, checkIn, checkOut, status;
        private int guestId, reservationId, checkInId, checkOutId, room, numOfGuest, billAmount, balance, paymentTypeId;

        //All columns
        public Guest(int guestId, int reservationId, int checkInId, int checkOutId, string name, 
            string email, string phone, int room, int numOfGuest, string checkIn, string checkOut, 
            string status, int billAmount, int balance, int paymentTypeId)
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
            int billAmount, int balance)
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
            string checkOut, int numOfGuest, int room, int billAmount, int balance)
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
           int numOfGuest, int room, int billAmount)
        {
            this.checkOutId = checkOutId;
            this.name = name;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.numOfGuest = numOfGuest;
            this.room = room;
            this.billAmount = billAmount;
        }
        #region Getter Methods

        public int getGuestId() => guestId;
        public int getReservationId() => reservationId;
        public int getCheckInId() => checkInId;
        public int getCheckOutId() => checkOutId;
        public string getName() => name;
        public string getEmail() => email;
        public string getPhone() => phone;
        public int getRoom() => room;
        public int getNumOfGuest() => numOfGuest;
        public string getCheckIn() => checkIn;
        public string getCheckOut() => checkOut;
        public string getStatus() => status;
        public int getBillAmount() => billAmount;
        public int getBalance() => balance;
        public int getPaymentTypeId() => paymentTypeId;

        #endregion
    }
}
