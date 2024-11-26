using Luna_Bay_Resort_App.Forms.UserControlForms;

namespace MainForms
{
    public partial class Dashboard : Form
    {
        private Button clickedButton = null;
        private Panel contentPanel;

        public Dashboard()
        {
            InitializeComponent();
            InitializeNavigationBar();
            SetFullScreenMode();
        }

        private void SetFullScreenMode()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeNavigationBar()
        {
            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            this.Controls.Add(contentPanel);
            contentPanel.BringToFront();
            Panel topNavPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 110,
                BackColor = ColorTranslator.FromHtml("#F8F0C9"),
            };
            this.Controls.Add(topNavPanel);
            topNavPanel.Paint += (sender, e) =>
            {
                using (Pen pen = new Pen(ColorTranslator.FromHtml("#505581"), 7))
                {
                    e.Graphics.DrawLine(pen, 0, topNavPanel.Height - 1, topNavPanel.Width, topNavPanel.Height - 1);
                }
            };



            PictureBox logoPictureBox = new PictureBox
            {
                Width = 120,
                Height = 80,
                Left = 10,
                Top = 10,
                Image = Properties.Resources.logo,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            topNavPanel.Controls.Add(logoPictureBox);

            int margin = 30;

            // Create navigation buttons for different sections
            CreateNavButton("Dashboard", 150, logoPictureBox.Right + margin , (sender, e) => OnButtonClicked(sender, "Dashboard"), topNavPanel);
            CreateNavButton("Booking", 120, logoPictureBox.Right + margin + 148, (sender, e) => OnButtonClicked(sender, "Booking"), topNavPanel);
            CreateNavButton("Amenities", 140, logoPictureBox.Right + margin + 270, (sender, e) => OnButtonClicked(sender, "Amenities"), topNavPanel);
            CreateNavButton("Maintenance", 180, logoPictureBox.Right + margin + 410, (sender, e) => OnButtonClicked(sender, "Maintenance"), topNavPanel);
            CreateNavButton("Financial Reports", 250, logoPictureBox.Right + margin + 590, (sender, e) => OnButtonClicked(sender, "Financial"), topNavPanel);

            PictureBox profilePictureBox = new PictureBox
            {
                Width = 60,
                Height = 60,
                Left = 1830,
                Top = 20,
                Image = Properties.Resources.a,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            topNavPanel.Controls.Add(profilePictureBox);
        }

        private void CreateNavButton(string text, int width, int leftPosition, EventHandler clickEventHandler, Panel parentPanel)
        {
            Button btn = new Button
            {
                Text = text,
                Width = width,
                Height = 40,
                Left = leftPosition,
                Top = 30,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Font = new Font("Consolas", 14, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += clickEventHandler;
            btn.Paint += Btn_Paint;
            parentPanel.Controls.Add(btn);
        }

        private void OnButtonClicked(object sender, string sectionName)
        {
            if (clickedButton != null)
            {
                clickedButton.Invalidate();
            }

            clickedButton = sender as Button;
            clickedButton.Invalidate();
            SwitchContent(sectionName);
        }

        private void SwitchContent(string sectionName)
        {
            contentPanel.Controls.Clear();


            switch (sectionName)
            {
                case "Dashboard":
                    AddUserControlToContentPanel(new DashboardUserControl());
                    break;
                case "Booking":
                    AddUserControlToContentPanel(new BookingUserControl());
                    break;

                case "Amenities":
                    AddUserControlToContentPanel(new AmenitiesUserControl());
                    break;

                case "Maintenance":
                    AddUserControlToContentPanel(new MaintenanceUserControl());
                    break;

                case "Financial":
                    AddUserControlToContentPanel(new FinancialReportsUserControl());
                    break;
            }
        }

        private void AddUserControlToContentPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(userControl);
        }

        private void Btn_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == clickedButton)
            {
                using (Pen pen = new Pen(Color.Black, 4))
                {
                    e.Graphics.DrawLine(pen, 0, btn.Height - 1, btn.Width, btn.Height - 1);
                }
            }
        }
    }
}
