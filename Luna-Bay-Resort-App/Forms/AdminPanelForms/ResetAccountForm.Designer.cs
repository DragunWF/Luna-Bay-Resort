namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    partial class ResetAccountForm
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
            label2 = new Label();
            txtUsername = new TextBox();
            searchBtn = new Button();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 106);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 38);
            label2.Name = "label2";
            label2.Size = new Size(225, 33);
            label2.TabIndex = 1;
            label2.Text = "Reset Account:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(145, 106);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 27);
            txtUsername.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(30, 150);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(356, 34);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 210);
            label3.Name = "label3";
            label3.Size = new Size(219, 23);
            label3.TabIndex = 4;
            label3.Text = "Enter New Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 249);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(356, 27);
            txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 299);
            label4.Name = "label4";
            label4.Size = new Size(197, 23);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(30, 338);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(356, 27);
            txtConfirmPassword.TabIndex = 7;
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.Location = new Point(30, 392);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(356, 34);
            resetBtn.TabIndex = 8;
            resetBtn.Text = "Reset Now";
            resetBtn.UseVisualStyleBackColor = true;
            // 
            // ResetAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 476);
            Controls.Add(resetBtn);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(searchBtn);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ResetAccountForm";
            Text = "ResetAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Button searchBtn;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtConfirmPassword;
        private Button resetBtn;
    }
}