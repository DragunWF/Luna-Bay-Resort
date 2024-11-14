namespace SubForms
{
    partial class SearchReservation
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
            label2 = new Label();
            label1 = new Label();
            ReservationNoText = new TextBox();
            label3 = new Label();
            SelectBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            CheckInBtn = new Button();
            FullNameText = new Label();
            CheckInDateText = new Label();
            CheckOutDateText = new Label();
            RoomTypeText = new Label();
            NoOfGuestText = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 34;
            label2.Text = "Reservation Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 22);
            label1.TabIndex = 33;
            label1.Text = "Form: Search Reservation";
            // 
            // ReservationNoText
            // 
            ReservationNoText.Font = new Font("Consolas", 9.75F);
            ReservationNoText.Location = new Point(177, 154);
            ReservationNoText.Margin = new Padding(4, 3, 4, 3);
            ReservationNoText.Name = "ReservationNoText";
            ReservationNoText.Size = new Size(204, 23);
            ReservationNoText.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 35;
            label3.Text = "Reservation No.:";
            // 
            // SelectBtn
            // 
            SelectBtn.BackColor = Color.FromArgb(80, 85, 127);
            SelectBtn.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectBtn.ForeColor = SystemColors.ButtonHighlight;
            SelectBtn.Location = new Point(388, 150);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(80, 29);
            SelectBtn.TabIndex = 59;
            SelectBtn.Text = "Search";
            SelectBtn.UseVisualStyleBackColor = false;
            SelectBtn.Click += SearchBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11F);
            label4.Location = new Point(36, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 60;
            label4.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11F);
            label5.Location = new Point(36, 280);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 18);
            label5.TabIndex = 61;
            label5.Text = "Check-In Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11F);
            label6.Location = new Point(36, 338);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 18);
            label6.TabIndex = 62;
            label6.Text = "Check-Out Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 11F);
            label7.Location = new Point(36, 398);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 63;
            label7.Text = "Room Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 11F);
            label8.Location = new Point(36, 454);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 18);
            label8.TabIndex = 64;
            label8.Text = "No. of Guest:";
            // 
            // CheckInBtn
            // 
            CheckInBtn.BackColor = Color.FromArgb(245, 211, 108);
            CheckInBtn.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            CheckInBtn.ForeColor = Color.Black;
            CheckInBtn.Location = new Point(353, 486);
            CheckInBtn.Name = "CheckInBtn";
            CheckInBtn.Size = new Size(115, 33);
            CheckInBtn.TabIndex = 65;
            CheckInBtn.Text = "Check-In Now";
            CheckInBtn.UseVisualStyleBackColor = false;
            CheckInBtn.Click += CheckInBtn_Click;
            // 
            // FullNameText
            // 
            FullNameText.AutoSize = true;
            FullNameText.Font = new Font("Consolas", 11F);
            FullNameText.Location = new Point(177, 220);
            FullNameText.Margin = new Padding(4, 0, 4, 0);
            FullNameText.Name = "FullNameText";
            FullNameText.Size = new Size(16, 18);
            FullNameText.TabIndex = 66;
            FullNameText.Text = "-";
            // 
            // CheckInDateText
            // 
            CheckInDateText.AutoSize = true;
            CheckInDateText.Font = new Font("Consolas", 11F);
            CheckInDateText.Location = new Point(177, 280);
            CheckInDateText.Margin = new Padding(4, 0, 4, 0);
            CheckInDateText.Name = "CheckInDateText";
            CheckInDateText.Size = new Size(16, 18);
            CheckInDateText.TabIndex = 67;
            CheckInDateText.Text = "-";
            // 
            // CheckOutDateText
            // 
            CheckOutDateText.AutoSize = true;
            CheckOutDateText.Font = new Font("Consolas", 11F);
            CheckOutDateText.Location = new Point(177, 338);
            CheckOutDateText.Margin = new Padding(4, 0, 4, 0);
            CheckOutDateText.Name = "CheckOutDateText";
            CheckOutDateText.Size = new Size(16, 18);
            CheckOutDateText.TabIndex = 68;
            CheckOutDateText.Text = "-";
            // 
            // RoomTypeText
            // 
            RoomTypeText.AutoSize = true;
            RoomTypeText.Font = new Font("Consolas", 11F);
            RoomTypeText.Location = new Point(177, 398);
            RoomTypeText.Margin = new Padding(4, 0, 4, 0);
            RoomTypeText.Name = "RoomTypeText";
            RoomTypeText.Size = new Size(16, 18);
            RoomTypeText.TabIndex = 69;
            RoomTypeText.Text = "-";
            // 
            // NoOfGuestText
            // 
            NoOfGuestText.AutoSize = true;
            NoOfGuestText.Font = new Font("Consolas", 11F);
            NoOfGuestText.Location = new Point(177, 454);
            NoOfGuestText.Margin = new Padding(4, 0, 4, 0);
            NoOfGuestText.Name = "NoOfGuestText";
            NoOfGuestText.Size = new Size(16, 18);
            NoOfGuestText.TabIndex = 70;
            NoOfGuestText.Text = "-";
            // 
            // SearchReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(494, 541);
            Controls.Add(NoOfGuestText);
            Controls.Add(RoomTypeText);
            Controls.Add(CheckOutDateText);
            Controls.Add(CheckInDateText);
            Controls.Add(FullNameText);
            Controls.Add(CheckInBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SelectBtn);
            Controls.Add(ReservationNoText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchReservation";
            Text = "Search Reservation Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox ReservationNoText;
        private Label label3;
        private Button SelectBtn;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button CheckInBtn;
        private Label FullNameText;
        private Label CheckInDateText;
        private Label CheckOutDateText;
        private Label RoomTypeText;
        private Label NoOfGuestText;
    }
}