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

        public static void AddReservation(String Name, String Email, String Phone, String Room, int NumofGuest, String CheckIn, String CheckOut)
        {
            //temporary for testing
            int Receipt = 10;
            int Reservation = 10;

            con.Open();
            SqlCommand add = new SqlCommand("Insert into Guest(Receipt_No, Reservation_ID, Name, Email, Phone, Room, NumofGuest, Check_in, Check_out, Status, Bill_Amount, Balance) Values(@ReceiptNo, @ReservationID, @Name, @Email, @Phone, @Room, @NumofGuest,@CheckIn, @CheckOut, @Status, @BillAmount, @Balance)", con);
            add.Parameters.AddWithValue("@ReceiptNo", Receipt);
            add.Parameters.AddWithValue("@ReservationID", Reservation);
            add.Parameters.AddWithValue("@Name", Name);
            add.Parameters.AddWithValue("@Email", Email);
            add.Parameters.AddWithValue("@Phone", Phone);
            add.Parameters.AddWithValue("@Room", Room);
            add.Parameters.AddWithValue("@NumofGuest", NumofGuest);
            add.Parameters.AddWithValue("@CheckIn", DateTime.Parse(CheckIn));
            add.Parameters.AddWithValue("@CheckOut", DateTime.Parse(CheckOut));
            add.Parameters.AddWithValue("@Status", "Reserved");
            add.Parameters.AddWithValue("@BillAmount", 2000); //placeholder
            add.Parameters.AddWithValue("@Balance", 4000); //placeholder
            add.ExecuteNonQuery();
            con.Close();
            Receipt = +1;
            Reservation = +1;    

        }
    }
}
