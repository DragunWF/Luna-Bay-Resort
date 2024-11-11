namespace Luna_Bay_Resort_App.Forms.Test
{
    partial class FormOpener
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
            label1 = new Label();
            label2 = new Label();
            AddReservationBtn = new Button();
            LoginBtn = new Button();
            DashboardBtn = new Button();
            CheckInBtn = new Button();
            EditReservationBtn = new Button();
            SearchReservationBtn = new Button();
            CheckOutBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Form Opener";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 54);
            label2.Name = "label2";
            label2.Size = new Size(364, 15);
            label2.TabIndex = 1;
            label2.Text = "Note: This form is only meant to be used for developers and testing!";
            // 
            // AddReservationBtn
            // 
            AddReservationBtn.Location = new Point(300, 84);
            AddReservationBtn.Name = "AddReservationBtn";
            AddReservationBtn.Size = new Size(138, 23);
            AddReservationBtn.TabIndex = 2;
            AddReservationBtn.Text = "Add Reservation";
            AddReservationBtn.UseVisualStyleBackColor = true;
            AddReservationBtn.Click += AddReservationBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(12, 84);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(138, 23);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Location = new Point(156, 84);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(138, 23);
            DashboardBtn.TabIndex = 4;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.UseVisualStyleBackColor = true;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // CheckInBtn
            // 
            CheckInBtn.Location = new Point(300, 113);
            CheckInBtn.Name = "CheckInBtn";
            CheckInBtn.Size = new Size(138, 23);
            CheckInBtn.TabIndex = 5;
            CheckInBtn.Text = "Check In";
            CheckInBtn.UseVisualStyleBackColor = true;
            CheckInBtn.Click += CheckInBtn_Click;
            // 
            // EditReservationBtn
            // 
            EditReservationBtn.Location = new Point(12, 113);
            EditReservationBtn.Name = "EditReservationBtn";
            EditReservationBtn.Size = new Size(138, 23);
            EditReservationBtn.TabIndex = 6;
            EditReservationBtn.Text = "Edit Reservation";
            EditReservationBtn.UseVisualStyleBackColor = true;
            EditReservationBtn.Click += EditReservationBtn_Click;
            // 
            // SearchReservationBtn
            // 
            SearchReservationBtn.Location = new Point(156, 113);
            SearchReservationBtn.Name = "SearchReservationBtn";
            SearchReservationBtn.Size = new Size(138, 23);
            SearchReservationBtn.TabIndex = 7;
            SearchReservationBtn.Text = "Search Reservation";
            SearchReservationBtn.UseVisualStyleBackColor = true;
            SearchReservationBtn.Click += SearchReservationBtn_Click;
            // 
            // CheckOutBtn
            // 
            CheckOutBtn.Location = new Point(12, 142);
            CheckOutBtn.Name = "CheckOutBtn";
            CheckOutBtn.Size = new Size(138, 23);
            CheckOutBtn.TabIndex = 8;
            CheckOutBtn.Text = "Check Out";
            CheckOutBtn.UseVisualStyleBackColor = true;
            CheckOutBtn.Click += CheckOutBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 207);
            label3.Name = "label3";
            label3.Size = new Size(340, 15);
            label3.TabIndex = 9;
            label3.Text = "PS: I'm excluding the receipt forms and user control forms here";
            // 
            // FormOpener
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 231);
            Controls.Add(label3);
            Controls.Add(CheckOutBtn);
            Controls.Add(SearchReservationBtn);
            Controls.Add(EditReservationBtn);
            Controls.Add(CheckInBtn);
            Controls.Add(DashboardBtn);
            Controls.Add(LoginBtn);
            Controls.Add(AddReservationBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormOpener";
            Text = "Form Opener - Developer Testing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button AddReservationBtn;
        private Button LoginBtn;
        private Button DashboardBtn;
        private Button CheckInBtn;
        private Button EditReservationBtn;
        private Button SearchReservationBtn;
        private Button CheckOutBtn;
        private Label label3;
    }
}