namespace Luna_Bay_Resort_App.Forms.ProfileForms
{
    partial class CreditsDialog
    {
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button BtnOption1;
        private System.Windows.Forms.Button BtnOption2;

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            MessageLabel = new Label();
            BtnOption1 = new Button();
            BtnOption2 = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            HeaderLabel.Location = new Point(20, 20);
            HeaderLabel.Margin = new Padding(4, 0, 4, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(181, 21);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "This is the Header Text";
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Location = new Point(23, 60);
            MessageLabel.Margin = new Padding(4, 0, 4, 0);
            MessageLabel.MaximumSize = new Size(467, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(79, 15);
            MessageLabel.TabIndex = 1;
            MessageLabel.Text = "Message here";
            // 
            // BtnOption1
            // 
            BtnOption1.Location = new Point(118, 181);
            BtnOption1.Margin = new Padding(4, 3, 4, 3);
            BtnOption1.Name = "BtnOption1";
            BtnOption1.Size = new Size(117, 35);
            BtnOption1.TabIndex = 2;
            BtnOption1.Text = "Option 1";
            BtnOption1.UseVisualStyleBackColor = true;
            // 
            // BtnOption2
            // 
            BtnOption2.Location = new Point(260, 181);
            BtnOption2.Margin = new Padding(4, 3, 4, 3);
            BtnOption2.Name = "BtnOption2";
            BtnOption2.Size = new Size(117, 35);
            BtnOption2.TabIndex = 3;
            BtnOption2.Text = "Option 2";
            BtnOption2.UseVisualStyleBackColor = true;
            // 
            // CreditsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 228);
            Controls.Add(HeaderLabel);
            Controls.Add(MessageLabel);
            Controls.Add(BtnOption1);
            Controls.Add(BtnOption2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreditsDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
