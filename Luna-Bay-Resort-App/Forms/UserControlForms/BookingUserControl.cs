using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaBayFinals
{
    public partial class BookingUserControl : UserControl
    {
        public BookingUserControl()
        {
            InitializeComponent();
            InitializeBookingCards();
        }
        private void InitializeBookingCards()
        {
            SuspendLayout();  

            
            TableLayoutPanel mainPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                AutoSize = false,
                Padding = new Padding(10, 10, 10, 10),
            };

            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));  
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));  
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));  
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));  

            // Reservation title
            Label ReservationTitle = new Label
            {
                Text = "Reservation",
                Font = new Font("Consolas", 20, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                Margin = new Padding(10,0,10,0)
            };
            mainPanel.Controls.Add(ReservationTitle, 0, 0);

            // Check-in/out title
            Label CheckInOutTitle = new Label
            {
                Text = "Check In / Check Out",
                Font = new Font("Consolas", 20, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                Margin = new Padding(10, 0, 10, 0)
            };
            mainPanel.Controls.Add(CheckInOutTitle, 0, 2);

            // FlowLayoutPanel for reservations
            FlowLayoutPanel ReservationPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(20),
                Margin = new Padding(0, 10, 0, 0)
            };
            mainPanel.Controls.Add(ReservationPanel, 0, 1);

            // FlowLayoutPanel for check-in/out
            FlowLayoutPanel CheckInOutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(20),
                Margin = new Padding(0, 10, 0, 0)
            };
            mainPanel.Controls.Add(CheckInOutPanel, 0, 3);

            // Add the booking cards
            ReservationPanel.Controls.Add(CreateBookingCard(Properties.Resources.addReservation, "Add Reservation", Color.White));
            ReservationPanel.Controls.Add(CreateBookingCard(Properties.Resources.editReservation, "Edit Reservation", Color.White));
            ReservationPanel.Controls.Add(CreateBookingCard(Properties.Resources.viewReservation, "Search Reservation", Color.White));

            // Add check-in/out cards
            CheckInOutPanel.Controls.Add(CreateBookingCard(Properties.Resources.check_in, "Check In", Color.White));
            CheckInOutPanel.Controls.Add(CreateBookingCard(Properties.Resources.check_out, "Check Out", Color.White));

            // Add the main panel to the UserControl
            this.Controls.Add(mainPanel);

            ResumeLayout(false);  
        }

        private Panel CreateBookingCard(Image icon, string title, Color cardColor)
        {
            Panel cardPanel = new Panel
            {
                Width = 250,
                Height = 250,
                Padding = new Padding(15, 0, 15, 20),
                BackColor = cardColor,
                BorderStyle = BorderStyle.FixedSingle,
            };

            
            PictureBox pictureBox = new PictureBox
            {
                Image = icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 130,
                Height = 100,
                Left = (cardPanel.Width - 120) / 2,
                Top = (cardPanel.Height - 110) / 2 - 20,
            };
            cardPanel.Controls.Add(pictureBox);

            
            Button actionButton = new Button
            {
                Text = title,
                Font = new Font("Consolas", 12, FontStyle.Regular),
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#2E2F5B"),
                ForeColor = Color.White,
            };
            actionButton.Click += (sender, e) =>
            {
                MessageBox.Show($"{title} button clicked!");
            };
            cardPanel.Controls.Add(actionButton);

            return cardPanel;
        }

    }
}
