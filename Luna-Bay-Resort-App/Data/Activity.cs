using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Data
{
    internal class Activity
    {
        private readonly int id;
        private readonly string description;
        private readonly string date;

        public Activity(int id, string description, string date)
        {
            this.id = id;
            this.description = description;
            this.date = date;
        }

        public Activity(string description, string date)
        {
            this.description = description;
            this.date = date;
        }

        #region Getter Methods

        public int GetId() => id;
        public string GetDescription() => description;
        public string GetDate() => date;

        #endregion
    }
}
