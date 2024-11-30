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
            CreateAccountBtn = new Button();
            ManageAccountsBtn = new Button();
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
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(20, 58);
            CreateAccountBtn.Margin = new Padding(3, 2, 3, 2);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(170, 22);
            CreateAccountBtn.TabIndex = 2;
            CreateAccountBtn.Text = "Create New Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += AddAccountBtn_Click;
            // 
            // ManageAccountsBtn
            // 
            ManageAccountsBtn.Location = new Point(20, 85);
            ManageAccountsBtn.Margin = new Padding(3, 2, 3, 2);
            ManageAccountsBtn.Name = "ManageAccountsBtn";
            ManageAccountsBtn.Size = new Size(170, 22);
            ManageAccountsBtn.TabIndex = 4;
            ManageAccountsBtn.Text = "Manage Accounts";
            ManageAccountsBtn.UseVisualStyleBackColor = true;
            ManageAccountsBtn.Click += ViewAccountsBtn_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 127);
            Controls.Add(ManageAccountsBtn);
            Controls.Add(CreateAccountBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreateAccountBtn;
        private Button ManageAccountsBtn;
    }
}