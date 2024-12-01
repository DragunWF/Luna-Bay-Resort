using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms.CheckInOutForms;
using Luna_Bay_Resort_App.Forms.WalkInForms;
using Luna_Bay_Resort_App.Helpers;

namespace Luna_Bay_Resort_App.Forms.UserControlForms
{
    public partial class WalkInForm : Form
    {
        private int stayduration;
        private double price;
        private string paymentMethod;
        private int PaymentID;

        public WalkInForm()
        {
            InitializeComponent();
            PaymentMethods.paymentreference = "";
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(Nametxt.Text) || string.IsNullOrEmpty(Totaltxt.Text))
                {
                    MessageBox.Show("Please fill out the required information");
                }
                else if (!CashCheckBox.Checked && !OnlinePaymentCheckBox.Checked && !CardCheckBox.Checked)
                {
                    MessageBox.Show("Please make sure to choose a payment method!");
                }
                else
                {
                    string currentdate = Utils.GetCurrentDate();
                    string durationformat = $"{stayduration} Hours";

                    DatabaseHelper.AddWalkIn(Nametxt.Text, int.Parse(Numofpersontxt.Text), durationformat, currentdate, int.Parse(Totaltxt.Text), PaymentID, PaymentMethods.paymentreference);
                    DatabaseHelper.AddRevenue(Utils.GetDateOnly(), double.Parse(Totaltxt.Text));
                    FormManager.OpenForm<WalkInReceipt>(Nametxt.Text, currentdate, durationformat, int.Parse(Numofpersontxt.Text), int.Parse(Totaltxt.Text), paymentMethod);
                    ClearInput();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Checkbox events
        private void Hours6cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Hours6cb.Checked)
            {
                Hours12cb.Checked = false;
                stayduration = 6;
                price = 100;
                InputComplete();
            }
        }

        private void Hours12cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Hours12cb.Checked)
            {
                Hours6cb.Checked = false;
                stayduration = 12;
                price = 150;
                InputComplete();
            }
        }

        private void CashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CashCheckBox.Checked)
            {
                PaymentID = 1;
                paymentMethod = "Cash";
                OnlinePaymentCheckBox.Checked = false;
                CardCheckBox.Checked = false;
            }
        }

        private void OnlinePaymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlinePaymentCheckBox.Checked)
            {
                PaymentID = 2;
                paymentMethod = "Online Payment";
                CashCheckBox.Checked = false;
                CardCheckBox.Checked = false;

                FormManager.OpenForm<OnlinePaymentReference>();
            }
        }

        private void CardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CardCheckBox.Checked)
            {
                PaymentID = 3;
                paymentMethod = "Debit/Credit Card";
                CashCheckBox.Checked = false;
                OnlinePaymentCheckBox.Checked = false;

                FormManager.OpenForm<CardReference>();
            }
        }
        #endregion

        private void ClearInput()
        {
            Nametxt.Text = "";
            Numofpersontxt.Text = "";
            Hours6cb.Checked = false;
            Hours12cb.Checked = false;
            Totaltxt.Text = "";
            CashCheckBox.Checked = false;
            OnlinePaymentCheckBox.Checked = false;
            CardCheckBox.Checked = false;
        }

        private void InputComplete()
        {
            try
            {
                if (!string.IsNullOrEmpty(Numofpersontxt.Text) && (Hours6cb.Checked || Hours12cb.Checked))
                {
                    Totaltxt.Text = (int.Parse(Numofpersontxt.Text) * price).ToString();
                }
                else
                {
                    Totaltxt.Text = "";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter numbers only on Number of Person");
                Numofpersontxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Numofpersontxt_TextChanged(object sender, EventArgs e)
        {
            InputComplete();
        }
    }
}
