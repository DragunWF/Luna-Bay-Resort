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
