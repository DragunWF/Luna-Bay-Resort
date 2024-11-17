namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    partial class ViewAccountsForm
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
            dataGridView1 = new DataGridView();
            EmpID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Checkbox = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            resetBtn = new Button();
            searchBtn = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmpID, Username, Position, Checkbox });
            dataGridView1.Location = new Point(57, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(553, 372);
            dataGridView1.TabIndex = 0;
            // 
            // EmpID
            // 
            EmpID.HeaderText = "Employee ID";
            EmpID.MinimumWidth = 6;
            EmpID.Name = "EmpID";
            EmpID.Width = 125;
            // 
            // Username
            // 
            Username.HeaderText = "Name";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.Width = 125;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 125;
            // 
            // Checkbox
            // 
            Checkbox.HeaderText = "Reset Password";
            Checkbox.MinimumWidth = 6;
            Checkbox.Name = "Checkbox";
            Checkbox.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 41);
            label1.Name = "label1";
            label1.Size = new Size(287, 36);
            label1.TabIndex = 1;
            label1.Text = "List Of Accounts:";
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.Location = new Point(516, 493);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(416, 493);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(57, 495);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(353, 27);
            txtSearch.TabIndex = 4;
            // 
            // ViewAccountsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 558);
            Controls.Add(txtSearch);
            Controls.Add(searchBtn);
            Controls.Add(resetBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ViewAccountsForm";
            Text = "ViewAccountsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmpID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewCheckBoxColumn Checkbox;
        private Label label1;
        private Button resetBtn;
        private Button searchBtn;
        private TextBox txtSearch;
    }
}