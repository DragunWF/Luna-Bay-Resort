﻿using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using Luna_Bay_Resort_App.Data;
using SubForms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class DatabaseHelper
    {
        public static string Key = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=LunaBayResortDB;Integrated Security=True;TrustServerCertificate=True";

        #region User Methods

        public static List<User> GetUsers()
        {
            List<User> users = new();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"
                SELECT E.Emp_ID, P.Name AS Position, P.Auth_ID, E.Name, E.Password
                FROM Employees E
                JOIN Positions P ON E.Auth_ID = P.Auth_ID";
                SqlCommand command = new SqlCommand(query, con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User(
                            reader["Emp_ID"].ToString(), reader["Position"].ToString(),
                            reader["Name"].ToString(), int.Parse(reader["Auth_ID"].ToString())
                        ));
                    }
                }
            }
            return users;
        }

        public static User GetUser(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"
                SELECT E.Emp_ID, P.Name AS Position, P.Auth_ID, E.Name, E.Password
                FROM Employees E
                JOIN Positions P ON E.Auth_ID = P.Auth_ID
                WHERE E.Name = @Username AND E.Password = @Password";

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

        public static void AddUser(string name, string password, int authId)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                INSERT INTO Employees (Name, Password, Auth_ID)
                VALUES (@Name, @Password, @Auth_ID)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = name;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar, 30).Value = password;
                    cmd.Parameters.Add("@Auth_ID", SqlDbType.Int).Value = authId;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ResetUserPassword(List<string> empIds, string newPassword)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                UPDATE Employees
                SET Password = @Password
                WHERE Emp_ID = @EmpID";

                foreach (string empId in empIds)
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = newPassword;
                        cmd.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = empId;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void DeleteUserAccounts(List<string> empIds)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                DELETE FROM Employees
                WHERE Emp_ID = @EmpID";

                foreach (string empId in empIds)
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = empId;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static List<string> GetPositions()
        {
            string query = "SELECT Name FROM Positions";
            List<string> positions = new();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            positions.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
            return positions;
        }

        public static string GetPosition(int authId)
        {
            string query = "SELECT Name FROM Positions WHERE Auth_ID = @AuthID";
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@AuthID", authId);

                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : "Position not found";
            }
        }

        public static int GetAuthId(string position)
        {
            string query = "SELECT Auth_ID FROM Positions WHERE Name = @Position";
            using (SqlConnection con = new SqlConnection(Key))
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Position", position);

                con.Open();
                object result = command.ExecuteScalar();
                return result != null ? (int)result : -1;
            }
        }

        #endregion

        #region Booking Methods

        public static void AddReservation(int reservationId, string name, string email, string phone,
            string room, int numOfGuest, string checkIn, string checkOut, double billAmount, double balance, int paymentType, string paymentReference)
        {
            string status = "Reserved";
            int roomNo = GetRoomNo(room);

            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                INSERT INTO Guest 
                (Reservation_ID, Name, Email, Phone, Room, NumofGuest, Check_in, Check_out, Status, Bill_Amount, Balance, PaymentType_ID, PaymentReference_NO) 
                VALUES 
                (@ReservationID, @Name, @Email, @Phone, @Room, @NumofGuest, @CheckIn, @CheckOut, @Status, @BillAmount, @Balance, @PaymentType, @PaymentReference)";

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
                    cmd.Parameters.Add("@BillAmount", SqlDbType.Float).Value = billAmount;
                    cmd.Parameters.Add("@Balance", SqlDbType.Float).Value = balance;
                    cmd.Parameters.Add("@PaymentType", SqlDbType.Int).Value = paymentType;
                    cmd.Parameters.Add("@PaymentReference", SqlDbType.VarChar, 30).Value = paymentReference;
                    cmd.ExecuteNonQuery();
                }
            }
            DatabaseHelper.SetRoomStatus(status, roomNo);
        }

        public static Guest GetReservation(int reservationId)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
            SELECT Reservation_ID, Name, Email, Phone, Room, 
                   Check_in, Check_out, NumOfGuest, Bill_Amount, Balance
            FROM Guest 
            WHERE Reservation_ID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Guest(
                                reservationId,
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("Check_in")),
                                reader.GetString(reader.GetOrdinal("Check_out")),
                                reader.GetInt32(reader.GetOrdinal("Room")),
                                reader.GetInt32(reader.GetOrdinal("NumofGuest")),
                                reader.GetDouble(reader.GetOrdinal("Bill_Amount")),
                                reader.GetDouble(reader.GetOrdinal("Balance"))
                            );
                        }
                    }
                }
            }
            return null;
        }

        public static void AddCheckinWithCash(int checkinId, string name, string email, string phone,
            int room, int numOfGuest, string checkIn, string checkOut, double billAmount, double balance, int paymentType)
        {
            string status = "Checked In";

            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                INSERT INTO Guest
                (Checkin_ID, Name, Email, Phone, Room, NumofGuest, Check_in, Check_out, Status, Bill_Amount, Balance, PaymentType_ID)
                VALUES
                (@CheckinID, @Name, @Email, @Phone, @Room, @NumofGuest, @CheckIn, @CheckOut, @Status, @BillAmount, @Balance, @PaymentType)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@CheckinID", SqlDbType.Int).Value = checkinId;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = name;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = phone;
                    cmd.Parameters.Add("@Room", SqlDbType.Int).Value = room;
                    cmd.Parameters.Add("@NumofGuest", SqlDbType.Int).Value = numOfGuest;
                    cmd.Parameters.Add("@CheckIn", SqlDbType.VarChar).Value = checkIn;
                    cmd.Parameters.Add("@CheckOut", SqlDbType.VarChar).Value = checkOut;
                    cmd.Parameters.Add("@Status", SqlDbType.VarChar, 25).Value = status;
                    cmd.Parameters.Add("@BillAmount", SqlDbType.Float).Value = billAmount;
                    cmd.Parameters.Add("@Balance", SqlDbType.Float).Value = balance;
                    cmd.Parameters.Add("@PaymentType", SqlDbType.Int).Value = paymentType;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AddCheckinWithReference(int checkinId, string name, string email, string phone,
            int room, int numOfGuest, string checkIn, string checkOut, double billAmount, double balance, int paymentType, string paymentReference)
        {
            string status = "Checked In";

            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                INSERT INTO Guest
                (Checkin_ID, Name, Email, Phone, Room, NumofGuest, Check_in, Check_out, Status, Bill_Amount, Balance, PaymentType_ID, PaymentReference_NO)
                VALUES
                (@CheckinID, @Name, @Email, @Phone, @Room, @NumofGuest, @CheckIn, @CheckOut, @Status, @BillAmount, @Balance, @PaymentType, @PaymentReference)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@CheckinID", SqlDbType.Int).Value = checkinId;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = name;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = phone;
                    cmd.Parameters.Add("@Room", SqlDbType.Int).Value = room;
                    cmd.Parameters.Add("@NumofGuest", SqlDbType.Int).Value = numOfGuest;
                    cmd.Parameters.Add("@CheckIn", SqlDbType.VarChar).Value = checkIn;
                    cmd.Parameters.Add("@CheckOut", SqlDbType.VarChar).Value = checkOut;
                    cmd.Parameters.Add("@Status", SqlDbType.VarChar, 25).Value = status;
                    cmd.Parameters.Add("@BillAmount", SqlDbType.Float).Value = billAmount;
                    cmd.Parameters.Add("@Balance", SqlDbType.Float).Value = balance;
                    cmd.Parameters.Add("@PaymentType", SqlDbType.Int).Value = paymentType;
                    cmd.Parameters.Add("@PaymentReference", SqlDbType.VarChar, 30).Value = paymentReference;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Guest GetCheckIn(int checkInId)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
            SELECT Checkin_ID, Name, Email, Phone, Room, 
                   Check_in, Check_out, NumOfGuest, Bill_Amount, Balance
            FROM Guest 
            WHERE Checkin_ID = @checkInID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@checkInID", SqlDbType.Int).Value = checkInId;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Guest(
                                checkInId,
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("Check_in")),
                                reader.GetString(reader.GetOrdinal("Check_out")),
                                reader.GetInt32(reader.GetOrdinal("Room")),
                                reader.GetInt32(reader.GetOrdinal("NumofGuest")),
                                reader.GetDouble(reader.GetOrdinal("Bill_Amount")),
                                reader.GetDouble(reader.GetOrdinal("Balance"))
                            );
                        }
                    }
                }
            }
            return null;
        }

        public static void CheckInReservations(List<int> reservationIds)
        {
            foreach (int id in reservationIds)
            {
                CheckInReservation(id, Utils.GenerateCheckInOutNo());
            }
        }

        public static void CheckInReservation(int reservationId, int checkInId)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"
                    UPDATE Guest 
                    SET Reservation_ID = NULL, Checkin_ID = @checkInId, Status = 'Checked In' 
                    WHERE Reservation_ID = @reservationId";

                SqlCommand setroomstatus = new SqlCommand(query, con);
                setroomstatus.Parameters.AddWithValue("@checkInId", checkInId);
                setroomstatus.Parameters.AddWithValue("@reservationId", reservationId);
                setroomstatus.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void CheckOutGuest(int checkInId, int checkOutId)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"
                    UPDATE Guest 
                    SET Checkin_ID = NULL, Checkout_ID = @checkOutId, Status = 'Checked Out', Balance = 0 
                    WHERE Checkin_ID = @checkInId";

                SqlCommand setroomstatus = new SqlCommand(query, con);
                setroomstatus.Parameters.AddWithValue("@checkInId", checkInId);
                setroomstatus.Parameters.AddWithValue("@checkOutId", checkOutId);
                setroomstatus.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void UpdateReservationWithAddedPayment(int reservationId, string checkIn, string checkOut, int roomNo,
            int numOfGuest, double billAmount, double balance, int paymentType, string paymentReference)
        {
            string status = "Reserved";
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                UPDATE Guest 
                SET Check_in = @CheckIn, 
                    Check_out = @CheckOut,
                    Room = @Room,
                    NumofGuest = @NumOfGuest, 
                    Bill_Amount = @BillAmount, 
                    Balance = @Balance,
                    PaymentType_ID = @PaymentType,
                    PaymentReference_NO = @PaymentReference
                WHERE Reservation_ID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Set the parameters for the update query
                    cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                    cmd.Parameters.Add("@CheckIn", SqlDbType.VarChar).Value = checkIn;
                    cmd.Parameters.Add("@CheckOut", SqlDbType.VarChar).Value = checkOut;
                    cmd.Parameters.Add("@Room", SqlDbType.Int).Value = roomNo;
                    cmd.Parameters.Add("@NumOfGuest", SqlDbType.Int).Value = numOfGuest;
                    cmd.Parameters.Add("@BillAmount", SqlDbType.Money).Value = billAmount;
                    cmd.Parameters.Add("@Balance", SqlDbType.Money).Value = balance;
                    cmd.Parameters.Add("@PaymentType", SqlDbType.Int).Value = paymentType;
                    cmd.Parameters.Add("@PaymentReference", SqlDbType.VarChar).Value = paymentReference;
                    // Execute the update query
                    cmd.ExecuteNonQuery();
                }
            }
            SetRoomStatus("Reserved", roomNo);
        }

        public static void UpdateReservation(int reservationId, string checkIn, string checkOut, int roomNo,
            int numOfGuest, double billAmount, double balance)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();

                string query = @"
                UPDATE Guest 
                SET Check_in = @CheckIn, 
                    Check_out = @CheckOut,
                    Room = @Room,
                    NumofGuest = @NumOfGuest,
                    Bill_Amount = @BillAmount,
                    Balance = @Balance
                WHERE Reservation_ID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Set the parameters for the update query
                    cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                    cmd.Parameters.Add("@CheckIn", SqlDbType.VarChar).Value = checkIn;
                    cmd.Parameters.Add("@CheckOut", SqlDbType.VarChar).Value = checkOut;
                    cmd.Parameters.Add("@Room", SqlDbType.Int).Value = roomNo;
                    cmd.Parameters.Add("@NumOfGuest", SqlDbType.Int).Value = numOfGuest;
                    cmd.Parameters.Add("@BillAmount", SqlDbType.Money).Value = billAmount;
                    cmd.Parameters.Add("@Balance", SqlDbType.Money).Value = balance;

                    // Execute the update query
                    cmd.ExecuteNonQuery();
                }
            }
            SetRoomStatus("Reserved", roomNo);
        }

        public static List<Guest> GetReservationList(string name, string checkin)
        {
            var reservations = new List<Guest>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"SELECT Reservation_ID, Name, Check_in FROM Guest WHERE Checkin_ID IS NULL 
                                AND Checkout_ID IS NULL 
                                AND Name LIKE '%' + @Name + '%'
                                AND Check_in LIKE '%' + @checkin + '%'";
                
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@checkin", checkin);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int reservationid = Convert.ToInt32(reader["Reservation_ID"]);
                        string reservationname = reader["Name"].ToString();
                        string reservationcheckin = reader["Check_in"].ToString();

                        reservations.Add(new Guest(reservationid, reservationname, reservationcheckin));
                    }
                }
                return reservations;
            }
        }

        public static List<Guest> GetCheckInList(string name, string checkout)
        {
            var checkins = new List<Guest>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"SELECT Checkin_ID, Name, Check_out FROM Guest WHERE Reservation_ID IS NULL AND Checkout_ID IS NULL
                                AND Name LIKE '%' + @Name + '%'
                                AND Check_out LIKE '%' + @checkout + '%'";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@checkout", checkout);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int checkinId = Convert.ToInt32(reader["Checkin_ID"]);
                        string checkinname = reader["Name"].ToString();
                        string checkoutdate = reader["Check_out"].ToString();

                        checkins.Add(new Guest(checkinname, checkinId, checkoutdate));
                    }
                }
                return checkins;
            }
        }

        public static List<Guest> GetCheckOutList(string name, string checkout)
        {
            var checkouts = new List<Guest>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"SELECT Checkout_ID, Name, Check_out FROM Guest WHERE Checkin_ID IS NULL AND Reservation_ID IS NULL
                                AND Name LIKE '%' + @Name + '%'
                                AND Check_out LIKE '%' + @checkout + '%'";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@checkout", checkout);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int checkoutId = Convert.ToInt32(reader["Checkout_ID"]);
                        string checkoutname = reader["Name"].ToString();
                        string checkoutdate = reader["Check_out"].ToString();

                        checkouts.Add(new Guest(checkoutname, checkoutdate, checkoutId));
                    }
                }
                return checkouts;
            }
        }
        #endregion

        #region Room Methods
        // Retrieve all distinct Available Accomodations
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
        public static int GetRoomPrice(string Room)
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

        public static string GetRoomName(int roomNo)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT DISTINCT Name FROM Accommodation WHERE Room_ID = @RoomType";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@RoomType", roomNo);

                using (SqlDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        return read["Name"].ToString();
                    }
                }
            }
            return null;
        }

        public static int GetRoomNo(string Room)
        {
            int roomNo = -1;
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT DISTINCT Room_ID FROM Accommodation WHERE Name LIKE @RoomType AND Room_status = 'Available'";
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

        public static int GetPax(string roomName)
        {
            int pax = 0;
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT DISTINCT Pax FROM Accommodation WHERE Name = @RoomName";

                SqlCommand getpax = new SqlCommand(query, con);
                getpax.Parameters.AddWithValue("@RoomName", roomName);

                using (SqlDataReader read = getpax.ExecuteReader())
                {
                    if (read.Read())
                    {
                        pax = Convert.ToInt32(read["Pax"]);

                    }
                    return pax;
                }
            }
        }

        #endregion

        #region Amenities Methods

        //Return Food name, stock count, and price by FoodType_ID
        public static List<Food> GetFoodbyType(int FoodType)
        {
            var foods = new List<Food>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Distinct Name, Stock, Price from Food WHERE FoodType_ID = @FoodId";

                SqlCommand getfoodnames = new SqlCommand(query, con);
                getfoodnames.Parameters.AddWithValue("@FoodId", FoodType);

                using (var reader = getfoodnames.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string foodName = reader["Name"].ToString();

                        int? stock = reader["Stock"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Stock"]);
                        double price = Convert.ToDouble(reader["Price"]);

                        foods.Add(new Food(foodName, stock, price));
                    }
                }
                con.Close();
            }
            return foods;
        }

        public static List<Items> SearchItem(string itemname)
        {
            var items = new List<Items>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"SELECT Name, Stock, Price from Food WHERE Name LIKE '%' + @Name + '%' 
                                 UNION 
                                 SELECT Name, Stock, Price from Products WHERE Name LIKE '%' + @Name + '%'";

                SqlCommand getitem = new SqlCommand(query, con);
                getitem.Parameters.AddWithValue("@Name", itemname);

                using (var reader = getitem.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        int quantity = Convert.ToInt32(reader["Stock"]);
                        double price = Convert.ToDouble(reader["Price"]);

                        items.Add(new Items(name, quantity, price));
                    }
                }
                con.Close();
            }
            return items;
        }

        public static List<Product> GetProduct()
        {
            var product = new List<Product>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Name, Stock, Price FROM Products";

                SqlCommand getproduct = new SqlCommand(query, con);

                using (var reader = getproduct.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string productname = reader["Name"].ToString();
                        int stock = Convert.ToInt32(reader["Stock"]);
                        double price = Convert.ToDouble(reader["Price"]);

                        product.Add(new Product(productname, stock, price));
                    }
                }
                con.Close();
            }
            return product;
        }

        public static void ReduceStock(string itemname, int quantity)
        {
            var cart = new List<Items>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string queryFood = "SELECT COUNT(*) FROM Food WHERE Name = @ItemName";

                SqlCommand cmdFood = new SqlCommand(queryFood, con);
                cmdFood.Parameters.AddWithValue("@ItemName", itemname);

                int foodCount = Convert.ToInt32(cmdFood.ExecuteScalar());
                //Checks if cart has food items
                if (foodCount > 0)
                {
                    string updateFoodStock = "UPDATE Food SET Stock = Stock - @Quantity WHERE Name = @ItemName";
                    SqlCommand updateFood = new SqlCommand(updateFoodStock, con);
                    updateFood.Parameters.AddWithValue("@ItemName", itemname);
                    updateFood.Parameters.AddWithValue("@Quantity", quantity);

                    updateFood.ExecuteNonQuery();
                }
                else
                {
                    //Checks if cart has product items
                    string queryProduct = "SELECT COUNT(*) FROM Products WHERE Name = @ItemName";
                    SqlCommand cmdProduct = new SqlCommand(queryProduct, con);
                    cmdProduct.Parameters.AddWithValue("@ItemName", itemname);

                    int productCount = Convert.ToInt32(cmdProduct.ExecuteScalar());
                    if (productCount > 0)
                    {
                        string updateProductStock = "UPDATE Products SET Stock = Stock - @Quantity WHERE Name = @ItemName";
                        SqlCommand updateProduct = new SqlCommand(updateProductStock, con);
                        updateProduct.Parameters.AddWithValue("@ItemName", itemname);
                        updateProduct.Parameters.AddWithValue("@Quantity", quantity);

                        updateProduct.ExecuteNonQuery();
                    }
                }
                con.Close();
            }
        }

        #endregion

        #region Stock Methods
        public static int GetOutofStock()
        {
            int stocklevel = 0;

            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"SELECT 
                                (SELECT COUNT(Stock) FROM Food WHERE Stock = 0) 
                                + 
                                (SELECT COUNT(Stock) FROM Products WHERE Stock = 0)";
                SqlCommand command = new SqlCommand(query, con);

                stocklevel = Convert.ToInt32(command.ExecuteScalar());
                con.Close();
            }
            return stocklevel;
        }
        public static int GetLowStock()
        {
            int stocklevel = 0;

            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"SELECT 
                                (SELECT COUNT(Stock) FROM Food WHERE Stock <= 30) 
                                + 
                                (SELECT COUNT(Stock) FROM Products WHERE Stock <= 30)";
                SqlCommand command = new SqlCommand(query, con);

                stocklevel = Convert.ToInt32(command.ExecuteScalar());
                con.Close();
            }
            return stocklevel;
        }
        public static int GetFullStock()
        {
            int stocklevel = 0;

            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"SELECT 
                                (SELECT COUNT(Stock) FROM Food WHERE Stock > 40) 
                                + 
                                (SELECT COUNT(Stock) FROM Products WHERE Stock > 40)";
                SqlCommand command = new SqlCommand(query, con);

                stocklevel = Convert.ToInt32(command.ExecuteScalar());
                con.Close();
            }
            return stocklevel;
        }
        #endregion

        #region Dashboard Methods
        public static List<Guest> GetDashboardReservations(string checkindate)
        {
            var reservations = new List<Guest>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Reservation_ID, Name FROM Guest WHERE Check_In LIKE '%' + @CheckInDate + '%' AND Reservation_ID IS NOT NULL";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CheckInDate", checkindate);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int reservationId = Convert.ToInt32(reader["Reservation_ID"].ToString());
                        string name = reader["Name"].ToString();

                        reservations.Add(new Guest(reservationId, name));
                    }
                }
            }
            return reservations;
        }
        #endregion

        #region Inventory

        public static void AddNewFoodWithStock(int foodType, string name, string serving, double price, int stock)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string getlastFoodId = "SELECT TOP 1 Food_ID FROM Food WHERE FoodType_ID = @foodType ORDER BY Food_ID DESC";
                SqlCommand getlast = new SqlCommand(getlastFoodId, con);
                getlast.Parameters.AddWithValue("@foodType", foodType);
                int latestfoodId = Convert.ToInt32(getlast.ExecuteScalar());

                string query = "INSERT INTO FOOD(Food_ID, FoodType_ID, Name, Serving, Price, Stock) VALUES (@foodId, @foodtype, @name, @serving, @price, @stock)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@foodId", latestfoodId += 1);
                command.Parameters.AddWithValue("@foodtype", foodType);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@serving", serving);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@stock", stock);
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void AddNewFoodMenu(int foodType, string name, string serving, double price)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string getlastFoodId = "SELECT TOP 1 Food_ID FROM Food WHERE FoodType_ID = @foodType ORDER BY Food_ID DESC";
                SqlCommand getlast = new SqlCommand(getlastFoodId, con);
                getlast.Parameters.AddWithValue("@foodType", foodType);
                int latestfoodId = Convert.ToInt32(getlast.ExecuteScalar());

                string query = "INSERT INTO FOOD(Food_ID, FoodType_ID, Name, Serving, Price) VALUES (@foodId, @foodtype, @name, @serving, @price)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@foodId", latestfoodId += 1);
                command.Parameters.AddWithValue("@foodtype", foodType);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@serving", serving);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void AddNewProduct(string name, double price, int stock)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "INSERT INTO Products(Name, Price, Stock) VALUES (@name, @price, @stock)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@stock", stock);
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public static int CheckItemName(string category, string name)
        {
            int duplicate = 0;
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = $"SELECT COUNT(Name) FROM {category} WHERE Name LIKE @Name";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Name", name);
                duplicate = Convert.ToInt32(command.ExecuteScalar());
            }
            return duplicate;
        }

        public static List<Food> GetFoodList()
        {
            var foods = new List<Food>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Name, Price FROM Food";

                SqlCommand getfoods = new SqlCommand(query, con);

                using (var reader = getfoods.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string foodname = reader["Name"].ToString();
                        double price = Convert.ToDouble(reader["Price"]);
                        foods.Add(new Food(foodname, price));
                    }
                }
                con.Close();
            }
            return foods;
        }

        public static List<Food> GetFoodListWithStock()
        {
            var foods = new List<Food>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Name, Stock, Price FROM Food WHERE Stock IS NOT NULL";

                SqlCommand getfoods = new SqlCommand(query, con);

                using (var reader = getfoods.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string foodname = reader["Name"].ToString();
                        int stock = Convert.ToInt32(reader["Stock"]);
                        double price = Convert.ToDouble(reader["Price"]);
                        foods.Add(new Food(foodname, stock, price));
                    }
                }
                con.Close();
            }
            return foods;
        }

        public static void UpdateItemPrice(string category, string newname, string orginalname, double price)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = $"UPDATE {category} SET Name = @name, Price = @price WHERE Name = @originalname";
                SqlCommand updateitem = new SqlCommand(query, con);
                updateitem.Parameters.AddWithValue("@name", newname);
                updateitem.Parameters.AddWithValue("@originalname", orginalname);
                updateitem.Parameters.AddWithValue("@price", price);
                updateitem.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void UpdateItemStock(string name, int stock)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string queryFood = "SELECT COUNT(*) FROM Food WHERE Name = @name";

                SqlCommand cmdFood = new SqlCommand(queryFood, con);
                cmdFood.Parameters.AddWithValue("@name", name);
                int foodCount = Convert.ToInt32(cmdFood.ExecuteScalar());

                if (foodCount > 0)
                {
                    string query = "UPDATE Food SET Stock = Stock + @stock WHERE Name = @name";
                    SqlCommand cmmdFood = new SqlCommand(query, con);
                    cmmdFood.Parameters.AddWithValue("@name", name);
                    cmmdFood.Parameters.AddWithValue("@stock", stock);
                    cmmdFood.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    string queryProduct = "SELECT COUNT(*) FROM Products WHERE Name = @ItemName";
                    SqlCommand cmdProduct = new SqlCommand(queryProduct, con);
                    cmdProduct.Parameters.AddWithValue("@ItemName", name);

                    int productCount = Convert.ToInt32(cmdProduct.ExecuteScalar());
                    if (productCount > 0)
                    {
                        string query = "UPDATE Products SET Stock = Stock + @stock WHERE Name = @name";
                        SqlCommand updateitem = new SqlCommand(query, con);
                        updateitem.Parameters.AddWithValue("@name", name);
                        updateitem.Parameters.AddWithValue("@stock", stock);
                        updateitem.ExecuteNonQuery();
                        con.Close();
                    }
                }
                    
            }
        }

        public static List<Items> SearchItemInventory(string itemname)
        {
            var items = new List<Items>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"SELECT Name, Stock, Price from Food WHERE STOCK IS NOT NULL AND Name LIKE '%' + @Name + '%' 
                                 UNION 
                                 SELECT Name, Stock, Price from Products WHERE Name LIKE '%' + @Name + '%'";

                SqlCommand getitem = new SqlCommand(query, con);
                getitem.Parameters.AddWithValue("@Name", itemname);

                using (var reader = getitem.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        int quantity = Convert.ToInt32(reader["Stock"]);
                        double price = Convert.ToDouble(reader["Price"]);

                        items.Add(new Items(name, quantity, price));
                    }
                }
                con.Close();
            }
            return items;
        }
        #endregion

        #region Activities

        public static List<Activity> GetActivities()
        {
            List<Activity> activities = new List<Activity>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = $"SELECT Description, Date FROM Activities";
                SqlCommand command = new SqlCommand(query, con);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        activities.Add(new Activity(reader["Description"].ToString(),
                                                    reader["Date"].ToString()));
                    }
                }
            }
            return activities;
        }

        public static void AddActivity(string description, string date)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = @"
                INSERT INTO Activities (Description, Date)
                VALUES (@Description, @Date)";

                SqlCommand command = new SqlCommand(query, con);
                User currentUser = SessionData.GetCurrentUser();
                string id = currentUser != null ? currentUser.GetEmpId() : "None";

                command.Parameters.AddWithValue("@Description", $"EMP_ID ({id}): {description}");
                command.Parameters.AddWithValue("@Date", date);
                command.ExecuteNonQuery();
            }
        }

        public static void ClearActivities()
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "DELETE FROM Activities";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region Revenue
        // USE Utils.GetDateOnly
        public static List<Revenue> GetRevenue()
        {
            List<Revenue> revenue = new List<Revenue>();
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT Date, Revenue FROM Revenue";
                SqlCommand command = new SqlCommand(query, con);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        revenue.Add(new Revenue(
                            reader["Date"].ToString(),
                            double.Parse(reader["Revenue"].ToString()
                        )));
                    }
                }
            }
            return revenue;
        }

        public static void AddRevenue(string date, double revenue)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "SELECT COUNT(Date) FROM Revenue WHERE Date = @Date";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Date", date);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    string updatequery = "UPDATE Revenue Set Revenue = Revenue + @revenue WHERE Date = @date";
                    SqlCommand update = new SqlCommand(updatequery, con);
                    update.Parameters.AddWithValue("@revenue", revenue);
                    update.Parameters.AddWithValue("@date", date);
                    update.ExecuteNonQuery();
                }
                else
                {
                    string add = "INSERT INTO Revenue(Date, Revenue) Values (@date, @revenue)";

                    SqlCommand addDate = new SqlCommand(add, con);
                    addDate.Parameters.AddWithValue("@date", date);
                    addDate.Parameters.AddWithValue("@revenue", revenue);
                    addDate.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        #endregion

        #region Misc

        public static void AddWalkIn(string name, int numofperson, string duration, string date, int total, int paymentId, string paymentreference)
        {
            using (SqlConnection con = new SqlConnection(Key))
            {
                con.Open();
                string query = "INSERT INTO WalkIn(Name, NumOfPerson, Duration, Date, Total, PaymentType_ID, PaymentReference_NO) " +
                "VALUES (@name, @numofperson, @duration, @date, @total, @paymentId, @paymentreference)";

                SqlCommand comm = new SqlCommand(query, con);
                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@numofperson", numofperson);
                comm.Parameters.AddWithValue("@duration", duration);
                comm.Parameters.AddWithValue("@date", date);
                comm.Parameters.AddWithValue("@total", total);
                comm.Parameters.AddWithValue("@paymentId", paymentId);
                comm.Parameters.AddWithValue("@paymentreference", paymentreference);
                comm.ExecuteNonQuery();
                con.Close();
            }
        }

        #endregion
    }
}
