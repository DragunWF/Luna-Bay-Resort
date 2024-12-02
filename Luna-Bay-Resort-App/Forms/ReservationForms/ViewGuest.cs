using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms.ReservationForms
{
    public partial class ViewGuest : Form
    {
        public ViewGuest()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Reservations("", "");
            Checkin("", "");
            Checkout("", "");
        }

        private void Reservations(string name, string checkin)
        {
            List<Guest> reservations = DatabaseHelper.GetReservationList(name, checkin);

            dgvReservation.Rows.Clear();

            foreach (var guest in reservations)
            {
                dgvReservation.Rows.Add(guest.GetReservationId(), guest.GetName(), guest.GetCheckIn());
            }
        }

        private void Checkin(string name, string checkout)
        {
            List<Guest> checkins = DatabaseHelper.GetCheckInList(name, checkout);

            dgvCheckIn.Rows.Clear();

            foreach (var guest in checkins)
            {
                dgvCheckIn.Rows.Add(guest.GetCheckInId(), guest.GetName(), guest.GetCheckOut());
            }
        }

        private void Checkout(string name, string checkout)
        {
            List<Guest> checkouts = DatabaseHelper.GetCheckOutList(name, checkout);

            dgvCheckOut.Rows.Clear();

            foreach (var guest in checkouts)
            {
                dgvCheckOut.Rows.Add(guest.GetCheckOutId(), guest.GetName());
            }
        }

        #region Search Events
        private void reservationSearchBtn_Click(object sender, EventArgs e)
        {
            Reservations(txtSearchReservation.Text, "");

        }

        private void reservationShowBtn_Click(object sender, EventArgs e)
        {
            string formattedDate = dtpReservation.Value.ToString("M/dd/yyyy");
            Reservations("", formattedDate);
        }

        private void checkInSearchBtn_Click(object sender, EventArgs e)
        {
            Checkin(txtSearchCheckIn.Text, "");
        }

        private void checkInShowBtn_Click(object sender, EventArgs e)
        {

            string formattedDate = dtpCheckIn.Value.ToString("M/dd/yyyy");
            Checkin("", formattedDate);
        }

        private void checkOutSearchReservation_Click(object sender, EventArgs e)
        {
            Checkout(txtSearchCheckOut.Text, "");
        }

        private void checkOutShowBtn_Click(object sender, EventArgs e)
        {
            string formattedDate = dtpCheckOut.Value.ToString("M/dd/yyyy");
            Checkout("", formattedDate);
        }

        #endregion
    }
}
