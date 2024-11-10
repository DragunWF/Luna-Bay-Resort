using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Helpers
{
    internal class Utils
    {
        private static readonly string digits = "0123456789";
        private static readonly Random random = new Random();

        public static int GenerateReservationNum()
        {
            const int idDigitCount = 9;
            string strNum = "";
            for (int i = 0; i < idDigitCount; i++)
            {
                strNum += digits[random.Next(0, digits.Length)];
            }
            int reservationNum = int.Parse(strNum);

            // Takes care of leading zeroes
            if (reservationNum.ToString().Length < idDigitCount)
            {
                return GenerateReservationNum();
            }
            return reservationNum;
        }

        public static string FormatCurrency(int amount)
        {
            return $"{amount} PHP";
        }
    }
}
