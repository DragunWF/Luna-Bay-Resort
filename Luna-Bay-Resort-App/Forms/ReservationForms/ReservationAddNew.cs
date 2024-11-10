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
using System.Windows.Forms.VisualStyles;

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
            try
            {
                string fullName = $"{FirstNameText.Text} {LastNameText.Text}";
                if (IsValidTextBoxes(new string[] {
                    fullName,
                    EmailText.Text,
                    ContactNoText.Text,
                    RoomTypeText.Text,
                    GuestNumText.Text,
                    CheckInPicker.Text,
                    CheckOutPicker.Text
                }))
                {
                    DatabaseHelper.AddReservation(
                        fullName,
                        EmailText.Text,
                        ContactNoText.Text,
                        RoomTypeText.Text,
                        int.Parse(GuestNumText.Text),
                        CheckInPicker.Text,
                        CheckOutPicker.Text
                    );
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Please don't leave any text boxes empty!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private bool IsValidTextBoxes(string[] textValues)
        {
            foreach (string value in textValues)
            {
                if (string.IsNullOrEmpty(value))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
