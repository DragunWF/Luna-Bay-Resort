using Luna_Bay_Resort_App.Helpers;
using System;
using System.Data;


namespace Luna_Bay_Resort_App.Forms.InventoryForms
{
    public partial class AddNewItem : Form
    {
        private int foodType;

        public AddNewItem()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            FoodCategorylbl.Hide();
            FoodCategoryCB.Hide();
            Servinglbl.Hide();
            Servingtxt.Hide();
        }

        private void CategoryCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (CategoryCB.Text)
            {
                case "Food":
                    FoodCategoryCB.Show();
                    FoodCategorylbl.Show();
                    Servinglbl.Show();
                    Servingtxt.Show();
                    ResetInput();
                    break;

                case "Product":
                    FoodCategorylbl.Hide();
                    FoodCategoryCB.Hide();
                    Servinglbl.Hide();
                    Servingtxt.Hide();
                    ResetInput();
                    break;
            }
        }

        private void FoodCategoryCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (FoodCategoryCB.Text)
            {
                case "Breakfast":
                    foodType = 1;
                    break;

                case "Lunch":
                    foodType = 2;
                    break;

                case "Dinner":
                    foodType = 3;
                    break;

                case "Rice Addons":
                    foodType = 4;
                    break;

                case "Snacks And Desserts":
                    foodType = 5;
                    break;

                case "Beverages":
                    foodType = 6;
                    break;
            }
        }

        private void AddItembtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CategoryCB.Text))
                {
                    MessageBox.Show("Select an item category");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(ItemNametxt.Text) || string.IsNullOrEmpty(Pricetxt.Text) || string.IsNullOrEmpty(Stocktxt.Text))
                    {
                        MessageBox.Show("Please insert necessary informations");
                        return;
                    }

                    double price = double.Parse(Pricetxt.Text);
                    int stock = int.Parse(Stocktxt.Text);

                    if (stock <= 0)
                    {
                        MessageBox.Show("Stock must be a positive number");
                        return;
                    }

                    if (price <= 0)
                    {
                        MessageBox.Show("Price must be a positive number");
                        return;
                    }

                    switch (CategoryCB.Text)
                    {
                        case "Food":
                            if (string.IsNullOrWhiteSpace(FoodCategoryCB.Text) ||
                                string.IsNullOrWhiteSpace(Servingtxt.Text))
                            {
                                MessageBox.Show("Fill out the necessary information to add new food to the menu");
                            }
                            else
                            {
                                DatabaseHelper.AddNewFood(foodType, ItemNametxt.Text, Servingtxt.Text, price, stock);
                                MessageBox.Show($"New food item added:\nName: {ItemNametxt.Text}\nServing: {Servingtxt.Text}\nPrice: {price}\nStock: {stock}");
                                ResetInput();
                            }
                            break;
                        case "Product":
                            DatabaseHelper.AddNewProduct(ItemNametxt.Text, price, stock);
                            MessageBox.Show($"New product added:\nName: {ItemNametxt.Text}\nPrice: {price}\nStock: {stock}");
                            ResetInput();
                            break;
                    }
                }             
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Fields such as Price and Stock should only contain numbers");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ResetInput()
        {
            ItemNametxt.Text = "";
            Pricetxt.Text = "";
            Stocktxt.Text = "";
            FoodCategoryCB.Text = null;
            Servingtxt.Text = "";
        }

    }
}
