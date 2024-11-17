using Luna_Bay_Resort_App.Helpers;

namespace Luna_Bay_Resort_App.Forms.Test
{
    public partial class RoomStatusChangeTest : Form
    {
        public int roomID = 2131;

        public RoomStatusChangeTest()
        {
            InitializeComponent();
        }

        private void Availablebtn_Click(object sender, EventArgs e)
        {
            string status = "Available";
            DatabaseHelper.SetRoomStatus(status, roomID);
        }

        private void Cleaningbtn_Click(object sender, EventArgs e)
        {
            string status = "Cleaning";
            DatabaseHelper.SetRoomStatus(status, roomID);
        }

        private void Repairbtn_Click(object sender, EventArgs e)
        {
            string status = "Repair";
            DatabaseHelper.SetRoomStatus(status, roomID);
        }
    }
}
