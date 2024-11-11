﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Data
{
    internal class PaymentMethods
    {
        private Dictionary<string, int> paymentMethods = new(); // Name and ID in Database

        public int GetId(string name)
        {
            if (paymentMethods.Count == 0)
            {
                FillPaymentMethods();
            }
            if (paymentMethods.ContainsKey(name))
            {
                throw new ArgumentException($"Payment method key '{name}' is incorrect! Please make sure you've inputted the correct key.");
            }
            return paymentMethods[name];
        }

        private void FillPaymentMethods()
        {
            paymentMethods.Add("Cash", 1);
            paymentMethods.Add("Online Payment", 2);
            paymentMethods.Add("Debit/Credit Card", 3);
        }
    }
}