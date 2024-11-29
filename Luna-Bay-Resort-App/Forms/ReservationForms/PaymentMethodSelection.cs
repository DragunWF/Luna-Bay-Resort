using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms.CheckInOutForms;
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
    public partial class PaymentMethodSelection : Form
    {
        private int PaymentID;
        private readonly int reservationId, oldroomNo, newroomNo, numOfGuest;
        private readonly string checkIn, checkOut;
        private readonly double billAmount, balance;

        public PaymentMethodSelection(int reservationId, string checkIn, string checkOut, int oldroomNo,
            int newroomNo, int numOfGuest, double billAmount, double balance)
        {
            InitializeComponent();
            RequirePaymentlbl.Text = Utils.FormatCurrency(ReservationEdit.requiredPayment);

            this.reservationId = reservationId;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.oldroomNo = oldroomNo;
            this.newroomNo = newroomNo;
            this.numOfGuest = numOfGuest;
            this.billAmount = billAmount;
            this.balance = balance;
        }

        #region Check Boxes
        private void OnlinePaymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlinePaymentCheckBox.Checked)
            {
                PaymentID = 2;
                CardCheckBox.Checked = false;
            }
        }

        private void CardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CardCheckBox.Checked)
            {
                PaymentID = 3;
                OnlinePaymentCheckBox.Checked = false;
            }
        }
        #endregion

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CardCheckBox.Checked == false && OnlinePaymentCheckBox.Checked == false)
                {
                    MessageBox.Show("Please select your preferred mode of payment");
                }
                else if (string.IsNullOrEmpty((ReferenceTxt.Text)))
                {
                    MessageBox.Show("Please enter the reference number from your preferred mode of payment");
                }
                else
                {
                    DatabaseHelper.SetRoomStatus("Available", oldroomNo);
                    DatabaseHelper.UpdateReservationWithAddedPayment(
                        reservationId,
                        checkIn,
                        checkOut,
                        newroomNo,
                        numOfGuest,
                        billAmount,
                        balance,
                        PaymentID,
                        ReferenceTxt.Text
                        );
                    MessageBox.Show($"Reservation {reservationId} has been updated");
                    this.Close();
                }
            }
            catch (FormatException eee)
            {
                MessageBox.Show("Input Number Only");
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
    }
}
