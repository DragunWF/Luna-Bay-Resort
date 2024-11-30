namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    partial class ManageAccountsForm
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
            accountsDataGrid = new DataGridView();
            EmpID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            ResetPassword = new DataGridViewCheckBoxColumn();
            Delete = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            ResetBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            DeleteBtn = new Button();
            RefreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)accountsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // accountsDataGrid
            // 
            accountsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsDataGrid.Columns.AddRange(new DataGridViewColumn[] { EmpID, Username, Position, ResetPassword, Delete });
            accountsDataGrid.Location = new Point(50, 84);
            accountsDataGrid.Margin = new Padding(3, 2, 3, 2);
            accountsDataGrid.Name = "accountsDataGrid";
            accountsDataGrid.RowHeadersWidth = 51;
            accountsDataGrid.Size = new Size(674, 270);
            accountsDataGrid.TabIndex = 0;
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
            Username.HeaderText = "Username";
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
            // ResetPassword
            // 
            ResetPassword.HeaderText = "Reset Password";
            ResetPassword.MinimumWidth = 6;
            ResetPassword.Name = "ResetPassword";
            ResetPassword.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete ";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 31);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 1;
            label1.Text = "List Of Accounts:";
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.Location = new Point(452, 370);
            ResetBtn.Margin = new Padding(3, 2, 3, 2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(82, 22);
            ResetBtn.TabIndex = 2;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(364, 370);
            SearchBtn.Margin = new Padding(3, 2, 3, 2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(82, 22);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(50, 371);
            SearchTxt.Margin = new Padding(3, 2, 3, 2);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(309, 23);
            SearchTxt.TabIndex = 4;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(540, 370);
            DeleteBtn.Margin = new Padding(3, 2, 3, 2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(82, 22);
            DeleteBtn.TabIndex = 5;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshBtn.Location = new Point(628, 370);
            RefreshBtn.Margin = new Padding(3, 2, 3, 2);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(82, 22);
            RefreshBtn.TabIndex = 6;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // ManageAccountsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 418);
            Controls.Add(RefreshBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(SearchTxt);
            Controls.Add(SearchBtn);
            Controls.Add(ResetBtn);
            Controls.Add(label1);
            Controls.Add(accountsDataGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageAccountsForm";
            Text = "Manage Accounts Form";
            ((System.ComponentModel.ISupportInitialize)accountsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView accountsDataGrid;
        private Label label1;
        private Button ResetBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private Button DeleteBtn;
        private DataGridViewTextBoxColumn EmpID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewCheckBoxColumn ResetPassword;
        private DataGridViewCheckBoxColumn Delete;
        private Button RefreshBtn;
    }
}