namespace Luna_Bay_Resort_App.Data
{
    internal class Product
    {
        private int product_Id, stock;
        private double price;
        private string name;

        public Product(int product_Id, string name, double price, int stock)
        {
            this.product_Id = product_Id;
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public Product(string name, int stock, double price)
        {
            this.name = name;
            this.stock = stock;
            this.price = price;
        }

        #region Getter Methods

        public int GetProductId() => product_Id;
        public string GetProductName() => name;
        public double GetPrice() => price;
        public int GetStock() => stock;

        #endregion
    }
}

