using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms.CheckInOutForms;
using Luna_Bay_Resort_App.Forms.WalkInForms;
using Luna_Bay_Resort_App.Helpers;

namespace Luna_Bay_Resort_App.Forms.UserControlForms
{
    public partial class WalkInForm : Form
    {
        private int stayDuration;
        private double price;
        private string paymentMethod;
        private int paymentID;

        private const int numOfPersonLimit = 20;
        private double totalPrice = 0;

        public WalkInForm()
        {
            InitializeComponent();
            PaymentMethods.paymentreference = "";
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int numOfPerson = int.Parse(Numofpersontxt.Text);

                if (numOfPerson > numOfPersonLimit)
                {
                    MessageBox.Show($"The number of person cannot be greater than {numOfPersonLimit}");
                    return;
                }
                if(numOfPerson <= 0)
                {
                    MessageBox.Show("The number of person cannot be lower than or equal to 0");
                    return;
                }
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
                    string durationformat = $"{stayDuration} Hours";

                    DatabaseHelper.AddWalkIn(Nametxt.Text, numOfPerson, durationformat, currentdate, (int)totalPrice, paymentID, PaymentMethods.paymentreference);
                    DatabaseHelper.AddRevenue(Utils.GetDateOnly(), totalPrice);
                    FormManager.OpenForm<WalkInReceipt>(Nametxt.Text, currentdate, durationformat, numOfPerson, (int)totalPrice, paymentMethod);
                    ClearInput();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure to validate your input!");
            }
            catch(Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        #region Checkbox events

        private void Hours6cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Hours6cb.Checked)
            {
                Hours12cb.Checked = false;
                stayDuration = 6;
                price = 100;
                InputComplete();
            }
        }

        private void Hours12cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Hours12cb.Checked)
            {
                Hours6cb.Checked = false;
                stayDuration = 12;
                price = 150;
                InputComplete();
            }
        }

        private void CashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CashCheckBox.Checked)
            {
                paymentID = 1;
                paymentMethod = "Cash";
                OnlinePaymentCheckBox.Checked = false;
                CardCheckBox.Checked = false;
            }
        }

        private void OnlinePaymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlinePaymentCheckBox.Checked)
            {
                paymentID = 2;
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
                paymentID = 3;
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
                    totalPrice = int.Parse(Numofpersontxt.Text) * price;
                    Totaltxt.Text = Utils.FormatCurrency(totalPrice);
                }
                else
                {
                    totalPrice = 0;
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
