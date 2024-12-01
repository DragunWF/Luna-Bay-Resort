using Luna_Bay_Resort_App.Data;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class SessionData
    {
        private static User? currentUser;
        private static readonly List<Amenity> amenities = new();
        public static int RoomPax = 0;
        public static int RoomCost = 0;

        public static void LoginUser(User user)
        {
            DatabaseHelper.AddActivity($"{user.GetName()} [{user.GetPosition()}] has logged in!",
                              Utils.GetCurrentDate());
            currentUser = user;
        }

        public static void LogoutUser() { 
            DatabaseHelper.AddActivity($"{currentUser.GetName()} [{currentUser.GetPosition()}] has logged out!",
                                          Utils.GetCurrentDate());
            currentUser = null;
        }

        public static User GetCurrentUser() => currentUser;

        /* 
         * You can't create constructors with List Parameters that inherit the Form class.
         * So as an alternative, I implemented these methods to pass the data from amenities
         * to amenities receipt via this class through static fields and methods
        */

        public static void FillAmenities(List<Amenity> items)
        {
            amenities.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                amenities.Add(items[i]);
            }
        }

        public static List<Amenity> GetAmenities() => amenities;
        public static int GetRoomPax() => RoomPax;
        public static int GetRoomCost() => RoomCost;
    }
}
