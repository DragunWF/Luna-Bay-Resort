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
    public partial class ReservationEdit : Form
    {
        public ReservationEdit()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().Select(r => r.GetName()).ToArray());
        }

        //Changes text to reflect selected room name from RoomTypeCB
        private void RoomTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
                TotalAmountText.Text = Utils.FormatCurrency(DatabaseHelper.GetRoomPrice(RoomTypeCB.Text));
        }
    }
}
