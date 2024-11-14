namespace SubForms
{
    public partial class CheckOut : Form
    {
        private int checkInNo = -1;

        public CheckOut()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CheckInNoText.Text))
                {
                    MessageBox.Show("Do not leave the check-in text box empty!");
                }
                else
                {

                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("Please enter a valid check-in nuber!");
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInNo != -1)
                {
                    // TODO: 
                    ResetTextLabels();
                }
                else
                {
                    MessageBox.Show("Make sure to search a check-in number first!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"An unexpected error has occured: {err.Message}");
            }
        }

        private void ResetTextLabels()
        {
            CheckInNoText.Text = "";
            NameText.Text = "-";
            CheckInDate.Text = "-";
            CheckOutDate.Text = "-";
            RoomTypeText.Text = "-";
            GuestNumText.Text = "-";
        }
    }
}
