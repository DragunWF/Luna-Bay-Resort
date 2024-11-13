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
            MaximizeBox = false;
            RoomTypeCB.Items.AddRange(DatabaseHelper.GetRoomTypes().Select(r => r.GetName()).ToArray());
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = $"{FirstNameText.Text} {LastNameText.Text}";
                string[] inputValues = {
                    FirstNameText.Text,
                    LastNameText.Text,
                    EmailText.Text,
                    ContactNoText.Text,
                    RoomTypeCB.Text,
                    GuestNumText.Text,
                    CheckInPicker.Text,
                    CheckOutPicker.Text
                };
                if (Utils.IsValidFormData(inputValues, EmailText.Text, ContactNoText.Text))
                {
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

        //Changes text to reflect selected room name from RoomTypeCB, can change output label in the future
        private void RoomTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            TotalAmountText.Text = Utils.FormatCurrency(DatabaseHelper.ReturnRoomPrice(RoomTypeCB.Text));
        }
    }
}
