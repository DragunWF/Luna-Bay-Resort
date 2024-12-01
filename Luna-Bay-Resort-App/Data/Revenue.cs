using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Data
{
    internal class Revenue
    {
        private int id;
        private string date;
        private double revenue;

        public Revenue(int id, string date, double revenue)
        {
            this.id = id;
            this.date = date;
            this.revenue = revenue;
        }

        public Revenue(string date, double amount)
        {
            this.date = date;
            this.revenue = amount;
        }

        #region Getter Methods

        public int GetId() => id;
        public string GetDate() => date;
        public double GetRevenue() => revenue;    

        #endregion
    }
}
