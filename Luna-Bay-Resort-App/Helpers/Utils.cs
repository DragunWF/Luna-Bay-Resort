using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class Utils
    {
        private static readonly string digits = "0123456789";
        private static readonly Random random = new Random();

        public static string GenerateReceiptId()
        {
            const int idDigitCount = 9;
            string receiptId = "";
            for (int i = 0; i < idDigitCount; i++)
            {
                receiptId += digits[random.Next(0, digits.Length)];
            }
            return receiptId;
        }

        public static string FormatCurrency(int amount)
        {
            return $"{amount} PHP";
        }

        public static void ResetTextBoxes(TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }

        public static bool IsValidContactNumber(string contactNumber)
        {
            // Pattern for valid phone numbers (adapt as needed)
            return Regex.IsMatch(contactNumber, @"^(\+?\d{1,3})?[-.\s]?(\d{3})[-.\s]?(\d{3})[-.\s]?(\d{4})$");
        }

        public static bool IsValidEmail(string email)
        {
            // Standard email pattern, allowing for valid characters and common email formats
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }
    }
}
