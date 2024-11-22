using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Data
{
    internal class Items
    {
        string Name;
        int price, stock;

        public Items(String name, int stock, int price)
        {
            this.Name = name;
            this.stock = stock;
            this.price = price;
        }

        #region Getter Methods
        public string getName() => Name;
        public int getStock() => stock;
        public int getPrice() => price;
        #endregion
    }
}
