using System;
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
        public static string Key = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=LunaBayResortDB;Integrated Security=True;TrustServerCertificate=True";

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

                SqlCommand add = new SqlCommand(
                    "INSERT INTO Guest (Receipt_No, Reservation_ID, Name, Email, Phone, Room, NumofGuest, Check_in, Check_out, Status, Bill_Amount, Balance) VALUES (@ReceiptNo, @ReservationID, @Name, @Email, @Phone, @Room, @NumofGuest,@CheckIn, @CheckOut, @Status, @BillAmount, @Balance)", 
                    con
                );
                add.Parameters.AddWithValue("@ReceiptNo", Receipt);
                add.Parameters.AddWithValue("@ReservationID", Reservation);
                add.Parameters.AddWithValue("@Name", name);
                add.Parameters.AddWithValue("@Email", email);
                add.Parameters.AddWithValue("@Phone", phone);
                add.Parameters.AddWithValue("@Room", GetAvailableRoomID(room));
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

        //Retrieve all distinct Available Accomodations
        public static List<Accommodation> GetRoomTypes()
        {
            var roomNames = new List<Accommodation>();
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
                        roomNames.Add(new Accommodation(reader["Name"].ToString()));
                    }
                }
                con.Close();
            }
            return roomNames;
        }

        //Gives available Room_ID based on Name
        public static int GetAvailableRoomID(string RoomName)
        {
            int RoomNum = 0;
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT TOP 1 Room_ID FROM Accommodation WHERE Name LIKE @RoomName AND Room_Status LIKE 'Available'";
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

        //Returns Price based on Room Name
        public static int ReturnRoomPrice(string Room)
        {
            int price = 0;
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT DISTINCT Price FROM Accommodation WHERE Name LIKE @RoomType";
                SqlCommand returnprice = new SqlCommand(query, con);
                returnprice.Parameters.AddWithValue("@RoomType", Room);

                using (SqlDataReader read = returnprice.ExecuteReader())
                {
                    if (read.Read())
                    {
                        price = Convert.ToInt32(read["Price"]);
                    }
                }
            }
            return price;
        }

        //Return Food name and price by FoodType_ID
        public static List<Food> GetFoodbyType(int FoodType)
        {
            var foods = new List<Food>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Distinct Food_Name, Price from Food WHERE FoodType_ID = @FoodId";

                SqlCommand getfoodnames = new SqlCommand(query, con);
                getfoodnames.Parameters.AddWithValue("@FoodId", FoodType);

                using (var reader = getfoodnames.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string foodName = reader["Food_Name"].ToString();
                        int price = Convert.ToInt32(reader["Price"]);

                        foods.Add(new Food(foodName, price));
                    }
                }
                con.Close();
            }
            return foods;
        }

        //Search for Food name and price using FoodName
        public static List<Food> SearchFood(string FoodName)
        {
            var foods = new List<Food>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Food_Name, Price from Food WHERE Food_Name LIKE '%' + @FoodName + '%'";

                SqlCommand getfoodnames = new SqlCommand(query, con);
                getfoodnames.Parameters.AddWithValue("@FoodName", FoodName);

                using (var reader = getfoodnames.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string foodName = reader["Food_Name"].ToString();
                        int price = Convert.ToInt32(reader["Price"]);

                        foods.Add(new Food(foodName, price));
                    }
                }
                con.Close();
            }
            return foods;
        }

        //Return all Available Room_ID & Name
        public static List<Accommodation> GetAvailableRoom(DataGridView availableroomtable)
        {
            var availablerooms = new List<Accommodation>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Room_ID, Name FROM Accommodation WHERE Room_status = 'Available'";

                SqlCommand getrooms = new SqlCommand(query, con);
                using(var reader = getrooms.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int roomId = Convert.ToInt32(reader["Room_ID"]);
                        string roomName = reader["Name"].ToString();

                        availablerooms.Add(new Accommodation(roomId, roomName));
                    }
                }
                con.Close();
            }
            return availablerooms;
        }

        //Return all rooms based by Room Status
        public static List<Accommodation> GetNotAvailableRoom(DataGridView notavailableroomtable, string status)
        {
            var notavailablerooms = new List<Accommodation>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Room_ID, Room_status FROM Accommodation WHERE Room_status = @roomStatus";

                SqlCommand getrooms = new SqlCommand(query, con);
                getrooms.Parameters.AddWithValue("@roomStatus", status);
                using (var reader = getrooms.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int roomId = Convert.ToInt32(reader["Room_ID"]);
                        string roomStatus = reader["Room_status"].ToString();

                        notavailablerooms.Add(new Accommodation(roomId, roomStatus));
                    }
                }
                con.Close();
            }
            return notavailablerooms;
        }

        //Sets roomstatus based on RoomID
        public static void SetRoomStatus(string roomStatus, int roomID)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "Update Accommodation Set Room_status = @status Where Room_ID = @roomId";

                SqlCommand setroomstatus = new SqlCommand(query, con);
                setroomstatus.Parameters.AddWithValue("@status", roomStatus);
                setroomstatus.Parameters.AddWithValue("@roomId", roomID);
                setroomstatus.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
