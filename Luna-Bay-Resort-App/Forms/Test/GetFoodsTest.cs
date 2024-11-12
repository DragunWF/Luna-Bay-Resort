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

namespace Luna_Bay_Resort_App.Forms
{
    public partial class GetFoodsTest : Form
    {

        public GetFoodsTest()
        {
            InitializeComponent();
        }

        private void Breakfastbtn_Click(object sender, EventArgs e)
        {
            int foodtype = 1;
            DisplayFoodByFoodID(foodtype);
        }
        private void LunchBtn_Click(object sender, EventArgs e)
        {
            int foodtype = 2;
            DisplayFoodByFoodID(foodtype);
        }
        private void Dinnerbtn_Click(object sender, EventArgs e)
        {
            int foodtype = 3;
            DisplayFoodByFoodID(foodtype);
        }
        private void RiceAddonsbtn_Click(object sender, EventArgs e)
        {
            int foodtype = 4;
            DisplayFoodByFoodID(foodtype);
        }
        private void Snacksbtn_Click(object sender, EventArgs e)
        {
            int foodtype = 5;
            DisplayFoodByFoodID(foodtype);
        }
        private void Beveragesbtn_Click(object sender, EventArgs e)
        {
            int foodtype = 6;
            DisplayFoodByFoodID(foodtype);
        }
        private void foodSearchbtn_Click(object sender, EventArgs e)
        {
            SearchFood(FoodSearchtxt.Text);
        }

        //display foods to listview based on foodtype
        private void DisplayFoodByFoodID(int FoodType)
        {
            List<Food> foods = DatabaseHelper.getFoodbyType(FoodType);

            listView1.Items.Clear();

            foreach (var food in foods)
            {
                ListViewItem item = new ListViewItem(food.getFoodName());
                item.SubItems.Add(Utils.FormatCurrency(food.getPrice()));
                listView1.Items.Add(item);
            }
        }

        //display foods to listview based on foodtype
        private void SearchFood(string FoodName)
        {
            List<Food> foods = DatabaseHelper.searchFood(FoodName);

            listView1.Items.Clear();

            foreach (var food in foods)
            {
                ListViewItem item = new ListViewItem(food.getFoodName());
                item.SubItems.Add(Utils.FormatCurrency(food.getPrice()));
                listView1.Items.Add(item);
            }
        }
        
    }
}
