using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms.InventoryForms
{
    public partial class MainInventory : Form
    {
        public MainInventory()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            DisplayFoodByFoodID(6);
            GetProduct();
        }

        private void PurchaseOrderBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<PurchaseOrder>();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<AddNewItem>();
        }

        private void EditItemBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<EditItem>();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchItem(txtSearch.Text);
        }
        private void DisplayFoodByFoodID(int FoodType)
        {
            List<Food> foods = DatabaseHelper.GetFoodbyType(FoodType);

            foreach (var food in foods)
            {
                string formattedPrice = Utils.FormatCurrency(food.GetPrice());
                inventoryDataGrid.Rows.Add(food.GetFoodName(), formattedPrice, food.GetStock());
            }
        }

        private void GetProduct()
        {
            List<Product> products = DatabaseHelper.GetProduct();

            foreach (var product in products)
            {
                string formattedPrice = Utils.FormatCurrency(product.GetPrice());
                inventoryDataGrid.Rows.Add(product.GetProductName(), formattedPrice, product.GetStock());
            }
        }

        private void SearchItem(string Name)
        {
            List<Items> allitems = DatabaseHelper.SearchItemInventory(Name);

            inventoryDataGrid.Rows.Clear();

            foreach (var item in allitems)
            {
                string formattedPrice = Utils.FormatCurrency(item.GetPrice());
                inventoryDataGrid.Rows.Add(item.GetName(), formattedPrice, item.GetStock());
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            inventoryDataGrid.Rows.Clear();
            DisplayFoodByFoodID(6);
            GetProduct();
        }
    }
}
