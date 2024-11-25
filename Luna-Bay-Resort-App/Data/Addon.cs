namespace Luna_Bay_Resort_App.Data
{
    internal class Addon
    {
        private int Id, price;
        private string addonName, pax, status;

        public Addon(int id, string addonName, string pax, int price, string status)
        {
            this.Id = id;
            this.addonName = addonName;
            this.pax = pax;
            this.price = price;
            this.status = status;
        }

        public Addon(string addonName, int price)
        {
            this.addonName = addonName;
            this.price = price;
        }

        #region Getter Methods

        public int GetAddonId() => Id;
        public string GetAddonName() => addonName;
        public string GetPax() => pax;
        public int GetPrice() => price;
        public string GetStatus() => status;

        #endregion
    }
}

