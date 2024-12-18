﻿using Luna_Bay_Resort_App.Data;
using SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms.CheckInOutForms
{
    public partial class CardReference : Form
    {
        private const int characterLimit = 35;

        public CardReference()
        {
            InitializeComponent();
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty((Referencetxt.Text)))
                {
                    MessageBox.Show("Please enter the reference number from your preferred mode of payment");
                }
                else if (Referencetxt.Text.Length > characterLimit)
                {
                    MessageBox.Show($"Card reference ID cannot be greater than {characterLimit} characters!");
                }
                else
                {
                    PaymentMethods.paymentreference = Referencetxt.Text;
                    PaymentMethods.ifPayed = true;
                    this.Close();
                }
            }
            catch (FormatException eee)
            {
                MessageBox.Show("Input Number Only");
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
    }
}
