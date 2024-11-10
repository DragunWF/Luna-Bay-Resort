namespace Luna_Bay_Sub_Forms
{
    partial class ReservationAddNew
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FirstNameText = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            CheckInPicker = new DateTimePicker();
            CheckOutPicker = new DateTimePicker();
            label10 = new Label();
            RoomTypeText = new TextBox();
            label11 = new Label();
            GuestNumText = new TextBox();
            label12 = new Label();
            LastNameText = new TextBox();
            EmailText = new TextBox();
            ContactNoText = new TextBox();
            label14 = new Label();
            DepositReqAmountText = new Label();
            DepositPaidCheck = new CheckBox();
            ConfirmButton = new Button();
            TotalAmountText = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 22);
            label1.TabIndex = 0;
            label1.Text = "Form: Add new reservation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F);
            label3.Location = new Point(23, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 18);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F);
            label4.Location = new Point(257, 113);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 3;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F);
            label5.Location = new Point(23, 177);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 18);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // FirstNameText
            // 
            FirstNameText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameText.Location = new Point(23, 135);
            FirstNameText.Margin = new Padding(4, 3, 4, 3);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(204, 24);
            FirstNameText.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F);
            label6.Location = new Point(257, 177);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 18);
            label6.TabIndex = 9;
            label6.Text = "Contact No.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 240);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(180, 20);
            label7.TabIndex = 10;
            label7.Text = "Reservation Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 11.25F);
            label8.Location = new Point(257, 275);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 18);
            label8.TabIndex = 12;
            label8.Text = "Check-Out Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 11.25F);
            label9.Location = new Point(23, 275);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 18);
            label9.TabIndex = 11;
            label9.Text = "Check-In Date:";
            // 
            // CheckInPicker
            // 
            CheckInPicker.CustomFormat = "M/dd/yyyy hh:mm";
            CheckInPicker.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckInPicker.Format = DateTimePickerFormat.Custom;
            CheckInPicker.Location = new Point(23, 296);
            CheckInPicker.Margin = new Padding(4, 3, 4, 3);
            CheckInPicker.Name = "CheckInPicker";
            CheckInPicker.Size = new Size(204, 24);
            CheckInPicker.TabIndex = 15;
            // 
            // CheckOutPicker
            // 
            CheckOutPicker.CustomFormat = "M/dd/yyyy hh:mm";
            CheckOutPicker.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckOutPicker.Format = DateTimePickerFormat.Custom;
            CheckOutPicker.Location = new Point(257, 296);
            CheckOutPicker.Margin = new Padding(4, 3, 4, 3);
            CheckOutPicker.Name = "CheckOutPicker";
            CheckOutPicker.Size = new Size(204, 24);
            CheckOutPicker.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(23, 343);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 18);
            label10.TabIndex = 17;
            label10.Text = "Room Type:";
            // 
            // RoomTypeText
            // 
            RoomTypeText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomTypeText.Location = new Point(117, 337);
            RoomTypeText.Margin = new Padding(4, 3, 4, 3);
            RoomTypeText.Name = "RoomTypeText";
            RoomTypeText.Size = new Size(148, 24);
            RoomTypeText.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(273, 343);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 18);
            label11.TabIndex = 19;
            label11.Text = "No. of Guests:";
            // 
            // GuestNumText
            // 
            GuestNumText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuestNumText.Location = new Point(399, 337);
            GuestNumText.Margin = new Padding(4, 3, 4, 3);
            GuestNumText.Name = "GuestNumText";
            GuestNumText.Size = new Size(62, 24);
            GuestNumText.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.Location = new Point(23, 381);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(189, 20);
            label12.TabIndex = 21;
            label12.Text = "Payment Information:";
            // 
            // LastNameText
            // 
            LastNameText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameText.Location = new Point(257, 135);
            LastNameText.Margin = new Padding(4, 3, 4, 3);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(204, 24);
            LastNameText.TabIndex = 23;
            // 
            // EmailText
            // 
            EmailText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailText.Location = new Point(23, 199);
            EmailText.Margin = new Padding(4, 3, 4, 3);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(204, 24);
            EmailText.TabIndex = 24;
            // 
            // ContactNoText
            // 
            ContactNoText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactNoText.Location = new Point(257, 199);
            ContactNoText.Margin = new Padding(4, 3, 4, 3);
            ContactNoText.Name = "ContactNoText";
            ContactNoText.Size = new Size(204, 24);
            ContactNoText.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(255, 20, 41);
            label14.Location = new Point(23, 424);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(161, 16);
            label14.TabIndex = 26;
            label14.Text = "Amount of Req. Deposit:";
            // 
            // DepositReqAmountText
            // 
            DepositReqAmountText.AutoSize = true;
            DepositReqAmountText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepositReqAmountText.ForeColor = Color.FromArgb(255, 20, 41);
            DepositReqAmountText.Location = new Point(189, 424);
            DepositReqAmountText.Margin = new Padding(4, 0, 4, 0);
            DepositReqAmountText.Name = "DepositReqAmountText";
            DepositReqAmountText.Size = new Size(14, 16);
            DepositReqAmountText.TabIndex = 27;
            DepositReqAmountText.Text = "0";
            // 
            // DepositPaidCheck
            // 
            DepositPaidCheck.CheckAlign = ContentAlignment.MiddleRight;
            DepositPaidCheck.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepositPaidCheck.Location = new Point(333, 419);
            DepositPaidCheck.Margin = new Padding(4, 3, 4, 3);
            DepositPaidCheck.Name = "DepositPaidCheck";
            DepositPaidCheck.Size = new Size(128, 21);
            DepositPaidCheck.TabIndex = 0;
            DepositPaidCheck.Text = "Desposit Paid:";
            DepositPaidCheck.TextAlign = ContentAlignment.MiddleRight;
            DepositPaidCheck.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.FromArgb(80, 85, 127);
            ConfirmButton.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmButton.ForeColor = SystemColors.ButtonHighlight;
            ConfirmButton.Location = new Point(356, 472);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(105, 37);
            ConfirmButton.TabIndex = 58;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // TotalAmountText
            // 
            TotalAmountText.AutoSize = true;
            TotalAmountText.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalAmountText.Location = new Point(163, 486);
            TotalAmountText.Margin = new Padding(4, 0, 4, 0);
            TotalAmountText.Name = "TotalAmountText";
            TotalAmountText.Size = new Size(21, 23);
            TotalAmountText.TabIndex = 57;
            TotalAmountText.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(23, 486);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(138, 23);
            label13.TabIndex = 56;
            label13.Text = "Total Amount:";
            // 
            // ReservationAddNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(494, 541);
            Controls.Add(ConfirmButton);
            Controls.Add(TotalAmountText);
            Controls.Add(label13);
            Controls.Add(DepositPaidCheck);
            Controls.Add(DepositReqAmountText);
            Controls.Add(label14);
            Controls.Add(ContactNoText);
            Controls.Add(EmailText);
            Controls.Add(LastNameText);
            Controls.Add(label12);
            Controls.Add(GuestNumText);
            Controls.Add(label11);
            Controls.Add(RoomTypeText);
            Controls.Add(label10);
            Controls.Add(CheckOutPicker);
            Controls.Add(CheckInPicker);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(FirstNameText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ReservationAddNew";
            Text = "Reservation Add New:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker CheckInPicker;
        private System.Windows.Forms.DateTimePicker CheckOutPicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RoomTypeText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GuestNumText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox ContactNoText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label DepositReqAmountText;
        private System.Windows.Forms.CheckBox DepositPaidCheck;
        private Button ConfirmButton;
        private Label TotalAmountText;
        private Label label13;
    }
}

