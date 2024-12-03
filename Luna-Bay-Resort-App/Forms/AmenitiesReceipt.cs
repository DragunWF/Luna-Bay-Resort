using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;

namespace SubForms
{
    public partial class AmenitiesReceipt : Form
    {
        private double totalPrice = 0;
        private double vat = 0;
        private double subTotalPrice = 0;
        private string receiptNo;

        public AmenitiesReceipt()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            receiptNo = Utils.GenerateReceiptNo().ToString();
            DisplayReceiptData();
            UpdateStock();
            DatabaseHelper.AddRevenue(Utils.GetDateOnly(), totalPrice);
            DatabaseHelper.AddActivity($"Amenities receipt generated: {receiptNo}", Utils.GetCurrentDate());
        }

        private void DisplayReceiptData()
        {
            ReceiptNoText.Text = receiptNo;
            DateTimeText.Text = Utils.GetCurrentDate();

            List<Amenity> items = SessionData.GetAmenities();
            foreach (Amenity amenity in items)
            {
                subTotalPrice += amenity.GetPrice();
                AddItemToListView(amenity.GetName(), amenity.GetQuantity(), amenity.GetPrice());
            }
            vat = subTotalPrice * 0.10; // 10% of total price for tax
            totalPrice = subTotalPrice + vat;

            SubTotalText.Text = Utils.FormatCurrency(subTotalPrice);
            VATText.Text = Utils.FormatCurrency(vat);
            TotalText.Text = Utils.FormatCurrency(totalPrice);
        }

        public void AddItemToListView(string itemName, int quantity, double price)
        {
            // Create a new ListViewItem with the item name as the first column
            ListViewItem item = new ListViewItem(itemName);

            // Add subitems for Qty and Price
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add(Utils.FormatCurrency(price)); // Format price as currency

            // Add the item to the ListView
            ItemsLV.Items.Add(item);
        }

        private void UpdateStock()
        {
            foreach (ListViewItem item in ItemsLV.Items)
            {
                string itemName = item.Text;
                int quantity = int.Parse(item.SubItems[1].Text);

                DatabaseHelper.ReduceStock(itemName, quantity);
            }
        }
    }
}
