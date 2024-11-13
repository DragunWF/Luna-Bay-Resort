namespace Luna_Bay_Resort_App.Forms.Test
{
    partial class RoomStatusChangeTest
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
            Availablebtn = new Button();
            Cleaningbtn = new Button();
            Repairbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Availablebtn
            // 
            Availablebtn.Location = new Point(96, 60);
            Availablebtn.Name = "Availablebtn";
            Availablebtn.Size = new Size(75, 23);
            Availablebtn.TabIndex = 0;
            Availablebtn.Text = "Available";
            Availablebtn.UseVisualStyleBackColor = true;
            Availablebtn.Click += Availablebtn_Click;
            // 
            // Cleaningbtn
            // 
            Cleaningbtn.Location = new Point(198, 60);
            Cleaningbtn.Name = "Cleaningbtn";
            Cleaningbtn.Size = new Size(75, 23);
            Cleaningbtn.TabIndex = 1;
            Cleaningbtn.Text = "Cleaning";
            Cleaningbtn.UseVisualStyleBackColor = true;
            Cleaningbtn.Click += Cleaningbtn_Click;
            // 
            // Repairbtn
            // 
            Repairbtn.Location = new Point(297, 60);
            Repairbtn.Name = "Repairbtn";
            Repairbtn.Size = new Size(75, 23);
            Repairbtn.TabIndex = 2;
            Repairbtn.Text = "Repair";
            Repairbtn.UseVisualStyleBackColor = true;
            Repairbtn.Click += Repairbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(468, 30);
            label1.TabIndex = 3;
            label1.Text = "This form purpose is to test the method of changing room status in the database\r\nAnd the reflection of rooms based on status on the Maintenance tab in the dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(370, 22);
            label2.TabIndex = 4;
            label2.Text = "Only changes the status of Room 2132";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(410, 30);
            label3.TabIndex = 5;
            label3.Text = "Changes to the maintenance dashboard only applies when u load it again \r\nas there is no event yet that handles status change";
            // 
            // RoomStatusChangeTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 208);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Repairbtn);
            Controls.Add(Cleaningbtn);
            Controls.Add(Availablebtn);
            Name = "RoomStatusChangeTest";
            Text = "RoomStatusChangeTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Availablebtn;
        private Button Cleaningbtn;
        private Button Repairbtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}