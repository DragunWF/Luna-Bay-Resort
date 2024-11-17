namespace MainForms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LoginUsername = new TextBox();
            label2 = new Label();
            LoginPassword = new TextBox();
            LoginBtn = new Button();
            pictureBox2 = new PictureBox();
            cbShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(703, 757);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(54, 368);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // LoginUsername
            // 
            LoginUsername.Location = new Point(54, 403);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(235, 27);
            LoginUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(54, 457);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // LoginPassword
            // 
            LoginPassword.Location = new Point(54, 489);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.Size = new Size(235, 27);
            LoginPassword.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(80, 85, 129);
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(54, 581);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(235, 37);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(54, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 215);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassword.Location = new Point(104, 533);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(134, 22);
            cbShowPassword.TabIndex = 7;
            cbShowPassword.Text = "Show password";
            cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 211, 94);
            ClientSize = new Size(1062, 753);
            Controls.Add(cbShowPassword);
            Controls.Add(pictureBox2);
            Controls.Add(LoginBtn);
            Controls.Add(LoginPassword);
            Controls.Add(label2);
            Controls.Add(LoginUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Luna Bay Resort: Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox LoginUsername;
        private Label label2;
        private TextBox LoginPassword;
        private Button LoginBtn;
        private PictureBox pictureBox2;
        private CheckBox cbShowPassword;
    }
}
