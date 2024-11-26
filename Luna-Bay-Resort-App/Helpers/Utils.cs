using System.Text.RegularExpressions;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class Utils
    {
        private static readonly string digits = "0123456789";
        private static readonly Random random = new Random();

        #region Generate ID/No Methods

        public static int GenerateCheckInOutNo()
        {
            return GenerateRandomId(5);
        }

        public static string GenerateReceiptNo()
        {
            return GenerateRandomId(9).ToString();
        }

        public static int GenerateReservationNo()
        {
            return GenerateRandomId(5);
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

        public static bool IsValidFormData(string[] inputValues, string email, string contactNo)
        {
            if (!IsTextBoxesNotEmpty(inputValues))
            {
                MessageBox.Show("Please don't leave any text boxes empty!");
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Your email is invalid, please make sure you type in a valid email address!");
            }
            else if (!IsValidContactNumber(contactNo))
            {
                MessageBox.Show("Your contact number is invalid, please make sure you type in a number with the correct format");
            }
            else
            {
                return true;
            }
            return false; // This gets returned when any of the data is invalid
        }

        public static bool IsValidCheckInOut(DateTimePicker checkIn, DateTimePicker checkOut)
        {
            if (checkIn.Value > checkOut.Value)
            {
                MessageBox.Show("Please make sure that the datetime of checking in happens before date of checking out");
                return false;
            }
            return true;
        }

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

        #region Format Currency Methods - With Method Overloading

        public static string FormatCurrency(int amount)
        {
            return $"{amount.ToString("N0")} PHP"; // Formats as "1,000 PHP"
        }

        public static string FormatCurrency(double amount)
        {
            return $"{amount.ToString("N2")} PHP"; // Formats as "1,000.00 PHP"
        }

        #endregion

        #region Miscelleneous Methods

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
        public static string GetDateOnly()
        {
            // Format: "11/22/2024"
            return DateTime.Now.ToString("MM/dd/yyyy");
        }

        #endregion
    }
}
