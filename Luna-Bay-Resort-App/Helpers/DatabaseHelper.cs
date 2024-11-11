﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using Luna_Bay_Resort_App.Data;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class DatabaseHelper
    {
        public static string Key = "Data Source=DRAGUNWF\\SQLEXPRESS;Initial Catalog=LunaBayResortDB;Integrated Security=True;TrustServerCertificate=True";

        public static User GetUser(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT * FROM Employees WHERE Name = @Username AND Password = @Password";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User(
                            reader["Emp_ID"].ToString(), reader["Position"].ToString(),
                            reader["Name"].ToString(), int.Parse(reader["Auth_ID"].ToString())
                        );
                    }
                }
                return null;
            }
        }

        public static void AddReservation(string name, string email, string phone, string room, int numOfGuest, string checkIn, string checkOut)
        {
            using (SqlConnection con = new SqlConnection(Key))
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
                add.Parameters.AddWithValue("@Room", GetAvailableRoom(room));
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

        public static List<String> GetRoomTypes()
        {
            var roomNames = new List<string>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT DISTINCT Name FROM Accommodation WHERE Room_status = 'Available';";
                SqlCommand getroomnames = new SqlCommand(query, con);

                //retrieve all Accommodation names
                using (var reader = getroomnames.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roomNames.Add(reader["Name"].ToString());
                    }
                }
                con.Close();
            }
            return roomNames;
        }

        public static int GetAvailableRoom(string RoomName)
        {
            int RoomNum = 0;
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT TOP 1 Room_ID FROM Accomodation WHERE Name LIKE @RoomName";
                SqlCommand getavailableroom = new SqlCommand(query, con);
                getavailableroom.Parameters.AddWithValue("@RoomName", RoomName);

                using (SqlDataReader read = getavailableroom.ExecuteReader())
                {
                    if (read.Read())
                    {
                        RoomNum = Convert.ToInt32(read["Room_ID"]);
                    }
                }
                return RoomNum;
            }
        }
    }
}
