namespace Luna_Bay_Resort_App.Data
{
    internal class Amenity
    {
        private readonly string name;
        private readonly int quantity;
        private readonly double price;

        public Amenity(string name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        #region Getter Methods

        public string GetName() => name;
        public int GetQuantity() => quantity;
        public double GetPrice() => price;

        #endregion
    }
}
