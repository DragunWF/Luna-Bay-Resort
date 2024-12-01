﻿namespace Luna_Bay_Resort_App.Forms.UserControlForms
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
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            fullStockLabel = new Label();
            lowStockLabel = new Label();
            outOfStockLabel = new Label();
            button2 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Activity = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            ReservationId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            selectedReservation = new DataGridViewCheckBoxColumn();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1316, 76);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 191);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(164, 144);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 22);
            button1.TabIndex = 6;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(132, 104);
            label6.Name = "label6";
            label6.Size = new Size(98, 14);
            label6.TabIndex = 5;
            label6.Text = "PHP 50,000.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(132, 68);
            label5.Name = "label5";
            label5.Size = new Size(98, 14);
            label5.TabIndex = 4;
            label5.Text = "PHP 15,000.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(132, 32);
            label4.Name = "label4";
            label4.Size = new Size(91, 14);
            label4.TabIndex = 3;
            label4.Text = "PHP 1,000.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 104);
            label3.Name = "label3";
            label3.Size = new Size(84, 14);
            label3.TabIndex = 2;
            label3.Text = "This Month:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 68);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 1;
            label2.Text = "This Week:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 14);
            label1.TabIndex = 0;
            label1.Text = "Today:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(fullStockLabel);
            panel2.Controls.Add(lowStockLabel);
            panel2.Controls.Add(outOfStockLabel);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(1316, 394);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 187);
            panel2.TabIndex = 1;
            // 
            // fullStockLabel
            // 
            fullStockLabel.AutoSize = true;
            fullStockLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullStockLabel.Location = new Point(167, 113);
            fullStockLabel.Name = "fullStockLabel";
            fullStockLabel.Size = new Size(56, 14);
            fullStockLabel.TabIndex = 10;
            fullStockLabel.Text = "7 items";
            // 
            // lowStockLabel
            // 
            lowStockLabel.AutoSize = true;
            lowStockLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lowStockLabel.Location = new Point(164, 73);
            lowStockLabel.Name = "lowStockLabel";
            lowStockLabel.Size = new Size(56, 14);
            lowStockLabel.TabIndex = 9;
            lowStockLabel.Text = "5 items";
            // 
            // outOfStockLabel
            // 
            outOfStockLabel.AutoSize = true;
            outOfStockLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outOfStockLabel.Location = new Point(164, 30);
            outOfStockLabel.Name = "outOfStockLabel";
            outOfStockLabel.Size = new Size(56, 14);
            outOfStockLabel.TabIndex = 8;
            outOfStockLabel.Text = "3 items";
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(164, 142);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(66, 22);
            button2.TabIndex = 7;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 113);
            label9.Name = "label9";
            label9.Size = new Size(84, 14);
            label9.TabIndex = 3;
            label9.Text = "Full stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 73);
            label8.Name = "label8";
            label8.Size = new Size(77, 14);
            label8.TabIndex = 2;
            label8.Text = "Low stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 30);
            label7.Name = "label7";
            label7.Size = new Size(98, 14);
            label7.TabIndex = 1;
            label7.Text = "Out of stock:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Activity, Description });
            dataGridView1.Location = new Point(60, 76);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 442);
            dataGridView1.TabIndex = 2;
            // 
            // Activity
            // 
            Activity.HeaderText = "Activity";
            Activity.MinimumWidth = 6;
            Activity.Name = "Activity";
            Activity.ReadOnly = true;
            Activity.Width = 210;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 270;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ReservationId, Name, selectedReservation });
            dataGridView2.Location = new Point(637, 79);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(567, 442);
            dataGridView2.TabIndex = 3;
            // 
            // ReservationId
            // 
            ReservationId.HeaderText = "ReservationId";
            ReservationId.MinimumWidth = 6;
            ReservationId.Name = "ReservationId";
            ReservationId.ReadOnly = true;
            ReservationId.Width = 230;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 260;
            // 
            // selectedReservation
            // 
            selectedReservation.HeaderText = "SelectBox";
            selectedReservation.MinimumWidth = 6;
            selectedReservation.Name = "selectedReservation";
            selectedReservation.Resizable = DataGridViewTriState.True;
            selectedReservation.ToolTipText = "select";
            selectedReservation.Width = 105;
            // 
            // button3
            // 
            button3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1052, 546);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(152, 34);
            button3.TabIndex = 4;
            button3.Text = "CheckIn Now";
            button3.UseVisualStyleBackColor = true;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardUserControl";
            Size = new Size(1662, 675);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label fullStockLabel;
        private Label lowStockLabel;
        private Label outOfStockLabel;
        private Button button2;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button3;
        private DataGridViewTextBoxColumn Activity;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ReservationId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewCheckBoxColumn selectedReservation;
    }
}
