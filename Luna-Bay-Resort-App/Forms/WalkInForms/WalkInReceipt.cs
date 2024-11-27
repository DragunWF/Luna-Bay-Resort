﻿using Luna_Bay_Resort_App.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms.WalkInForms
{
    public partial class WalkInReceipt : Form
    {
        private readonly string name, date, duration, receiptno, paymentmethod;
        private readonly int numofPerson, total;
        public WalkInReceipt(string name, string date, string duration, int numofPerson, int total, string paymentmethod)
        {
            InitializeComponent();
            this.name = name;
            this.date = date;
            this.duration = duration;
            this.numofPerson = numofPerson;
            this.total = total;
            this.paymentmethod = paymentmethod;

            receiptno = Utils.GenerateReceiptNo();

            DisplayReceiptData();
        }
        private void DisplayReceiptData()
        {
            // Receipt Details
            ReceiptNoText.Text = receiptno;
            DateTimeText.Text = Utils.GetCurrentDate();
            PaymentMethodText.Text = paymentmethod;

            // Reservation Details
            FullNameText.Text = name;
            Staydurationtxt.Text = duration;
            NoOfPersonText.Text = numofPerson.ToString();

            // Amount Details
            TotalAmounttxt.Text = Utils.FormatCurrency(total);
        }
    }
}