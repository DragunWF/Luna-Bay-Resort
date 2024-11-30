namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    partial class CreateNewAccount
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
            label3 = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            label4 = new Label();
            TxtConfirmPassword = new TextBox();
            CreateBtn = new Button();
            label5 = new Label();
            PositionCB = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(240, 26);
            label1.TabIndex = 0;
            label1.Text = "Create New Account:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 86);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 153);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(34, 116);
            TxtUsername.Margin = new Padding(3, 2, 3, 2);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(263, 23);
            TxtUsername.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(34, 179);
            TxtPassword.Margin = new Padding(3, 2, 3, 2);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(263, 23);
            TxtPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 218);
            label4.Name = "label4";
            label4.Size = new Size(162, 19);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password:";
            // 
            // TxtConfirmPassword
            // 
            TxtConfirmPassword.Location = new Point(34, 248);
            TxtConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            TxtConfirmPassword.Name = "TxtConfirmPassword";
            TxtConfirmPassword.Size = new Size(263, 23);
            TxtConfirmPassword.TabIndex = 6;
            // 
            // CreateBtn
            // 
            CreateBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(33, 370);
            CreateBtn.Margin = new Padding(3, 2, 3, 2);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(262, 28);
            CreateBtn.TabIndex = 7;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 286);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 8;
            label5.Text = "Position";
            // 
            // PositionCB
            // 
            PositionCB.FormattingEnabled = true;
            PositionCB.Location = new Point(33, 318);
            PositionCB.Name = "PositionCB";
            PositionCB.Size = new Size(264, 23);
            PositionCB.TabIndex = 9;
            // 
            // CreateNewAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 409);
            Controls.Add(PositionCB);
            Controls.Add(label5);
            Controls.Add(CreateBtn);
            Controls.Add(TxtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateNewAccount";
            Text = "Create New Account Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label label4;
        private TextBox TxtConfirmPassword;
        private Button CreateBtn;
        private Label label5;
        private ComboBox PositionCB;
    }
}