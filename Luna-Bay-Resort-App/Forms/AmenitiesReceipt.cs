﻿using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;

namespace SubForms
{
    public partial class AmenitiesReceipt : Form
    {
        private double totalPrice = 0;
        private double vat = 0;
        private double subTotalPrice = 0;

        public AmenitiesReceipt()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            DisplayReceiptData();
        }

        private void DisplayReceiptData()
        {
            ReceiptNoText.Text = Utils.GenerateReceiptNo();
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
    }
}
