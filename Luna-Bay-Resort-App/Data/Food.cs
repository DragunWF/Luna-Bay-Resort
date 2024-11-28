namespace Luna_Bay_Resort_App.Data
{
    internal class Food
    {
        private int foodId, foodTypeId, stock;
        private double price;
        private string foodName, serving;

        public Food(int foodId, int foodType, string foodName, string serving, double price)
        {
            this.foodId = foodId;
            this.foodTypeId = foodType;
            this.foodName = foodName;
            this.serving = serving;
            this.price = price;
        }

        public Food(string foodName, int stock, double price)
        {
            this.foodName = foodName;
            this.stock = stock;
            this.price = price;
        }
        public Food(string foodName, double price)
        {
            this.foodName = foodName;
            this.price = price;
        }

        #region Getter Methods
        public int GetFoodId() => foodId;
        public int GetFoodType() => foodTypeId;
        public string GetFoodName() => foodName;
        public string GetServing() => serving;
        public int GetStock() => stock;
        public double GetPrice() => price;
        #endregion
    }
}
