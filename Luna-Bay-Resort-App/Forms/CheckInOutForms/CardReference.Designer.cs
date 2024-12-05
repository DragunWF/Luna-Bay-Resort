namespace Luna_Bay_Resort_App.Forms.CheckInOutForms
{
    partial class CardReference
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
            Enterbtn = new Button();
            Referencetxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Enterbtn
            // 
            Enterbtn.BackColor = Color.Green;
            Enterbtn.Font = new Font("Consolas", 12F);
            Enterbtn.ForeColor = Color.White;
            Enterbtn.Location = new Point(388, 18);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(98, 29);
            Enterbtn.TabIndex = 5;
            Enterbtn.Text = "Enter";
            Enterbtn.UseVisualStyleBackColor = false;
            Enterbtn.Click += Enterbtn_Click;
            // 
            // Referencetxt
            // 
            Referencetxt.Font = new Font("Consolas", 12F);
            Referencetxt.Location = new Point(149, 21);
            Referencetxt.Name = "Referencetxt";
            Referencetxt.Size = new Size(233, 26);
            Referencetxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 24);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 3;
            label1.Text = "Reference ID:";
            // 
            // CardReference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 64);
            Controls.Add(Enterbtn);
            Controls.Add(Referencetxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CardReference";
            Text = "Enter Card Transaction Reference Number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enterbtn;
        private TextBox Referencetxt;
        private Label label1;
    }
}