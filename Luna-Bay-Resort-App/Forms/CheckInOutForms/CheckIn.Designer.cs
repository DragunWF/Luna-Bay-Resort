namespace SubForms
{
    partial class CheckIn
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
            ConfirmBtn = new Button();
            TotalAmountText = new Label();
            ContactNoText = new TextBox();
            EmailText = new TextBox();
            LastNameText = new TextBox();
            label13 = new Label();
            label12 = new Label();
            GuestNumText = new TextBox();
            label11 = new Label();
            label10 = new Label();
            CheckOutPicker = new DateTimePicker();
            CheckInPicker = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            FirstNameText = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CashCheckBox = new CheckBox();
            label14 = new Label();
            OnlinePaymentCheckBox = new CheckBox();
            CardCheckBox = new CheckBox();
            SearchBtn = new Button();
            RoomTypeCB = new ComboBox();
            SuspendLayout();
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.FromArgb(80, 85, 127);
            ConfirmBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmBtn.ForeColor = SystemColors.ButtonHighlight;
            ConfirmBtn.Location = new Point(365, 480);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(105, 37);
            ConfirmBtn.TabIndex = 55;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // TotalAmountText
            // 
            TotalAmountText.AutoSize = true;
            TotalAmountText.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalAmountText.Location = new Point(174, 487);
            TotalAmountText.Margin = new Padding(4, 0, 4, 0);
            TotalAmountText.Name = "TotalAmountText";
            TotalAmountText.Size = new Size(21, 23);
            TotalAmountText.TabIndex = 54;
            TotalAmountText.Text = "0";
            // 
            // ContactNoText
            // 
            ContactNoText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactNoText.Location = new Point(266, 202);
            ContactNoText.Margin = new Padding(4, 3, 4, 3);
            ContactNoText.Name = "ContactNoText";
            ContactNoText.Size = new Size(204, 24);
            ContactNoText.TabIndex = 51;
            // 
            // EmailText
            // 
            EmailText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailText.Location = new Point(32, 202);
            EmailText.Margin = new Padding(4, 3, 4, 3);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(204, 24);
            EmailText.TabIndex = 50;
            // 
            // LastNameText
            // 
            LastNameText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameText.Location = new Point(266, 138);
            LastNameText.Margin = new Padding(4, 3, 4, 3);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(204, 24);
            LastNameText.TabIndex = 49;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(32, 487);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(138, 23);
            label13.TabIndex = 48;
            label13.Text = "Total Amount:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.Location = new Point(32, 376);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(189, 20);
            label12.TabIndex = 47;
            label12.Text = "Payment Information:";
            // 
            // GuestNumText
            // 
            GuestNumText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuestNumText.Location = new Point(426, 336);
            GuestNumText.Margin = new Padding(4, 3, 4, 3);
            GuestNumText.Name = "GuestNumText";
            GuestNumText.Size = new Size(44, 24);
            GuestNumText.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(308, 342);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 18);
            label11.TabIndex = 45;
            label11.Text = "No. of Guests:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(32, 342);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 18);
            label10.TabIndex = 43;
            label10.Text = "Room Type:";
            // 
            // CheckOutPicker
            // 
            CheckOutPicker.CustomFormat = "M/dd/yyyy hh:mm";
            CheckOutPicker.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckOutPicker.Format = DateTimePickerFormat.Custom;
            CheckOutPicker.Location = new Point(266, 296);
            CheckOutPicker.Margin = new Padding(4, 3, 4, 3);
            CheckOutPicker.Name = "CheckOutPicker";
            CheckOutPicker.Size = new Size(204, 24);
            CheckOutPicker.TabIndex = 42;
            // 
            // CheckInPicker
            // 
            CheckInPicker.CustomFormat = "M/dd/yyyy hh:mm";
            CheckInPicker.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckInPicker.Format = DateTimePickerFormat.Custom;
            CheckInPicker.Location = new Point(32, 296);
            CheckInPicker.Margin = new Padding(4, 3, 4, 3);
            CheckInPicker.Name = "CheckInPicker";
            CheckInPicker.Size = new Size(204, 24);
            CheckInPicker.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 11.25F);
            label8.Location = new Point(266, 275);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 18);
            label8.TabIndex = 40;
            label8.Text = "Check-Out Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 11.25F);
            label9.Location = new Point(32, 275);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 18);
            label9.TabIndex = 39;
            label9.Text = "Check-In Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 240);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(180, 20);
            label7.TabIndex = 38;
            label7.Text = "Reservation Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F);
            label6.Location = new Point(266, 180);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 18);
            label6.TabIndex = 37;
            label6.Text = "Contact No.:";
            // 
            // FirstNameText
            // 
            FirstNameText.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameText.Location = new Point(32, 138);
            FirstNameText.Margin = new Padding(4, 3, 4, 3);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(204, 24);
            FirstNameText.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F);
            label5.Location = new Point(32, 180);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 18);
            label5.TabIndex = 35;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F);
            label4.Location = new Point(266, 116);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 34;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F);
            label3.Location = new Point(32, 116);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 18);
            label3.TabIndex = 33;
            label3.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 32;
            label2.Text = "Customer Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 30;
            label1.Text = "Form: Check-In";
            // 
            // CashCheckBox
            // 
            CashCheckBox.AutoSize = true;
            CashCheckBox.Font = new Font("Consolas", 10F);
            CashCheckBox.Location = new Point(33, 441);
            CashCheckBox.Name = "CashCheckBox";
            CashCheckBox.Size = new Size(59, 21);
            CashCheckBox.TabIndex = 56;
            CashCheckBox.Text = "Cash";
            CashCheckBox.UseVisualStyleBackColor = true;
            CashCheckBox.CheckedChanged += CashCheckBox_CheckedChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(32, 410);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(128, 18);
            label14.TabIndex = 57;
            label14.Text = "Payment Method:";
            // 
            // OnlinePaymentCheckBox
            // 
            OnlinePaymentCheckBox.AutoSize = true;
            OnlinePaymentCheckBox.Font = new Font("Consolas", 10F);
            OnlinePaymentCheckBox.Location = new Point(102, 441);
            OnlinePaymentCheckBox.Name = "OnlinePaymentCheckBox";
            OnlinePaymentCheckBox.Size = new Size(139, 21);
            OnlinePaymentCheckBox.TabIndex = 58;
            OnlinePaymentCheckBox.Text = "Online Payment";
            OnlinePaymentCheckBox.UseVisualStyleBackColor = true;
            OnlinePaymentCheckBox.CheckedChanged += OnlinePaymentCheckBox_CheckedChanged;
            // 
            // CardCheckBox
            // 
            CardCheckBox.AutoSize = true;
            CardCheckBox.Font = new Font("Consolas", 10F);
            CardCheckBox.Location = new Point(247, 441);
            CardCheckBox.Name = "CardCheckBox";
            CardCheckBox.Size = new Size(171, 21);
            CardCheckBox.TabIndex = 59;
            CardCheckBox.Text = "Debit/ Credit Card";
            CardCheckBox.UseVisualStyleBackColor = true;
            CardCheckBox.CheckedChanged += CardCheckBox_CheckedChanged;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(80, 85, 127);
            SearchBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(247, 480);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(105, 37);
            SearchBtn.TabIndex = 60;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // RoomTypeCB
            // 
            RoomTypeCB.FormattingEnabled = true;
            RoomTypeCB.Location = new Point(120, 336);
            RoomTypeCB.Name = "RoomTypeCB";
            RoomTypeCB.Size = new Size(181, 23);
            RoomTypeCB.TabIndex = 61;
            // 
            // CheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(494, 541);
            Controls.Add(RoomTypeCB);
            Controls.Add(SearchBtn);
            Controls.Add(CardCheckBox);
            Controls.Add(OnlinePaymentCheckBox);
            Controls.Add(label14);
            Controls.Add(CashCheckBox);
            Controls.Add(ConfirmBtn);
            Controls.Add(TotalAmountText);
            Controls.Add(ContactNoText);
            Controls.Add(EmailText);
            Controls.Add(LastNameText);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(GuestNumText);
            Controls.Add(label11);
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
            Name = "CheckIn";
            Text = "Check-In Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmBtn;
        private Label TotalAmountText;
        private TextBox ContactNoText;
        private TextBox EmailText;
        private TextBox LastNameText;
        private Label label13;
        private Label label12;
        private TextBox GuestNumText;
        private Label label11;
        private Label label10;
        private DateTimePicker CheckOutPicker;
        private DateTimePicker CheckInPicker;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label6;
        private TextBox FirstNameText;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox CashCheckBox;
        private Label label14;
        private CheckBox OnlinePaymentCheckBox;
        private CheckBox CardCheckBox;
        private Button SearchBtn;
        private ComboBox RoomTypeCB;
    }
}