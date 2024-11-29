namespace Luna_Bay_Resort_App.Forms.ReservationForms
{
    partial class PaymentMethodSelection
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
            RequirePaymentlbl = new Label();
            label1 = new Label();
            Enterbtn = new Button();
            ReferenceTxt = new TextBox();
            label2 = new Label();
            CardCheckBox = new CheckBox();
            OnlinePaymentCheckBox = new CheckBox();
            label15 = new Label();
            SuspendLayout();
            // 
            // RequirePaymentlbl
            // 
            RequirePaymentlbl.AutoSize = true;
            RequirePaymentlbl.Font = new Font("Consolas", 13.5F);
            RequirePaymentlbl.Location = new Point(490, 26);
            RequirePaymentlbl.Name = "RequirePaymentlbl";
            RequirePaymentlbl.Size = new Size(70, 22);
            RequirePaymentlbl.TabIndex = 0;
            RequirePaymentlbl.Text = "amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.5F);
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(470, 22);
            label1.TabIndex = 1;
            label1.Text = "Required payment to complete reservation edit:";
            // 
            // Enterbtn
            // 
            Enterbtn.BackColor = Color.Green;
            Enterbtn.Font = new Font("Consolas", 12F);
            Enterbtn.ForeColor = Color.White;
            Enterbtn.Location = new Point(508, 131);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(100, 31);
            Enterbtn.TabIndex = 5;
            Enterbtn.Text = "Enter";
            Enterbtn.UseVisualStyleBackColor = false;
            Enterbtn.Click += Enterbtn_Click;
            // 
            // ReferenceTxt
            // 
            ReferenceTxt.Font = new Font("Consolas", 12F);
            ReferenceTxt.Location = new Point(158, 134);
            ReferenceTxt.Name = "ReferenceTxt";
            ReferenceTxt.Size = new Size(326, 26);
            ReferenceTxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 137);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 3;
            label2.Text = "Reference No:";
            // 
            // CardCheckBox
            // 
            CardCheckBox.AutoSize = true;
            CardCheckBox.Font = new Font("Consolas", 10F);
            CardCheckBox.Location = new Point(177, 100);
            CardCheckBox.Name = "CardCheckBox";
            CardCheckBox.Size = new Size(171, 21);
            CardCheckBox.TabIndex = 83;
            CardCheckBox.Text = "Debit/ Credit Card";
            CardCheckBox.UseVisualStyleBackColor = true;
            CardCheckBox.CheckedChanged += CardCheckBox_CheckedChanged;
            // 
            // OnlinePaymentCheckBox
            // 
            OnlinePaymentCheckBox.AutoSize = true;
            OnlinePaymentCheckBox.Font = new Font("Consolas", 10F);
            OnlinePaymentCheckBox.Location = new Point(23, 100);
            OnlinePaymentCheckBox.Name = "OnlinePaymentCheckBox";
            OnlinePaymentCheckBox.Size = new Size(139, 21);
            OnlinePaymentCheckBox.TabIndex = 82;
            OnlinePaymentCheckBox.Text = "Online Payment";
            OnlinePaymentCheckBox.UseVisualStyleBackColor = true;
            OnlinePaymentCheckBox.CheckedChanged += OnlinePaymentCheckBox_CheckedChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(23, 68);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(128, 18);
            label15.TabIndex = 81;
            label15.Text = "Payment Method:";
            // 
            // PaymentMethodSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 179);
            Controls.Add(CardCheckBox);
            Controls.Add(OnlinePaymentCheckBox);
            Controls.Add(label15);
            Controls.Add(Enterbtn);
            Controls.Add(ReferenceTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RequirePaymentlbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PaymentMethodSelection";
            Text = "Select Payment Method";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RequirePaymentlbl;
        private Label label1;
        private Button Enterbtn;
        private TextBox ReferenceTxt;
        private Label label2;
        private CheckBox CardCheckBox;
        private CheckBox OnlinePaymentCheckBox;
        private Label label15;
    }
}