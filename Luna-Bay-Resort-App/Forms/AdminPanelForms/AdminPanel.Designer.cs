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
            resetAccountBtn = new Button();
            addAccountBtn = new Button();
            deleteAccountBtn = new Button();
            viewAccountsBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(194, 27);
            label1.TabIndex = 0;
            label1.Text = "Admin Control:";
            // 
            // resetAccountBtn
            // 
            resetAccountBtn.Location = new Point(23, 148);
            resetAccountBtn.Name = "resetAccountBtn";
            resetAccountBtn.Size = new Size(194, 29);
            resetAccountBtn.TabIndex = 1;
            resetAccountBtn.Text = "Reset Accounts";
            resetAccountBtn.UseVisualStyleBackColor = true;
            // 
            // addAccountBtn
            // 
            addAccountBtn.Location = new Point(23, 78);
            addAccountBtn.Name = "addAccountBtn";
            addAccountBtn.Size = new Size(194, 29);
            addAccountBtn.TabIndex = 2;
            addAccountBtn.Text = "Add New Account";
            addAccountBtn.UseVisualStyleBackColor = true;
            // 
            // deleteAccountBtn
            // 
            deleteAccountBtn.Location = new Point(23, 183);
            deleteAccountBtn.Name = "deleteAccountBtn";
            deleteAccountBtn.Size = new Size(194, 29);
            deleteAccountBtn.TabIndex = 3;
            deleteAccountBtn.Text = "Delete Account";
            deleteAccountBtn.UseVisualStyleBackColor = true;
            // 
            // viewAccountsBtn
            // 
            viewAccountsBtn.Location = new Point(23, 113);
            viewAccountsBtn.Name = "viewAccountsBtn";
            viewAccountsBtn.Size = new Size(194, 29);
            viewAccountsBtn.TabIndex = 4;
            viewAccountsBtn.Text = "View All Accounts";
            viewAccountsBtn.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 238);
            Controls.Add(viewAccountsBtn);
            Controls.Add(deleteAccountBtn);
            Controls.Add(addAccountBtn);
            Controls.Add(resetAccountBtn);
            Controls.Add(label1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button resetAccountBtn;
        private Button addAccountBtn;
        private Button deleteAccountBtn;
        private Button viewAccountsBtn;
    }
}