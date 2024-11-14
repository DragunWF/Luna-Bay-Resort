﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luna_Bay_Resort_App.Data;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class SessionData
    {
        private static User currentUser;
        private static List<Amenity> amenities = new();

        public static void LoginUser(User user) => currentUser = user;
        public static User GetUser() => currentUser;

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
    }
}
