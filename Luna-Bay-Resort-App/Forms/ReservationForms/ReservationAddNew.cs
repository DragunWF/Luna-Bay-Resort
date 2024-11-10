using Luna_Bay_Resort_App;
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

namespace Luna_Bay_Sub_Forms
{
    public partial class ReservationAddNew : Form
    {
        public ReservationAddNew()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper.AddReservation(FirstNameText.Text + "" + LastNameText.Text, EmailText.Text, ContactNoText.Text, RoomTypeText.Text, int.Parse(GuestNumText.Text), CheckInPicker.Text, CheckOutPicker.Text);
            MessageBox.Show("Success");
        }
    }
}
