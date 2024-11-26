namespace Luna_Bay_Resort_App.Forms.AdminPanelForms
{
    partial class DeleteAccountForm
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
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 38);
            label1.Name = "label1";
            label1.Size = new Size(240, 33);
            label1.TabIndex = 0;
            label1.Text = "Delete Account:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 98);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(48, 191);
            button1.Name = "button1";
            button1.Size = new Size(226, 36);
            button1.TabIndex = 3;
            button1.Text = "Reset Now";
            button1.UseVisualStyleBackColor = true;
            // 
            // DeleteAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 261);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteAccountForm";
            Text = "DeleteAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}