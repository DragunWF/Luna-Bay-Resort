namespace Luna_Bay_Resort.UserControl
{
    partial class BookingControl
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblBooking;
        private TextBox txtGuestName;
        private Button btnSearch;

        private void InitializeComponent()
        {
            lblBooking = new Label();
            txtGuestName = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Location = new Point(20, 25);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(115, 20);
            lblBooking.TabIndex = 0;
            lblBooking.Text = "Booking System";
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(20, 75);
            txtGuestName.Margin = new Padding(3, 4, 3, 4);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.PlaceholderText = "Guest Name";
            txtGuestName.Size = new Size(100, 27);
            txtGuestName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(20, 125);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Availability";
            // 
            // BookingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblBooking);
            Controls.Add(txtGuestName);
            Controls.Add(btnSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookingControl";
            Size = new Size(1537, 1033);
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }

}
