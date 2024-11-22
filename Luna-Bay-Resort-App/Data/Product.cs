namespace Luna_Bay_Resort_App.Data
{
    internal class Product
    {
        private int product_Id, price, stock;
        private string name;

        public Product(int product_Id, string name, int price, int stock)
        {
            this.product_Id = product_Id;
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public Product(string name, int stock, int price)
        {
            this.name = name;
            this.stock = stock;
            this.price = price;
        }

        #region Getter Methods
        public int getProductId() => product_Id;
        public string getProductName() => name;
        public int getPrice() => price;
        public int getStock() => stock;
        #endregion
    }
}

