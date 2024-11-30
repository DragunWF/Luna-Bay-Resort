namespace Luna_Bay_Resort_App.Forms
{
    partial class AdminProfile
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
            LogoutAdminBtn = new Button();
            NameText = new Label();
            PositionText = new Label();
            AdminPanelBtn = new Button();
            SuspendLayout();
            // 
            // LogoutAdminBtn
            // 
            LogoutAdminBtn.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutAdminBtn.Location = new Point(12, 91);
            LogoutAdminBtn.Name = "LogoutAdminBtn";
            LogoutAdminBtn.Size = new Size(87, 31);
            LogoutAdminBtn.TabIndex = 0;
            LogoutAdminBtn.Text = "Logout";
            LogoutAdminBtn.UseVisualStyleBackColor = true;
            LogoutAdminBtn.Click += LogoutAdminBtn_Click;
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameText.Location = new Point(12, 24);
            NameText.Name = "NameText";
            NameText.Size = new Size(162, 19);
            NameText.TabIndex = 1;
            NameText.Text = "Name: <Name Here>";
            // 
            // PositionText
            // 
            PositionText.AutoSize = true;
            PositionText.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PositionText.Location = new Point(12, 56);
            PositionText.Name = "PositionText";
            PositionText.Size = new Size(234, 19);
            PositionText.TabIndex = 2;
            PositionText.Text = "Position: <Position Here>";
            // 
            // AdminPanelBtn
            // 
            AdminPanelBtn.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminPanelBtn.Location = new Point(105, 91);
            AdminPanelBtn.Name = "AdminPanelBtn";
            AdminPanelBtn.Size = new Size(141, 31);
            AdminPanelBtn.TabIndex = 3;
            AdminPanelBtn.Text = "Admin Controls";
            AdminPanelBtn.UseVisualStyleBackColor = true;
            AdminPanelBtn.Click += AdminPanelBtn_Click;
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 143);
            Controls.Add(AdminPanelBtn);
            Controls.Add(PositionText);
            Controls.Add(NameText);
            Controls.Add(LogoutAdminBtn);
            Name = "AdminProfile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogoutAdminBtn;
        private Label NameText;
        private Label PositionText;
        private Button AdminPanelBtn;
    }
}