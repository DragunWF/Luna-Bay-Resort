namespace Luna_Bay_Resort_App.Forms.UserControlForms
{
    partial class WalkInForm
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
            Hours12cb = new CheckBox();
            Hours6cb = new CheckBox();
            Nametxt = new TextBox();
            Numofpersontxt = new TextBox();
            label2 = new Label();
            Confirmbtn = new Button();
            label3 = new Label();
            Totaltxt = new Label();
            label5 = new Label();
            label4 = new Label();
            CardCheckBox = new CheckBox();
            OnlinePaymentCheckBox = new CheckBox();
            label14 = new Label();
            CashCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10F);
            label1.Location = new Point(25, 75);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // Hours12cb
            // 
            Hours12cb.AutoSize = true;
            Hours12cb.CheckAlign = ContentAlignment.MiddleRight;
            Hours12cb.Font = new Font("Consolas", 10F);
            Hours12cb.Location = new Point(126, 198);
            Hours12cb.Name = "Hours12cb";
            Hours12cb.Size = new Size(91, 21);
            Hours12cb.TabIndex = 1;
            Hours12cb.Text = "12 Hours";
            Hours12cb.UseVisualStyleBackColor = true;
            Hours12cb.CheckedChanged += Hours12cb_CheckedChanged;
            // 
            // Hours6cb
            // 
            Hours6cb.AutoSize = true;
            Hours6cb.CheckAlign = ContentAlignment.MiddleRight;
            Hours6cb.Font = new Font("Consolas", 10F);
            Hours6cb.Location = new Point(25, 198);
            Hours6cb.Name = "Hours6cb";
            Hours6cb.Size = new Size(83, 21);
            Hours6cb.TabIndex = 2;
            Hours6cb.Text = "6 Hours";
            Hours6cb.UseVisualStyleBackColor = true;
            Hours6cb.CheckedChanged += Hours6cb_CheckedChanged;
            // 
            // Nametxt
            // 
            Nametxt.Font = new Font("Consolas", 9F);
            Nametxt.Location = new Point(175, 73);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(180, 22);
            Nametxt.TabIndex = 3;
            // 
            // Numofpersontxt
            // 
            Numofpersontxt.Font = new Font("Consolas", 9F);
            Numofpersontxt.Location = new Point(175, 111);
            Numofpersontxt.Name = "Numofpersontxt";
            Numofpersontxt.Size = new Size(180, 22);
            Numofpersontxt.TabIndex = 5;
            Numofpersontxt.TextChanged += Numofpersontxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10F);
            label2.Location = new Point(25, 116);
            label2.Name = "label2";
            label2.Size = new Size(144, 17);
            label2.TabIndex = 6;
            label2.Text = "Number of Person:";
            // 
            // Confirmbtn
            // 
            Confirmbtn.BackColor = Color.SteelBlue;
            Confirmbtn.Font = new Font("Consolas", 10F);
            Confirmbtn.ForeColor = SystemColors.ButtonHighlight;
            Confirmbtn.Location = new Point(251, 385);
            Confirmbtn.Name = "Confirmbtn";
            Confirmbtn.Size = new Size(90, 32);
            Confirmbtn.TabIndex = 7;
            Confirmbtn.Text = "Confirm";
            Confirmbtn.UseVisualStyleBackColor = false;
            Confirmbtn.Click += Confirmbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10F);
            label3.Location = new Point(25, 394);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 8;
            label3.Text = "Total:";
            // 
            // Totaltxt
            // 
            Totaltxt.AutoSize = true;
            Totaltxt.Font = new Font("Consolas", 10F);
            Totaltxt.Location = new Point(87, 394);
            Totaltxt.Name = "Totaltxt";
            Totaltxt.Size = new Size(0, 17);
            Totaltxt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 10F);
            label5.Location = new Point(25, 164);
            label5.Name = "label5";
            label5.Size = new Size(112, 17);
            label5.TabIndex = 12;
            label5.Text = "Stay Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 22);
            label4.TabIndex = 31;
            label4.Text = "Form: Walk In";
            // 
            // CardCheckBox
            // 
            CardCheckBox.AutoSize = true;
            CardCheckBox.Font = new Font("Consolas", 10F);
            CardCheckBox.Location = new Point(25, 333);
            CardCheckBox.Name = "CardCheckBox";
            CardCheckBox.Size = new Size(171, 21);
            CardCheckBox.TabIndex = 63;
            CardCheckBox.Text = "Debit/ Credit Card";
            CardCheckBox.UseVisualStyleBackColor = true;
            CardCheckBox.CheckedChanged += CardCheckBox_CheckedChanged;
            // 
            // OnlinePaymentCheckBox
            // 
            OnlinePaymentCheckBox.AutoSize = true;
            OnlinePaymentCheckBox.Font = new Font("Consolas", 10F);
            OnlinePaymentCheckBox.Location = new Point(25, 306);
            OnlinePaymentCheckBox.Name = "OnlinePaymentCheckBox";
            OnlinePaymentCheckBox.Size = new Size(139, 21);
            OnlinePaymentCheckBox.TabIndex = 62;
            OnlinePaymentCheckBox.Text = "Online Payment";
            OnlinePaymentCheckBox.UseVisualStyleBackColor = true;
            OnlinePaymentCheckBox.CheckedChanged += OnlinePaymentCheckBox_CheckedChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 10F);
            label14.Location = new Point(25, 245);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(128, 17);
            label14.TabIndex = 61;
            label14.Text = "Payment Method:";
            // 
            // CashCheckBox
            // 
            CashCheckBox.AutoSize = true;
            CashCheckBox.Font = new Font("Consolas", 10F);
            CashCheckBox.Location = new Point(25, 279);
            CashCheckBox.Name = "CashCheckBox";
            CashCheckBox.Size = new Size(59, 21);
            CashCheckBox.TabIndex = 60;
            CashCheckBox.Text = "Cash";
            CashCheckBox.UseVisualStyleBackColor = true;
            CashCheckBox.CheckedChanged += CashCheckBox_CheckedChanged;
            // 
            // WalkInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 445);
            Controls.Add(CardCheckBox);
            Controls.Add(OnlinePaymentCheckBox);
            Controls.Add(label14);
            Controls.Add(CashCheckBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(Totaltxt);
            Controls.Add(label3);
            Controls.Add(Confirmbtn);
            Controls.Add(label2);
            Controls.Add(Numofpersontxt);
            Controls.Add(Nametxt);
            Controls.Add(Hours6cb);
            Controls.Add(Hours12cb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WalkInForm";
            Text = "Walk In Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox Hours12cb;
        private CheckBox Hours6cb;
        private TextBox Nametxt;
        private TextBox Numofpersontxt;
        private Label label2;
        private Button Confirmbtn;
        private Label label3;
        private Label Totaltxt;
        private Label label5;
        private Label label4;
        private CheckBox CardCheckBox;
        private CheckBox OnlinePaymentCheckBox;
        private Label label14;
        private CheckBox CashCheckBox;
    }
}