using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class SessionData
    {
        private int currentUserId;

        public void SetUserId(int userId) => currentUserId = userId;
        public int GetUserId() => currentUserId;
    }
}
