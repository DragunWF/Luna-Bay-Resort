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
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            PopulateDataGridView();
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCategory.Text == "Products")
            {
                cbItemName.Items.Clear();
                var productList = DatabaseHelper.GetProduct();
                foreach (var product in productList)
                {
                    cbItemName.Items.Add(product.GetProductName());
                }
            }
            else if (cbCategory.Text == "Beverages")
            {
                cbItemName.Items.Clear();
                var beverageList = DatabaseHelper.GetFoodbyType(6);
                foreach (var food in beverageList)
                {
                    cbItemName.Items.Add(food.GetFoodName());
                }
                var snackList = DatabaseHelper.GetFoodbyType(5);
                foreach (var food in snackList)
                {
                    cbItemName.Items.Add(food.GetFoodName());
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbCategory.Text) || string.IsNullOrEmpty(cbItemName.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please fill up the necessary informations");
                return;
            }
            try
            {
                int newstock = int.Parse(txtQuantity.Text);
                if (newstock <= 0)
                {
                    MessageBox.Show("Amount of newly added stock cant be 0 or lower");
                }
                else
                {
                    Inventory.PurchaseOrderList.Add(new Inventory.PurchaseOrderItem
                    {
                        ItemName = cbItemName.Text,
                        Quantity = txtQuantity.Text,
                        Status = "Ordered"
                    });

                    MessageBox.Show($"{cbItemName.Text} has been successfully ordered.");
                    cbItemName.Items.Clear();
                    txtQuantity.Text = "";
                    PopulateDataGridView();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Quantity of stock cant be anything other than numbers");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPurchaseOrder.Rows)
            {
                // Check if the checkbox in the first column is selected
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    string status = cbStatus.Text;
                    row.Cells[3].Value = status;

                    var item = Inventory.PurchaseOrderList.FirstOrDefault(i => i.ItemName == row.Cells[1].Value?.ToString());
                    if (item != null)
                    {
                        item.Status = status;
                    }

                    if (status == "Delivered")
                    {
                        var secondColumnValue = row.Cells[1].Value?.ToString();
                        var thirdColumnValue = row.Cells[2].Value?.ToString();

                        if (!string.IsNullOrEmpty(secondColumnValue) && !string.IsNullOrEmpty(thirdColumnValue))
                        {
                            DatabaseHelper.UpdateItemStock(secondColumnValue, int.Parse(thirdColumnValue));
                        }
                    }
                    checkBoxCell.Value = false;
                }
            }
            dgvPurchaseOrder.Refresh();
        }

        private void PopulateDataGridView()
        {
            dgvPurchaseOrder.Rows.Clear();

            foreach (var item in Inventory.PurchaseOrderList)
            {
                dgvPurchaseOrder.Rows.Add(false, item.ItemName, item.Quantity, item.Status);
            }
        }

    }
}
