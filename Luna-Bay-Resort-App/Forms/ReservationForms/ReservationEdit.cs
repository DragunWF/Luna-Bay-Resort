using System.Globalization;
using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms;
using Luna_Bay_Resort_App.Forms.ReservationForms;
using Luna_Bay_Resort_App.Helpers;
using MainForms;

namespace SubForms
{
    public partial class ReservationEdit : Form
    {
        private int reservationNo = -1;
        private Guest reservation;
        private int newroomnum;
        private double requiredDeposit;
        private double paidamount;
        private double updatedBalance;
        public static double requiredPayment;

        public ReservationEdit()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().Select(r => r.GetName()).ToArray());

            SessionData.RoomPax = 0;
            SessionData.RoomCost = 0;
        }

        public ReservationEdit(int reservationNo) : this()
        {
            this.reservationNo = reservationNo;
            ReservationNoText.Text = reservationNo.ToString();
            SelectBtn_Click(this, EventArgs.Empty);
        }

        // Changes text to reflect selected room name from RoomTypeCB
        private void RoomTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            SessionData.RoomPax = DatabaseHelper.GetPax(RoomTypeCB.Text);
            SessionData.RoomCost = DatabaseHelper.GetRoomPrice(RoomTypeCB.Text);
            UpdatePax();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            const string dateFormat = "M/dd/yyyy hh:mm";
            try
            {
                reservationNo = int.Parse(ReservationNoText.Text);
                reservation = DatabaseHelper.GetReservation(reservationNo); 
                if (reservation != null)
                {
                    paidamount = reservation.GetBillAmount() - reservation.GetBalance();
                    CheckInPicker.Value = DateTime.ParseExact(reservation.GetCheckIn(), dateFormat, CultureInfo.InvariantCulture);
                    CheckOutPicker.Value = DateTime.ParseExact(reservation.GetCheckOut(), dateFormat,CultureInfo.InvariantCulture);
                    RoomTypeCB.Text = DatabaseHelper.GetRoomName(reservation.GetRoomNo());
                    Paxlbl.Text = reservation.GetNumOfGuest().ToString();
                    Paidtxt.Text = paidamount.ToString();
                    TotalAmountText.Text = reservation.GetBillAmount().ToString();
                    DepositText.Text = (Double.Parse(TotalAmountText.Text) * .5).ToString();
                }
                else
                {
                    MessageBox.Show("Reservation cannot be found! Make sure you type in the correct reservation number.");
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("Please make sure to input a valid reservation number!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputValues = {
                    RoomTypeCB.Text,
                    Paxlbl.Text,
                    DepositText.Text,
                    TotalAmountText.Text,
                };
                if (reservationNo == -1)
                {
                    MessageBox.Show("Please make sure to select a reservation first!");
                }
                else if (Utils.IsTextBoxesNotEmpty(inputValues) &&
                         Utils.IsValidCheckInOut(CheckInPicker, CheckOutPicker))
                {
                    newroomnum = DatabaseHelper.GetRoomNo(RoomTypeCB.Text);
                    //Asks customer for additional payment when new room's downpayment > previous downpayment
                    if (requiredDeposit > paidamount)
                    {
                        requiredPayment = requiredDeposit - paidamount;
                        DialogResult result = MessageBox.Show(
                        $"Additional {Utils.FormatCurrency(requiredPayment)} deposit is required to complete changes",
                        "Insufficient Funds, Confirm Room Change?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            FormManager.OpenForm<PaymentMethodSelection>(reservationNo,
                                        CheckInPicker.Text.ToString(),
                                        CheckOutPicker.Text.ToString(),
                                        reservation.GetRoomNo(),
                                        newroomnum,
                                        int.Parse(Paxlbl.Text),
                                        double.Parse(TotalAmountText.Text),
                                        requiredDeposit);
                        }
                    }
                    else
                    {
                        //If initial paid deposit is greater than the total of the new room then customer will be refunded the excess money
                        if (paidamount > double.Parse(TotalAmountText.Text))
                        {
                            double refund = Math.Abs(paidamount - double.Parse(TotalAmountText.Text));
                            MessageBox.Show($"Customer is eligible for a refund of {Utils.FormatCurrency(refund)}");
                            updatedBalance = 0;
                        }
                        else
                        {
                            updatedBalance = double.Parse(TotalAmountText.Text) - paidamount;
                        }  
                        DatabaseHelper.SetRoomStatus("Available", reservation.GetRoomNo());
                        newroomnum = DatabaseHelper.GetRoomNo(RoomTypeCB.Text);
                        DatabaseHelper.UpdateReservation(
                            reservationNo,
                            CheckInPicker.Text.ToString(),
                            CheckOutPicker.Text.ToString(),
                            newroomnum,
                            int.Parse(Paxlbl.Text),
                            double.Parse(TotalAmountText.Text),
                            updatedBalance
                        );
                        MessageBox.Show($"Reservation {reservationNo} has been successfully edited!");
                        reservationNo = -1;
                    }
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("Please make sure to input a valid deposit and payment amount!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void AddPaxbtn_Click(object sender, EventArgs e)
        {
            switch (Paxlbl.Text)
            {
                case "0":
                    MessageBox.Show("Select a Room first before adding additional Pax");
                    break;
                default:
                    FormManager.OpenForm<AddPax>();
                    break;
            }
        }
        public void UpdatePax()
        {
            if (RoomTypeCB.SelectedItem != null)
            {
                requiredDeposit = SessionData.GetRoomCost() * .5;
                DepositText.Text = requiredDeposit.ToString();
                Paxlbl.Text = SessionData.GetRoomPax().ToString();
                TotalAmountText.Text = SessionData.GetRoomCost().ToString();
            }
        }

        //Updates label whenever it regains focus
        protected override void OnActivated(EventArgs e)
        {
            UpdatePax();
        }
    }
}
