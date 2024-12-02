namespace Luna_Bay_Resort_App.Forms.ReservationForms
{
    partial class ViewGuest
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
            dgvReservation = new DataGridView();
            dgvCheckIn = new DataGridView();
            dgvCheckOut = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSearchReservation = new TextBox();
            txtSearchCheckIn = new TextBox();
            txtSearchCheckOut = new TextBox();
            reservationSearchBtn = new Button();
            checkInSearchBtn = new Button();
            checkOutSearchReservation = new Button();
            reservationShowBtn = new Button();
            dtpReservation = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            checkInShowBtn = new Button();
            dtpCheckOut = new DateTimePicker();
            checkOutShowBtn = new Button();
            reservationId = new DataGridViewTextBoxColumn();
            reservationName = new DataGridViewTextBoxColumn();
            checkInDate = new DataGridViewTextBoxColumn();
            checkInId = new DataGridViewTextBoxColumn();
            checkInName = new DataGridViewTextBoxColumn();
            checkOutDate = new DataGridViewTextBoxColumn();
            checkOutId = new DataGridViewTextBoxColumn();
            checkOutName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            SuspendLayout();
            // 
            // dgvReservation
            // 
            dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservation.Columns.AddRange(new DataGridViewColumn[] { reservationId, reservationName, checkInDate });
            dgvReservation.Location = new Point(25, 53);
            dgvReservation.Margin = new Padding(3, 2, 3, 2);
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RowHeadersWidth = 51;
            dgvReservation.Size = new Size(376, 256);
            dgvReservation.TabIndex = 0;
            // 
            // dgvCheckIn
            // 
            dgvCheckIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckIn.Columns.AddRange(new DataGridViewColumn[] { checkInId, checkInName, checkOutDate });
            dgvCheckIn.Location = new Point(444, 53);
            dgvCheckIn.Margin = new Padding(3, 2, 3, 2);
            dgvCheckIn.Name = "dgvCheckIn";
            dgvCheckIn.RowHeadersWidth = 51;
            dgvCheckIn.Size = new Size(374, 256);
            dgvCheckIn.TabIndex = 1;
            // 
            // dgvCheckOut
            // 
            dgvCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckOut.Columns.AddRange(new DataGridViewColumn[] { checkOutId, checkOutName });
            dgvCheckOut.Location = new Point(860, 53);
            dgvCheckOut.Margin = new Padding(3, 2, 3, 2);
            dgvCheckOut.Name = "dgvCheckOut";
            dgvCheckOut.RowHeadersWidth = 51;
            dgvCheckOut.Size = new Size(304, 256);
            dgvCheckOut.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(198, 19);
            label1.TabIndex = 3;
            label1.Text = "List of Reservations:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(444, 26);
            label2.Name = "label2";
            label2.Size = new Size(171, 19);
            label2.TabIndex = 4;
            label2.Text = "List of Check-Ins:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(860, 26);
            label3.Name = "label3";
            label3.Size = new Size(180, 19);
            label3.TabIndex = 5;
            label3.Text = "List of Check-Outs:";
            // 
            // txtSearchReservation
            // 
            txtSearchReservation.Location = new Point(25, 323);
            txtSearchReservation.Margin = new Padding(3, 2, 3, 2);
            txtSearchReservation.Name = "txtSearchReservation";
            txtSearchReservation.Size = new Size(266, 23);
            txtSearchReservation.TabIndex = 6;
            // 
            // txtSearchCheckIn
            // 
            txtSearchCheckIn.Location = new Point(444, 323);
            txtSearchCheckIn.Margin = new Padding(3, 2, 3, 2);
            txtSearchCheckIn.Name = "txtSearchCheckIn";
            txtSearchCheckIn.Size = new Size(262, 23);
            txtSearchCheckIn.TabIndex = 7;
            // 
            // txtSearchCheckOut
            // 
            txtSearchCheckOut.Location = new Point(860, 323);
            txtSearchCheckOut.Margin = new Padding(3, 2, 3, 2);
            txtSearchCheckOut.Name = "txtSearchCheckOut";
            txtSearchCheckOut.Size = new Size(211, 23);
            txtSearchCheckOut.TabIndex = 8;
            // 
            // reservationSearchBtn
            // 
            reservationSearchBtn.Location = new Point(332, 323);
            reservationSearchBtn.Margin = new Padding(3, 2, 3, 2);
            reservationSearchBtn.Name = "reservationSearchBtn";
            reservationSearchBtn.Size = new Size(69, 20);
            reservationSearchBtn.TabIndex = 9;
            reservationSearchBtn.Text = "Search";
            reservationSearchBtn.UseVisualStyleBackColor = true;
            reservationSearchBtn.Click += reservationSearchBtn_Click;
            // 
            // checkInSearchBtn
            // 
            checkInSearchBtn.Location = new Point(749, 323);
            checkInSearchBtn.Margin = new Padding(3, 2, 3, 2);
            checkInSearchBtn.Name = "checkInSearchBtn";
            checkInSearchBtn.Size = new Size(69, 20);
            checkInSearchBtn.TabIndex = 10;
            checkInSearchBtn.Text = "Search";
            checkInSearchBtn.UseVisualStyleBackColor = true;
            checkInSearchBtn.Click += checkInSearchBtn_Click;
            // 
            // checkOutSearchReservation
            // 
            checkOutSearchReservation.Location = new Point(1096, 323);
            checkOutSearchReservation.Margin = new Padding(3, 2, 3, 2);
            checkOutSearchReservation.Name = "checkOutSearchReservation";
            checkOutSearchReservation.Size = new Size(69, 20);
            checkOutSearchReservation.TabIndex = 11;
            checkOutSearchReservation.Text = "Search";
            checkOutSearchReservation.UseVisualStyleBackColor = true;
            checkOutSearchReservation.Click += checkOutSearchReservation_Click;
            // 
            // reservationShowBtn
            // 
            reservationShowBtn.Location = new Point(332, 359);
            reservationShowBtn.Margin = new Padding(3, 2, 3, 2);
            reservationShowBtn.Name = "reservationShowBtn";
            reservationShowBtn.Size = new Size(69, 20);
            reservationShowBtn.TabIndex = 13;
            reservationShowBtn.Text = "Show";
            reservationShowBtn.UseVisualStyleBackColor = true;
            reservationShowBtn.Click += reservationShowBtn_Click;
            // 
            // dtpReservation
            // 
            dtpReservation.CustomFormat = "";
            dtpReservation.Location = new Point(25, 361);
            dtpReservation.Margin = new Padding(3, 2, 3, 2);
            dtpReservation.Name = "dtpReservation";
            dtpReservation.Size = new Size(266, 23);
            dtpReservation.TabIndex = 12;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(444, 359);
            dtpCheckIn.Margin = new Padding(3, 2, 3, 2);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(262, 23);
            dtpCheckIn.TabIndex = 14;
            // 
            // checkInShowBtn
            // 
            checkInShowBtn.Location = new Point(749, 359);
            checkInShowBtn.Margin = new Padding(3, 2, 3, 2);
            checkInShowBtn.Name = "checkInShowBtn";
            checkInShowBtn.Size = new Size(69, 20);
            checkInShowBtn.TabIndex = 15;
            checkInShowBtn.Text = "Show";
            checkInShowBtn.UseVisualStyleBackColor = true;
            checkInShowBtn.Click += checkInShowBtn_Click;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(860, 361);
            dtpCheckOut.Margin = new Padding(3, 2, 3, 2);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(211, 23);
            dtpCheckOut.TabIndex = 16;
            // 
            // checkOutShowBtn
            // 
            checkOutShowBtn.Location = new Point(1096, 359);
            checkOutShowBtn.Margin = new Padding(3, 2, 3, 2);
            checkOutShowBtn.Name = "checkOutShowBtn";
            checkOutShowBtn.Size = new Size(69, 20);
            checkOutShowBtn.TabIndex = 17;
            checkOutShowBtn.Text = "Show";
            checkOutShowBtn.UseVisualStyleBackColor = true;
            checkOutShowBtn.Click += checkOutShowBtn_Click;
            // 
            // reservationId
            // 
            reservationId.HeaderText = "ID";
            reservationId.MinimumWidth = 6;
            reservationId.Name = "reservationId";
            reservationId.Width = 80;
            // 
            // reservationName
            // 
            reservationName.HeaderText = "Name";
            reservationName.MinimumWidth = 6;
            reservationName.Name = "reservationName";
            reservationName.Width = 125;
            // 
            // checkInDate
            // 
            checkInDate.HeaderText = "Check In Date";
            checkInDate.MinimumWidth = 6;
            checkInDate.Name = "checkInDate";
            checkInDate.Width = 125;
            // 
            // checkInId
            // 
            checkInId.HeaderText = "ID";
            checkInId.MinimumWidth = 6;
            checkInId.Name = "checkInId";
            checkInId.Width = 80;
            // 
            // checkInName
            // 
            checkInName.HeaderText = "Name";
            checkInName.MinimumWidth = 6;
            checkInName.Name = "checkInName";
            checkInName.Width = 125;
            // 
            // checkOutDate
            // 
            checkOutDate.HeaderText = "Check-out Date";
            checkOutDate.MinimumWidth = 6;
            checkOutDate.Name = "checkOutDate";
            checkOutDate.Width = 125;
            // 
            // checkOutId
            // 
            checkOutId.HeaderText = "ID";
            checkOutId.MinimumWidth = 6;
            checkOutId.Name = "checkOutId";
            checkOutId.Width = 80;
            // 
            // checkOutName
            // 
            checkOutName.HeaderText = "Name";
            checkOutName.MinimumWidth = 6;
            checkOutName.Name = "checkOutName";
            checkOutName.Width = 170;
            // 
            // ViewGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 411);
            Controls.Add(checkOutShowBtn);
            Controls.Add(dtpCheckOut);
            Controls.Add(checkInShowBtn);
            Controls.Add(dtpCheckIn);
            Controls.Add(reservationShowBtn);
            Controls.Add(dtpReservation);
            Controls.Add(checkOutSearchReservation);
            Controls.Add(checkInSearchBtn);
            Controls.Add(reservationSearchBtn);
            Controls.Add(txtSearchCheckOut);
            Controls.Add(txtSearchCheckIn);
            Controls.Add(txtSearchReservation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCheckOut);
            Controls.Add(dgvCheckIn);
            Controls.Add(dgvReservation);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewGuest";
            Text = "ViewGuest";
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservation;
        private DataGridView dgvCheckIn;
        private DataGridView dgvCheckOut;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSearchReservation;
        private TextBox txtSearchCheckIn;
        private TextBox txtSearchCheckOut;
        private Button reservationSearchBtn;
        private Button checkInSearchBtn;
        private Button checkOutSearchReservation;
        private Button reservationShowBtn;
        private DateTimePicker dtpReservation;
        private DateTimePicker dtpCheckIn;
        private Button checkInShowBtn;
        private DateTimePicker dtpCheckOut;
        private Button checkOutShowBtn;
        private DataGridViewTextBoxColumn reservationId;
        private DataGridViewTextBoxColumn reservationName;
        private DataGridViewTextBoxColumn checkInDate;
        private DataGridViewTextBoxColumn checkInId;
        private DataGridViewTextBoxColumn checkInName;
        private DataGridViewTextBoxColumn checkOutDate;
        private DataGridViewTextBoxColumn checkOutId;
        private DataGridViewTextBoxColumn checkOutName;
    }
}