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

namespace SubForms
{
    public partial class ReservationReceipt : Form
    {
        private string receiptId;

        public ReservationReceipt()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            receiptId = Utils.GenerateReceiptId();

            // Displays receipt data to the text labels
            DisplayReceiptData();
        }

        private void DisplayReceiptData()
        {
            ReceiptNoText.Text = receiptId;
        }
    }
}
