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

        #region Generate ID/No Methods

        public static string GenerateCheckInOutNo()
        {
            return GenerateRandomId(9).ToString();
        }

        public static string GenerateReceiptNo()
        {
            return GenerateRandomId(9).ToString();
        }

        public static string GenerateReservationNo()
        {
            return GenerateRandomId(5).ToString();
        }

        private static int GenerateRandomId(int digitCount)
        {
            string receiptId = "";
            for (int i = 0; i < digitCount; i++)
            {
                // Ternary condition's purpose is to prevent leading zeroes
                receiptId += digits[random.Next(i == 0 ? 1 : 0, digits.Length)];
            }
            return int.Parse(receiptId);
        }

        #endregion

        #region Validator Methods

        public static bool IsTextBoxesNotEmpty(string[] textValues)
        {
            foreach (string value in textValues)
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return false;
                }
            }
            return true;
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

        #endregion

        #region Miscelleneous Methods

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

        public static string GetCurrentDate()
        {
            // Example output in this date format: "2024-11-11 10:30"
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        #endregion
    }
}
