using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Data
{
    internal class Food
    {
        private int foodId, foodTypeId, price;
        private string foodName, serving;

        public Food(int foodId, int foodType, string foodName, string serving, int price)
        {
            this.foodId = foodId;
            this.foodTypeId = foodType;
            this.foodName = foodName;
            this.serving = serving;
            this.price = price;
        }

        public Food(string foodName, int price)
        {
            this.foodName = foodName;
            this.price = price;
        }

        #region Getter Methods
        public int getFoodId() => foodId;
        public int getFoodType() => foodTypeId;
        public string getFoodName() => foodName;
        public string getServing() => serving;
        public int getPrice() => price;
        #endregion
    }
}
