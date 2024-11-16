namespace Luna_Bay_Resort_App.Forms
{
    partial class AddPax
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
            Paxtxt = new TextBox();
            Enterbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(135, 19);
            label1.TabIndex = 0;
            label1.Text = "Number of Pax:";
            // 
            // Paxtxt
            // 
            Paxtxt.Font = new Font("Consolas", 12F);
            Paxtxt.Location = new Point(153, 18);
            Paxtxt.Name = "Paxtxt";
            Paxtxt.Size = new Size(100, 26);
            Paxtxt.TabIndex = 1;
            // 
            // Enterbtn
            // 
            Enterbtn.BackColor = Color.Green;
            Enterbtn.Font = new Font("Consolas", 12F);
            Enterbtn.ForeColor = Color.White;
            Enterbtn.Location = new Point(262, 16);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(98, 29);
            Enterbtn.TabIndex = 6;
            Enterbtn.Text = "Enter";
            Enterbtn.UseVisualStyleBackColor = false;
            // 
            // AddPax
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 56);
            Controls.Add(Enterbtn);
            Controls.Add(Paxtxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPax";
            Text = "Enter number of Pax to be added";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Paxtxt;
        private Button Enterbtn;
    }
}