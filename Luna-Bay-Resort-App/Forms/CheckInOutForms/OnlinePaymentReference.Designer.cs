namespace Luna_Bay_Resort_App.Forms
{
    partial class OnlinePaymentReference
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
            ReferenceTxt = new TextBox();
            Enterbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 0;
            label1.Text = "Reference ID:";
            // 
            // ReferenceTxt
            // 
            ReferenceTxt.Font = new Font("Consolas", 12F);
            ReferenceTxt.Location = new Point(144, 16);
            ReferenceTxt.Name = "ReferenceTxt";
            ReferenceTxt.Size = new Size(233, 26);
            ReferenceTxt.TabIndex = 1;
            // 
            // Enterbtn
            // 
            Enterbtn.BackColor = Color.Green;
            Enterbtn.Font = new Font("Consolas", 12F);
            Enterbtn.ForeColor = Color.White;
            Enterbtn.Location = new Point(383, 14);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(94, 29);
            Enterbtn.TabIndex = 2;
            Enterbtn.Text = "Enter";
            Enterbtn.UseVisualStyleBackColor = false;
            Enterbtn.Click += Enterbtn_Click;
            // 
            // OnlinePaymentReference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 59);
            Controls.Add(Enterbtn);
            Controls.Add(ReferenceTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OnlinePaymentReference";
            Text = "Enter Online Payment Reference Number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ReferenceTxt;
        private Button Enterbtn;
    }
}