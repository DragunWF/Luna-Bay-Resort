namespace Luna_Bay_Resort_App.Data
{
    internal class Accommodation
    {
        private int roomId, roomTypeId, price;
        private string name, pax, roomstatus;

        public Accommodation(int roomId, int roomTypeId, string name, string pax, int price, string roomstatus)
        {
            this.roomId = roomId;
            this.roomTypeId = roomTypeId;
            this.name = name;
            this.pax = pax;
            this.price = price;
            this.roomstatus = roomstatus;
        }

        //Room name
        public Accommodation(string name)
        {
            this.name = name;
        }

        //Room price
        public Accommodation(int price)
        {
            this.price = price;
        }

        //Room Availability
        public Accommodation(int roomId, string name)
        {
            this.roomId = roomId;
            this.name = name;
        }

        //Room Cleaning & Repair
        public Accommodation(string roomstatus, int roomId)
        {
            this.roomstatus = roomstatus;
            this.roomId = roomId;
        }




        #region Getter Methods
        public int GetRoomId() => roomId;
        public int GetRoomTypeId() => roomTypeId;
        public string GetName() => name;
        public string GetPax() => pax;
        public int GetPrice() => price;
        public string GetRoomStatus() => roomstatus;
        #endregion
    }
}
