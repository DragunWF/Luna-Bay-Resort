namespace Luna_Bay_Resort_App.Forms
{
    partial class Profile
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
            LogoutBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LogoutBtn
            // 
            LogoutBtn.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutBtn.Location = new Point(87, 94);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(87, 31);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 1;
            label1.Text = "Name: <Name Here>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(234, 19);
            label2.TabIndex = 2;
            label2.Text = "Position: <Position Here>";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 142);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogoutBtn);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogoutBtn;
        private Label label1;
        private Label label2;
    }
}