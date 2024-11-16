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
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Enterbtn
            // 
            Enterbtn.Font = new Font("Consolas", 12F);
            Enterbtn.Location = new Point(397, 23);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(91, 25);
            Enterbtn.TabIndex = 5;
            Enterbtn.Text = "Enter";
            Enterbtn.UseVisualStyleBackColor = true;
            Enterbtn.Click += Enterbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 12F);
            textBox1.Location = new Point(149, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 26);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 24);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 3;
            label1.Text = "Reference No:";
            // 
            // CardReference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 64);
            Controls.Add(Enterbtn);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label1;
    }
}