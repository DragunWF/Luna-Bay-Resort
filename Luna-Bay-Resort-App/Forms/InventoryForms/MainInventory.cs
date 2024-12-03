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

            SearchItem("");

            //Disable dgv edit and remove blank row
            inventoryDataGrid.AllowUserToAddRows = false;
            inventoryDataGrid.Columns["itemName"].ReadOnly = true;
            inventoryDataGrid.Columns["quantity"].ReadOnly = true;
            inventoryDataGrid.Columns["price"].ReadOnly = true;
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
            SearchItem("");
        }
    }
}
