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

        }
    }
}
