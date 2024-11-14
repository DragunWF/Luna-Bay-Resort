namespace SubForms
{
    partial class CheckOut
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
            CheckInNoText = new TextBox();
            label3 = new Label();
            SearchBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            NameText = new Label();
            CheckInDate = new Label();
            CheckOutDate = new Label();
            RoomTypeText = new Label();
            GuestNumText = new Label();
            label12 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            CheckOutBtn = new Button();
            AmountPaidText = new TextBox();
            BillAmountText = new TextBox();
            AmountDueText = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 36;
            label2.Text = "Check-Out Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 22);
            label1.TabIndex = 35;
            label1.Text = "Form: Check-Out";
            // 
            // CheckInNoText
            // 
            CheckInNoText.Font = new Font("Consolas", 9.75F);
            CheckInNoText.Location = new Point(169, 106);
            CheckInNoText.Margin = new Padding(4, 3, 4, 3);
            CheckInNoText.Name = "CheckInNoText";
            CheckInNoText.Size = new Size(204, 23);
            CheckInNoText.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 37;
            label3.Text = "Check-In No.:";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(80, 85, 127);
            SearchBtn.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(379, 106);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(80, 26);
            SearchBtn.TabIndex = 60;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 163);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 61;
            label4.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 194);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 62;
            label5.Text = "Check-In Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 226);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 63;
            label6.Text = "Check-Out Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 256);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 64;
            label7.Text = "Room Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 289);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 65;
            label8.Text = "No. of Guest:";
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameText.Location = new Point(154, 163);
            NameText.Margin = new Padding(4, 0, 4, 0);
            NameText.Name = "NameText";
            NameText.Size = new Size(14, 15);
            NameText.TabIndex = 66;
            NameText.Text = "-";
            // 
            // CheckInDate
            // 
            CheckInDate.AutoSize = true;
            CheckInDate.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckInDate.Location = new Point(154, 194);
            CheckInDate.Margin = new Padding(4, 0, 4, 0);
            CheckInDate.Name = "CheckInDate";
            CheckInDate.Size = new Size(14, 15);
            CheckInDate.TabIndex = 67;
            CheckInDate.Text = "-";
            // 
            // CheckOutDate
            // 
            CheckOutDate.AutoSize = true;
            CheckOutDate.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckOutDate.Location = new Point(154, 226);
            CheckOutDate.Margin = new Padding(4, 0, 4, 0);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Size = new Size(14, 15);
            CheckOutDate.TabIndex = 68;
            CheckOutDate.Text = "-";
            CheckOutDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // RoomTypeText
            // 
            RoomTypeText.AutoSize = true;
            RoomTypeText.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomTypeText.Location = new Point(154, 256);
            RoomTypeText.Margin = new Padding(4, 0, 4, 0);
            RoomTypeText.Name = "RoomTypeText";
            RoomTypeText.Size = new Size(14, 15);
            RoomTypeText.TabIndex = 69;
            RoomTypeText.Text = "-";
            // 
            // GuestNumText
            // 
            GuestNumText.AutoSize = true;
            GuestNumText.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuestNumText.Location = new Point(154, 289);
            GuestNumText.Margin = new Padding(4, 0, 4, 0);
            GuestNumText.Name = "GuestNumText";
            GuestNumText.Size = new Size(14, 15);
            GuestNumText.TabIndex = 70;
            GuestNumText.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.Location = new Point(31, 340);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(189, 20);
            label12.TabIndex = 71;
            label12.Text = "Payment Information:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 387);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 15);
            label9.TabIndex = 72;
            label9.Text = "Total Amount Paid:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(34, 410);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(133, 15);
            label10.TabIndex = 73;
            label10.Text = "Total Bill Amount:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 20, 41);
            label11.Location = new Point(34, 443);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(179, 23);
            label11.TabIndex = 74;
            label11.Text = "Total Amount Due:";
            // 
            // CheckOutBtn
            // 
            CheckOutBtn.BackColor = Color.FromArgb(245, 211, 108);
            CheckOutBtn.Font = new Font("Consolas", 10.5F, FontStyle.Bold);
            CheckOutBtn.ForeColor = Color.Black;
            CheckOutBtn.Location = new Point(344, 500);
            CheckOutBtn.Name = "CheckOutBtn";
            CheckOutBtn.Size = new Size(138, 29);
            CheckOutBtn.TabIndex = 78;
            CheckOutBtn.Text = "Check-Out Now";
            CheckOutBtn.UseVisualStyleBackColor = false;
            CheckOutBtn.Click += CheckOutBtn_Click;
            // 
            // AmountPaidText
            // 
            AmountPaidText.Font = new Font("Consolas", 9.75F);
            AmountPaidText.Location = new Point(192, 379);
            AmountPaidText.Name = "AmountPaidText";
            AmountPaidText.Size = new Size(128, 23);
            AmountPaidText.TabIndex = 79;
            // 
            // BillAmountText
            // 
            BillAmountText.Font = new Font("Consolas", 9.75F);
            BillAmountText.Location = new Point(192, 407);
            BillAmountText.Name = "BillAmountText";
            BillAmountText.Size = new Size(128, 23);
            BillAmountText.TabIndex = 80;
            // 
            // AmountDueText
            // 
            AmountDueText.Font = new Font("Consolas", 9.75F);
            AmountDueText.Location = new Point(220, 443);
            AmountDueText.Name = "AmountDueText";
            AmountDueText.Size = new Size(100, 23);
            AmountDueText.TabIndex = 81;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(494, 541);
            Controls.Add(AmountDueText);
            Controls.Add(BillAmountText);
            Controls.Add(AmountPaidText);
            Controls.Add(CheckOutBtn);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(GuestNumText);
            Controls.Add(RoomTypeText);
            Controls.Add(CheckOutDate);
            Controls.Add(CheckInDate);
            Controls.Add(NameText);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SearchBtn);
            Controls.Add(CheckInNoText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CheckOut";
            Text = "Check-Out Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox CheckInNoText;
        private Label label3;
        private Button SearchBtn;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label NameText;
        private Label CheckInDate;
        private Label CheckOutDate;
        private Label RoomTypeText;
        private Label GuestNumText;
        private Label label12;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button CheckOutBtn;
        private TextBox AmountPaidText;
        private TextBox BillAmountText;
        private TextBox AmountDueText;
    }
}