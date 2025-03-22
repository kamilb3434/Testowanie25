using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BIBLIOTEKA_TESTOWANIE
{
    public static class Validator
    {
        public static bool IsNotEmpty(string value) =>
            !string.IsNullOrWhiteSpace(value);

        public static bool IsValidPESEL(string pesel)
        {
            if (!Regex.IsMatch(pesel, @"^\d{11}$"))
                return false;

            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma += wagi[i] * (pesel[i] - '0');
            }
            int kontrolna = (10 - (suma % 10)) % 10;
            return kontrolna == (pesel[10] - '0');
        }

        public static bool IsValidEmail(string email) =>
            Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && email.Length <= 255;

        public static bool IsValidPhoneNumber(string number) =>
            Regex.IsMatch(number, @"^\d{9}$");

        public static bool IsValidPostalCode(string postalCode) =>
            Regex.IsMatch(postalCode, @"^\d{2}-\d{3}$");
    }

}
