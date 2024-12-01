using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms.ProfileForms
{
    public partial class CreditsDialog : Form
    {
        public CreditsDialog(string header, string message, string button1Text, string button2Text)
        {
            InitializeComponent();

            // Set the message text
            HeaderLabel.Text = header;
            MessageLabel.Text = message;

            // Set button texts
            BtnOption1.Text = button1Text;
            BtnOption2.Text = button2Text;

            // Configure button event handlers
            BtnOption1.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };
            BtnOption2.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
        }
    }
}
