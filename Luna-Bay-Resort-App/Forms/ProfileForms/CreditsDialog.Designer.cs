namespace Luna_Bay_Resort_App.Forms.ProfileForms
{
    partial class CreditsDialog
    {
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
                // If the `components` container is not used, remove the null check for `components`.
                // Otherwise, declare it as `private System.ComponentModel.IContainer components = null;` above.
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
            MessageLabel = new Label();
            BtnOption1 = new Button();
            BtnOption2 = new Button();
            SuspendLayout();
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Location = new Point(23, 23);
            MessageLabel.Margin = new Padding(4, 0, 4, 0);
            MessageLabel.MaximumSize = new Size(467, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(79, 15);
            MessageLabel.TabIndex = 0;
            MessageLabel.Text = "Message here";
            // 
            // BtnOption1
            // 
            BtnOption1.Location = new Point(118, 161);
            BtnOption1.Margin = new Padding(4, 3, 4, 3);
            BtnOption1.Name = "BtnOption1";
            BtnOption1.Size = new Size(117, 35);
            BtnOption1.TabIndex = 1;
            BtnOption1.Text = "Option 1";
            BtnOption1.UseVisualStyleBackColor = true;
            // 
            // BtnOption2
            // 
            BtnOption2.Location = new Point(259, 161);
            BtnOption2.Margin = new Padding(4, 3, 4, 3);
            BtnOption2.Name = "BtnOption2";
            BtnOption2.Size = new Size(117, 35);
            BtnOption2.TabIndex = 2;
            BtnOption2.Text = "Option 2";
            BtnOption2.UseVisualStyleBackColor = true;
            // 
            // CreditsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 208);
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
