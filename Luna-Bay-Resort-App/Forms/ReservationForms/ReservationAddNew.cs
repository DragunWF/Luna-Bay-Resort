using Luna_Bay_Resort_App.Helpers;
using SubForms;

namespace Luna_Bay_Sub_Forms
{
    public partial class ReservationAddNew : Form
    {
        public ReservationAddNew()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().ToArray());
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = $"{FirstNameText.Text} {LastNameText.Text}";
                string[] textboxValues = {
                    fullName,
                    EmailText.Text,
                    ContactNoText.Text,
                    RoomTypeCB.Text,
                    GuestNumText.Text,
                    CheckInPicker.Text,
                    CheckOutPicker.Text
                };
                if (!IsValidTextBoxes(textboxValues))
                {
                    MessageBox.Show("Please don't leave any text boxes empty!");

                }
                else if (!Utils.IsValidEmail(EmailText.Text))
                {
                    MessageBox.Show("Your email is invalid, please make sure you type in a valid email address!");
                }
                else if (!Utils.IsValidContactNumber(ContactNoText.Text))
                {
                    MessageBox.Show("Your contact number is invalid, please make sure you type in a number with the correct format");
                }
                else
                {
                    // Success
                    // TODO: Uncomment database helper in the future after testing
                    // DatabaseHelper.AddReservation(
                    //     fullName,
                    //     EmailText.Text,
                    //     ContactNoText.Text,
                    //     RoomTypeCB.Text,
                    //     int.Parse(GuestNumText.Text),
                    //     CheckInPicker.Text,
                    //     CheckOutPicker.Text
                    // );
                    FormManager.OpenForm<ReservationReceipt>(
                        fullName, CheckInPicker.Text, CheckOutPicker.Text, RoomTypeCB.Text, GuestNumText.Text
                    );
                    Utils.ResetTextBoxes(new TextBox[] {
                        FirstNameText, LastNameText, EmailText, ContactNoText, GuestNumText
                    });
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
