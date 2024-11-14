using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using Luna_Bay_Resort_App.Data;
using System.Diagnostics;
using System.Data;

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

        public static void AddReservation(int reservationId, string name, string email, string phone,
            string room, int numOfGuest, string checkIn, string checkOut, double billAmount, double balance)
        {
            string status = "Reserved";
            int roomNo = GetRoomNo(room);

            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                INSERT INTO Guest 
                (Reservation_ID, Name, Email, Phone, Room, NumofGuest, Check_in, Check_out, Status, Bill_Amount, Balance) 
                VALUES 
                (@ReservationID, @Name, @Email, @Phone, @Room, @NumofGuest, @CheckIn, @CheckOut, @Status, @BillAmount, @Balance)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = name;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = phone;
                    cmd.Parameters.Add("@Room", SqlDbType.Int).Value = roomNo;
                    cmd.Parameters.Add("@NumofGuest", SqlDbType.Int).Value = numOfGuest;
                    cmd.Parameters.Add("@CheckIn", SqlDbType.VarChar).Value = checkIn;
                    cmd.Parameters.Add("@CheckOut", SqlDbType.VarChar).Value = checkOut;
                    cmd.Parameters.Add("@Status", SqlDbType.VarChar, 25).Value = status;
                    cmd.Parameters.Add("@BillAmount", SqlDbType.Int).Value = billAmount;
                    cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = balance;

                    cmd.ExecuteNonQuery();
                }
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

        public static int GetRoomNo(string Room)
        {
            int roomNo = -1;
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT DISTINCT Room_ID FROM Accommodation WHERE Name LIKE @RoomType";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@RoomType", Room);

                using (SqlDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        roomNo = Convert.ToInt32(read["Room_ID"]);
                    }
                }
            }
            return roomNo;
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

        //Get Addon List(Name, Price)
        public static List<Addon> GetAddon()
        {
            var addon = new List<Addon>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT DISTINCT Name, Price FROM Addons";

                SqlCommand getaddons = new SqlCommand(query, con);

                using (var reader = getaddons.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string addonName = reader["Name"].ToString();
                        int price = Convert.ToInt32(reader["Price"]);

                        addon.Add(new Addon(addonName, price));
                    }
                }
                con.Close();
            }
            return addon;
        }

        //Get Product List(Name, Price)
        public static List<Product> GetProduct()
        {
            var product = new List<Product>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Name, Price FROM Products";

                SqlCommand getproduct = new SqlCommand(query, con);

                using (var reader = getproduct.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string productname = reader["Name"].ToString();
                        int price = Convert.ToInt32(reader["Price"]);

                        product.Add(new Product(productname, price));
                    }
                }
                con.Close();
            }
            return product;
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
                using (var reader = getrooms.ExecuteReader())
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
                string query = "UPDATE Accommodation SET Room_status = @status WHERE Room_ID = @roomId";

                SqlCommand setroomstatus = new SqlCommand(query, con);
                setroomstatus.Parameters.AddWithValue("@status", roomStatus);
                setroomstatus.Parameters.AddWithValue("@roomId", roomID);
                setroomstatus.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
