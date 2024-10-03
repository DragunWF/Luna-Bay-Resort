namespace Luna_Bay_Resort.forms
{
    partial class LandingForm
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            logInBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            inputPassowrd = new TextBox();
            inputUsername = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.landing_bg;
            pictureBox1.Location = new Point(701, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1407, 1047);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(logInBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(inputPassowrd);
            groupBox1.Controls.Add(inputUsername);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(67, 463);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 473);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login your account first";
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.SteelBlue;
            logInBtn.FlatAppearance.BorderSize = 0;
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInBtn.ForeColor = SystemColors.ButtonHighlight;
            logInBtn.Location = new Point(94, 333);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(358, 41);
            logInBtn.TabIndex = 4;
            logInBtn.Text = "Login";
            logInBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 186);
            label2.Name = "label2";
            label2.Size = new Size(130, 26);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 86);
            label1.Name = "label1";
            label1.Size = new Size(134, 26);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // inputPassowrd
            // 
            inputPassowrd.Font = new Font("Lucida Sans", 14F);
            inputPassowrd.Location = new Point(94, 230);
            inputPassowrd.Name = "inputPassowrd";
            inputPassowrd.Size = new Size(358, 35);
            inputPassowrd.TabIndex = 1;
            // 
            // inputUsername
            // 
            inputUsername.Font = new Font("Lucida Sans", 14F);
            inputUsername.Location = new Point(94, 133);
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(358, 35);
            inputUsername.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(67, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(553, 401);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1924, 1033);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LandingForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LandingForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += LandingForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private TextBox inputPassowrd;
        private TextBox inputUsername;
        private Button logInBtn;
    }
}