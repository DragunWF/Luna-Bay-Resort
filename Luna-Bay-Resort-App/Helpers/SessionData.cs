using System;
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

        public static void loginUser(User user) => currentUser = user;
        public static User GetUser() => currentUser;
    }
}
