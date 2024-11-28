using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using System;

namespace Luna_Bay_Resort_App.Forms.InventoryForms
{
    public partial class EditItem : Form
    {
        private object selectedItem;
        private string selectedItemName;
        public EditItem()
        {
            InitializeComponent();
            ItemNamecb.Enabled = false;
        }

        private void Categorycb_SelectedValueChanged(object sender, EventArgs e)
        {
            ItemNamecb.Enabled = true;
            ItemNamecb.Text = "";
            ItemNamecb.Items.Clear();
            Pricetxt.Clear();

            if (Categorycb.Text == "Products")
            {
                var productList = DatabaseHelper.GetProduct();
                foreach (var product in productList)
                {
                    ItemNamecb.Items.Add(product.GetProductName());
                }
            }
            else if (Categorycb.Text == "Food")
            {
                var foodList = DatabaseHelper.GetFoodList();
                foreach (var food in foodList)
                {
                    ItemNamecb.Items.Add(food.GetFoodName());
                }
            }
        }

        private void ItemNamecb_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedItemName = ItemNamecb.Text;

            switch (Categorycb.Text)
            {
                case "Products":
                    selectedItem = DatabaseHelper.GetProduct().First(product => product.GetProductName() == selectedItemName);
                    if (selectedItem != null)
                    {
                        var product = (Product)selectedItem;
                        Pricetxt.Text = product.GetPrice().ToString();
                    }
                    break;
                case "Food":
                    selectedItem = DatabaseHelper.GetFoodList().First(food => food.GetFoodName() == selectedItemName);
                    if (selectedItem != null)
                    {
                        var food = (Food)selectedItem;
                        Pricetxt.Text = food.GetPrice().ToString();
                    }
                    break;
            }
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Categorycb.Text) || string.IsNullOrEmpty(Pricetxt.Text) || string.IsNullOrEmpty(ItemNamecb.Text))
            {
                MessageBox.Show("Please fill up the necessary informations");
                return;
            }
            try
            {
                double price = double.Parse(Pricetxt.Text);
                if (price <= 0)
                {
                    MessageBox.Show("Price cant be lower than 0");
                }
                DatabaseHelper.UpdateItem(Categorycb.Text, ItemNamecb.Text, selectedItemName, price);
                MessageBox.Show("Item updated successfully.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Price should only contain numbers");
            }
            
        }
    }
}
