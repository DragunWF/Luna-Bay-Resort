using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class DatabaseHelper
    {
        public static SqlConnection con = new SqlConnection("Connection Key");

        public static void AddReservation(string name, string email, string phone, string room, int numOfGuest, string checkIn, string checkOut)
        {
            //temporary for testing
            int Receipt = 10;
            int Reservation = 10;

            con.Open();
            SqlCommand add = new SqlCommand("INSERT INTO Guest(Receipt_No, Reservation_ID, Name, Email, Phone, Room, NumofGuest, Check_in, Check_out, Status, Bill_Amount, Balance) Values(@ReceiptNo, @ReservationID, @Name, @Email, @Phone, @Room, @NumofGuest,@CheckIn, @CheckOut, @Status, @BillAmount, @Balance)", con);
            add.Parameters.AddWithValue("@ReceiptNo", Receipt);
            add.Parameters.AddWithValue("@ReservationID", Reservation);
            add.Parameters.AddWithValue("@Name", name);
            add.Parameters.AddWithValue("@Email", email);
            add.Parameters.AddWithValue("@Phone", phone);
            add.Parameters.AddWithValue("@Room", room);
            add.Parameters.AddWithValue("@NumofGuest", numOfGuest);
            add.Parameters.AddWithValue("@CheckIn", DateTime.Parse(checkIn));
            add.Parameters.AddWithValue("@CheckOut", DateTime.Parse(checkOut));
            add.Parameters.AddWithValue("@Status", "Reserved");
            add.Parameters.AddWithValue("@BillAmount", 2000); //placeholder
            add.Parameters.AddWithValue("@Balance", 4000); //placeholder
            add.ExecuteNonQuery();
            con.Close();
            Receipt += 1;
            Reservation += 1;    

        }
    }
}
