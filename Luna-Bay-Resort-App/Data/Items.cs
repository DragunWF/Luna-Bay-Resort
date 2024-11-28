using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Data
{
    internal class Items
    {
        private string Name;
        private int stock;
        private double price;

        public Items(String name, int stock, double price)
        {
            this.Name = name;
            this.stock = stock;
            this.price = price;
        }

        #region Getter Methods

        public string GetName() => Name;
        public int GetStock() => stock;
        public double GetPrice() => price;

        #endregion
    }
}
