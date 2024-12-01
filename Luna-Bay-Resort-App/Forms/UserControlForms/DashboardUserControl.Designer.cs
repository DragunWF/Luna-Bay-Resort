namespace Luna_Bay_Resort_App.Forms.UserControlForms
{
    partial class DashboardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            monthLabel = new Label();
            weekLabel = new Label();
            todayLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            fullStockLabel = new Label();
            lowStockLabel = new Label();
            outOfStockLabel = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            activitiesDataGrid = new DataGridView();
            Description = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            reservationsDataGrid = new DataGridView();
            CheckInBtn = new Button();
            RefreshBtn = new Button();
            ReservationId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Select = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activitiesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(monthLabel);
            panel1.Controls.Add(weekLabel);
            panel1.Controls.Add(todayLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1316, 76);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 191);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 13);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 12;
            label5.Text = "Revenue";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthLabel.Location = new Point(132, 129);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(98, 14);
            monthLabel.TabIndex = 5;
            monthLabel.Text = "PHP 50,000.00";
            // 
            // weekLabel
            // 
            weekLabel.AutoSize = true;
            weekLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            weekLabel.Location = new Point(132, 90);
            weekLabel.Name = "weekLabel";
            weekLabel.Size = new Size(98, 14);
            weekLabel.TabIndex = 4;
            weekLabel.Text = "PHP 15,000.00";
            // 
            // todayLabel
            // 
            todayLabel.AutoSize = true;
            todayLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todayLabel.Location = new Point(132, 51);
            todayLabel.Name = "todayLabel";
            todayLabel.Size = new Size(91, 14);
            todayLabel.TabIndex = 3;
            todayLabel.Text = "PHP 1,000.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 129);
            label3.Name = "label3";
            label3.Size = new Size(84, 14);
            label3.TabIndex = 2;
            label3.Text = "This Month:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 90);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 1;
            label2.Text = "This Week:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 51);
            label1.Name = "label1";
            label1.Size = new Size(49, 14);
            label1.TabIndex = 0;
            label1.Text = "Today:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(fullStockLabel);
            panel2.Controls.Add(lowStockLabel);
            panel2.Controls.Add(outOfStockLabel);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(1316, 394);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 187);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 15);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 11;
            label4.Text = "Stock";
            // 
            // fullStockLabel
            // 
            fullStockLabel.AutoSize = true;
            fullStockLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullStockLabel.Location = new Point(164, 128);
            fullStockLabel.Name = "fullStockLabel";
            fullStockLabel.Size = new Size(56, 14);
            fullStockLabel.TabIndex = 10;
            fullStockLabel.Text = "7 items";
            // 
            // lowStockLabel
            // 
            lowStockLabel.AutoSize = true;
            lowStockLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lowStockLabel.Location = new Point(164, 90);
            lowStockLabel.Name = "lowStockLabel";
            lowStockLabel.Size = new Size(56, 14);
            lowStockLabel.TabIndex = 9;
            lowStockLabel.Text = "5 items";
            // 
            // outOfStockLabel
            // 
            outOfStockLabel.AutoSize = true;
            outOfStockLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outOfStockLabel.Location = new Point(164, 55);
            outOfStockLabel.Name = "outOfStockLabel";
            outOfStockLabel.Size = new Size(56, 14);
            outOfStockLabel.TabIndex = 8;
            outOfStockLabel.Text = "3 items";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 128);
            label9.Name = "label9";
            label9.Size = new Size(84, 14);
            label9.TabIndex = 3;
            label9.Text = "Full stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 90);
            label8.Name = "label8";
            label8.Size = new Size(77, 14);
            label8.TabIndex = 2;
            label8.Text = "Low stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 55);
            label7.Name = "label7";
            label7.Size = new Size(98, 14);
            label7.TabIndex = 1;
            label7.Text = "Out of stock:";
            // 
            // activitiesDataGrid
            // 
            activitiesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activitiesDataGrid.Columns.AddRange(new DataGridViewColumn[] { Description, Date });
            activitiesDataGrid.Location = new Point(60, 76);
            activitiesDataGrid.Margin = new Padding(3, 2, 3, 2);
            activitiesDataGrid.Name = "activitiesDataGrid";
            activitiesDataGrid.RowHeadersWidth = 51;
            activitiesDataGrid.Size = new Size(466, 442);
            activitiesDataGrid.TabIndex = 2;
            // 
            // Description
            // 
            Description.HeaderText = "Activity Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 290;
            // 
            // Date
            // 
            Date.HeaderText = "Activity Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // reservationsDataGrid
            // 
            reservationsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationsDataGrid.Columns.AddRange(new DataGridViewColumn[] { ReservationId, Name, Select });
            reservationsDataGrid.Location = new Point(637, 79);
            reservationsDataGrid.Margin = new Padding(3, 2, 3, 2);
            reservationsDataGrid.Name = "reservationsDataGrid";
            reservationsDataGrid.RowHeadersWidth = 51;
            reservationsDataGrid.Size = new Size(567, 442);
            reservationsDataGrid.TabIndex = 3;
            // 
            // CheckInBtn
            // 
            CheckInBtn.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInBtn.Location = new Point(1052, 546);
            CheckInBtn.Margin = new Padding(3, 2, 3, 2);
            CheckInBtn.Name = "CheckInBtn";
            CheckInBtn.Size = new Size(152, 34);
            CheckInBtn.TabIndex = 4;
            CheckInBtn.Text = "CheckIn Now";
            CheckInBtn.UseVisualStyleBackColor = true;
            CheckInBtn.Click += CheckInBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RefreshBtn.Location = new Point(882, 546);
            RefreshBtn.Margin = new Padding(3, 2, 3, 2);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(152, 34);
            RefreshBtn.TabIndex = 5;
            RefreshBtn.Text = "Refresh All";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // ReservationId
            // 
            ReservationId.HeaderText = "ReservationId";
            ReservationId.MinimumWidth = 6;
            ReservationId.Name = "ReservationId";
            ReservationId.ReadOnly = true;
            ReservationId.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 315;
            // 
            // Select
            // 
            Select.HeaderText = "Select";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Resizable = DataGridViewTriState.True;
            Select.ToolTipText = "select";
            Select.Width = 80;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(RefreshBtn);
            Controls.Add(CheckInBtn);
            Controls.Add(reservationsDataGrid);
            Controls.Add(activitiesDataGrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            //Name = "DashboardUserControl";
            Size = new Size(1662, 675);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)activitiesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label monthLabel;
        private Label weekLabel;
        private Label todayLabel;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label fullStockLabel;
        private Label lowStockLabel;
        private Label outOfStockLabel;
        private Label label9;
        private DataGridView activitiesDataGrid;
        private DataGridView reservationsDataGrid;
        private Button CheckInBtn;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
        private Button RefreshBtn;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn ReservationId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewCheckBoxColumn Select;
    }
}
