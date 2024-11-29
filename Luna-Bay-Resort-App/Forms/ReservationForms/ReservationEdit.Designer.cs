namespace SubForms
{
    partial class ReservationEdit
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
            ReservationNoText = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            CheckOutPicker = new DateTimePicker();
            CheckInPicker = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            ConfirmBtn = new Button();
            label13 = new Label();
            RoomTypeCB = new ComboBox();
            TotalAmountText = new TextBox();
            DepositText = new TextBox();
            SearchBtn = new Button();
            AddPaxbtn = new Button();
            Paxlbl = new Label();
            label11 = new Label();
            Paidtxt = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // ReservationNoText
            // 
            ReservationNoText.Font = new Font("Consolas", 9.75F);
            ReservationNoText.Location = new Point(164, 135);
            ReservationNoText.Margin = new Padding(4, 3, 4, 3);
            ReservationNoText.Name = "ReservationNoText";
            ReservationNoText.Size = new Size(204, 23);
            ReservationNoText.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 6;
            label3.Text = "Reservation No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 38;
            label2.Text = "Update Reservation Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 22);
            label1.TabIndex = 37;
            label1.Text = "Form: Edit reservation";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(255, 20, 41);
            label14.Location = new Point(23, 420);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(161, 16);
            label14.TabIndex = 51;
            label14.Text = "Amount of Req. Deposit:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.Location = new Point(23, 336);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(189, 20);
            label12.TabIndex = 49;
            label12.Text = "Payment Information:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(23, 282);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 18);
            label10.TabIndex = 45;
            label10.Text = "Room Type:";
            // 
            // CheckOutPicker
            // 
            CheckOutPicker.CustomFormat = "M/dd/yyyy hh:mm";
            CheckOutPicker.Font = new Font("Consolas", 9.75F);
            CheckOutPicker.Format = DateTimePickerFormat.Custom;
            CheckOutPicker.Location = new Point(257, 214);
            CheckOutPicker.Margin = new Padding(4, 3, 4, 3);
            CheckOutPicker.Name = "CheckOutPicker";
            CheckOutPicker.Size = new Size(204, 23);
            CheckOutPicker.TabIndex = 44;
            // 
            // CheckInPicker
            // 
            CheckInPicker.CustomFormat = "M/dd/yyyy hh:mm";
            CheckInPicker.Font = new Font("Consolas", 9.75F);
            CheckInPicker.Format = DateTimePickerFormat.Custom;
            CheckInPicker.Location = new Point(23, 214);
            CheckInPicker.Margin = new Padding(4, 3, 4, 3);
            CheckInPicker.Name = "CheckInPicker";
            CheckInPicker.Size = new Size(204, 23);
            CheckInPicker.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9.75F);
            label8.Location = new Point(257, 193);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 42;
            label8.Text = "Check-Out Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 11.25F);
            label9.Location = new Point(23, 193);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 18);
            label9.TabIndex = 41;
            label9.Text = "Check-In Date:";
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.FromArgb(80, 85, 127);
            ConfirmBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmBtn.ForeColor = SystemColors.ButtonHighlight;
            ConfirmBtn.Location = new Point(356, 456);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(105, 37);
            ConfirmBtn.TabIndex = 58;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(23, 463);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(138, 23);
            label13.TabIndex = 56;
            label13.Text = "Total Amount:";
            // 
            // RoomTypeCB
            // 
            RoomTypeCB.Font = new Font("Consolas", 9.75F);
            RoomTypeCB.FormattingEnabled = true;
            RoomTypeCB.Location = new Point(111, 276);
            RoomTypeCB.Name = "RoomTypeCB";
            RoomTypeCB.Size = new Size(181, 23);
            RoomTypeCB.TabIndex = 64;
            RoomTypeCB.SelectedValueChanged += RoomTypeCB_SelectedValueChanged;
            // 
            // TotalAmountText
            // 
            TotalAmountText.Font = new Font("Consolas", 9.75F);
            TotalAmountText.Location = new Point(168, 464);
            TotalAmountText.Name = "TotalAmountText";
            TotalAmountText.Size = new Size(124, 23);
            TotalAmountText.TabIndex = 68;
            // 
            // DepositText
            // 
            DepositText.Font = new Font("Consolas", 9.75F);
            DepositText.Location = new Point(190, 414);
            DepositText.Name = "DepositText";
            DepositText.Size = new Size(100, 23);
            DepositText.TabIndex = 67;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(80, 85, 127);
            SearchBtn.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(381, 131);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(80, 29);
            SearchBtn.TabIndex = 69;
            SearchBtn.Text = "Select";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SelectBtn_Click;
            // 
            // AddPaxbtn
            // 
            AddPaxbtn.BackColor = Color.Green;
            AddPaxbtn.Font = new Font("Consolas", 11F);
            AddPaxbtn.ForeColor = Color.White;
            AddPaxbtn.Location = new Point(381, 270);
            AddPaxbtn.Name = "AddPaxbtn";
            AddPaxbtn.Size = new Size(83, 30);
            AddPaxbtn.TabIndex = 76;
            AddPaxbtn.Text = "Add Pax";
            AddPaxbtn.UseVisualStyleBackColor = false;
            AddPaxbtn.Click += AddPaxbtn_Click;
            // 
            // Paxlbl
            // 
            Paxlbl.AutoSize = true;
            Paxlbl.Font = new Font("Consolas", 11.25F);
            Paxlbl.Location = new Point(337, 277);
            Paxlbl.Name = "Paxlbl";
            Paxlbl.Size = new Size(16, 18);
            Paxlbl.TabIndex = 75;
            Paxlbl.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(302, 277);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(40, 18);
            label11.TabIndex = 74;
            label11.Text = "Pax:";
            // 
            // Paidtxt
            // 
            Paidtxt.Font = new Font("Consolas", 9.75F);
            Paidtxt.Location = new Point(190, 373);
            Paidtxt.Name = "Paidtxt";
            Paidtxt.Size = new Size(100, 23);
            Paidtxt.TabIndex = 78;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 379);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 16);
            label4.TabIndex = 77;
            label4.Text = "Currently Paid Amount";
            // 
            // ReservationEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(494, 541);
            Controls.Add(Paidtxt);
            Controls.Add(label4);
            Controls.Add(AddPaxbtn);
            Controls.Add(Paxlbl);
            Controls.Add(label11);
            Controls.Add(SearchBtn);
            Controls.Add(TotalAmountText);
            Controls.Add(DepositText);
            Controls.Add(RoomTypeCB);
            Controls.Add(ConfirmBtn);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(CheckOutPicker);
            Controls.Add(CheckInPicker);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReservationNoText);
            Controls.Add(label3);
            Name = "ReservationEdit";
            Text = "Edit Reservation Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ReservationNoText;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label14;
        private Label label12;
        private Label label10;
        private DateTimePicker CheckOutPicker;
        private DateTimePicker CheckInPicker;
        private Label label8;
        private Label label9;
        private Button ConfirmBtn;
        private Label label13;
        private ComboBox RoomTypeCB;
        private TextBox TotalAmountText;
        private TextBox DepositText;
        private Button SearchBtn;
        private Button AddPaxbtn;
        private Label Paxlbl;
        private Label label11;
        private TextBox Paidtxt;
        private Label label4;
    }
}