namespace Luna_Bay_Resort.forms
{
    partial class DashbordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sideNavPanel = new Panel();
            monthCalendar1 = new MonthCalendar();
            employeeBtn = new Button();
            financialBtn = new Button();
            maintenanceBtn = new Button();
            posBtn = new Button();
            bookBtn = new Button();
            pictureBox1 = new PictureBox();
            userControlPanel = new Panel();
            sideNavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sideNavPanel
            // 
            sideNavPanel.BackColor = Color.PapayaWhip;
            sideNavPanel.Controls.Add(monthCalendar1);
            sideNavPanel.Controls.Add(employeeBtn);
            sideNavPanel.Controls.Add(financialBtn);
            sideNavPanel.Controls.Add(maintenanceBtn);
            sideNavPanel.Controls.Add(posBtn);
            sideNavPanel.Controls.Add(bookBtn);
            sideNavPanel.Controls.Add(pictureBox1);
            sideNavPanel.Dock = DockStyle.Left;
            sideNavPanel.Location = new Point(0, 0);
            sideNavPanel.Name = "sideNavPanel";
            sideNavPanel.Size = new Size(365, 1033);
            sideNavPanel.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(45, 748);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // employeeBtn
            // 
            employeeBtn.FlatStyle = FlatStyle.Flat;
            employeeBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeBtn.Image = Properties.Resources.employees;
            employeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            employeeBtn.Location = new Point(45, 647);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(262, 47);
            employeeBtn.TabIndex = 5;
            employeeBtn.Text = "Employee";
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += employeeBtn_Click;
            // 
            // financialBtn
            // 
            financialBtn.FlatStyle = FlatStyle.Flat;
            financialBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            financialBtn.Image = Properties.Resources.financial;
            financialBtn.ImageAlign = ContentAlignment.MiddleLeft;
            financialBtn.Location = new Point(45, 560);
            financialBtn.Name = "financialBtn";
            financialBtn.Size = new Size(262, 47);
            financialBtn.TabIndex = 4;
            financialBtn.Text = "Reports";
            financialBtn.UseVisualStyleBackColor = true;
            financialBtn.Click += financialBtn_Click;
            // 
            // maintenanceBtn
            // 
            maintenanceBtn.FlatStyle = FlatStyle.Flat;
            maintenanceBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maintenanceBtn.Image = Properties.Resources.wrench;
            maintenanceBtn.ImageAlign = ContentAlignment.MiddleLeft;
            maintenanceBtn.Location = new Point(45, 479);
            maintenanceBtn.Name = "maintenanceBtn";
            maintenanceBtn.Size = new Size(262, 47);
            maintenanceBtn.TabIndex = 3;
            maintenanceBtn.Text = "Maintenance";
            maintenanceBtn.UseVisualStyleBackColor = true;
            maintenanceBtn.Click += maintenanceBtn_Click;
            // 
            // posBtn
            // 
            posBtn.FlatStyle = FlatStyle.Flat;
            posBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posBtn.Image = Properties.Resources.system;
            posBtn.ImageAlign = ContentAlignment.MiddleLeft;
            posBtn.Location = new Point(45, 401);
            posBtn.Name = "posBtn";
            posBtn.Size = new Size(262, 47);
            posBtn.TabIndex = 2;
            posBtn.Text = "P.O.S";
            posBtn.UseVisualStyleBackColor = true;
            posBtn.Click += posBtn_Click;
            // 
            // bookBtn
            // 
            bookBtn.FlatStyle = FlatStyle.Flat;
            bookBtn.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookBtn.Image = Properties.Resources.booking;
            bookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            bookBtn.Location = new Point(45, 322);
            bookBtn.Name = "bookBtn";
            bookBtn.Size = new Size(262, 47);
            bookBtn.TabIndex = 1;
            bookBtn.Text = "Book now";
            bookBtn.UseVisualStyleBackColor = true;
            bookBtn.Click += bookBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(45, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userControlPanel
            // 
            userControlPanel.Dock = DockStyle.Fill;
            userControlPanel.Location = new Point(365, 0);
            userControlPanel.Name = "userControlPanel";
            userControlPanel.Size = new Size(1537, 1033);
            userControlPanel.TabIndex = 1;
            // 
            // DashbordForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(userControlPanel);
            Controls.Add(sideNavPanel);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashbordForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashbordForm";
            WindowState = FormWindowState.Maximized;
            Load += DashbordForm_Load;
            sideNavPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideNavPanel;
        private Panel userControlPanel;
        private PictureBox pictureBox1;
        private Button bookBtn;
        private Button employeeBtn;
        private Button financialBtn;
        private Button maintenanceBtn;
        private Button posBtn;
        private MonthCalendar monthCalendar1;
    }
}