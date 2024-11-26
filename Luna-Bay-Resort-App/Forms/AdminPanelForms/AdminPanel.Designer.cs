namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    partial class AdminPanel
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
            ResetAccountBtn = new Button();
            AddAccountBtn = new Button();
            DeleteAccountBtn = new Button();
            ViewAccountsBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 0;
            label1.Text = "Admin Control:";
            // 
            // ResetAccountBtn
            // 
            ResetAccountBtn.Location = new Point(20, 111);
            ResetAccountBtn.Margin = new Padding(3, 2, 3, 2);
            ResetAccountBtn.Name = "ResetAccountBtn";
            ResetAccountBtn.Size = new Size(170, 22);
            ResetAccountBtn.TabIndex = 1;
            ResetAccountBtn.Text = "Reset Accounts";
            ResetAccountBtn.UseVisualStyleBackColor = true;
            ResetAccountBtn.Click += ResetAccountBtn_Click;
            // 
            // AddAccountBtn
            // 
            AddAccountBtn.Location = new Point(20, 58);
            AddAccountBtn.Margin = new Padding(3, 2, 3, 2);
            AddAccountBtn.Name = "AddAccountBtn";
            AddAccountBtn.Size = new Size(170, 22);
            AddAccountBtn.TabIndex = 2;
            AddAccountBtn.Text = "Add New Account";
            AddAccountBtn.UseVisualStyleBackColor = true;
            AddAccountBtn.Click += AddAccountBtn_Click;
            // 
            // DeleteAccountBtn
            // 
            DeleteAccountBtn.Location = new Point(20, 137);
            DeleteAccountBtn.Margin = new Padding(3, 2, 3, 2);
            DeleteAccountBtn.Name = "DeleteAccountBtn";
            DeleteAccountBtn.Size = new Size(170, 22);
            DeleteAccountBtn.TabIndex = 3;
            DeleteAccountBtn.Text = "Delete Account";
            DeleteAccountBtn.UseVisualStyleBackColor = true;
            DeleteAccountBtn.Click += DeleteAccountBtn_Click;
            // 
            // ViewAccountsBtn
            // 
            ViewAccountsBtn.Location = new Point(20, 85);
            ViewAccountsBtn.Margin = new Padding(3, 2, 3, 2);
            ViewAccountsBtn.Name = "ViewAccountsBtn";
            ViewAccountsBtn.Size = new Size(170, 22);
            ViewAccountsBtn.TabIndex = 4;
            ViewAccountsBtn.Text = "View All Accounts";
            ViewAccountsBtn.UseVisualStyleBackColor = true;
            ViewAccountsBtn.Click += ViewAccountsBtn_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 178);
            Controls.Add(ViewAccountsBtn);
            Controls.Add(DeleteAccountBtn);
            Controls.Add(AddAccountBtn);
            Controls.Add(ResetAccountBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ResetAccountBtn;
        private Button AddAccountBtn;
        private Button DeleteAccountBtn;
        private Button ViewAccountsBtn;
    }
}