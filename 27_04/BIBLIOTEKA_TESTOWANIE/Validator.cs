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
                suma += wagi[i] * (pesel[i] - '0');

            int kontrolna = (10 - (suma % 10)) % 10;
            return kontrolna == (pesel[10] - '0');
        }

        public static bool IsValidEmail(string email) =>
            Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && email.Length <= 255;

        public static bool IsValidPhoneNumber(string number) =>
            Regex.IsMatch(number, @"^\d{9}$");

        public static bool IsValidPostalCode(string postalCode) =>
            Regex.IsMatch(postalCode, @"^\d{2}-\d{3}$");

        public static bool IsValidDate(DateTime date)
        {
            DateTime minDate = new DateTime(1900, 1, 1);
            DateTime maxDate = DateTime.Today;
            return date >= minDate && date <= maxDate;
        }

        public static bool ValidateUserDataDetailed(
            string login,
            string imie,
            string nazwisko,
            string pesel,
            string plec,
            string email,
            string phone,
            string miejscowosc,
            string kodPocztowy,
            string ulica,
            string nrPosesji,
            out string errorMessage)
        {
            if (!IsNotEmpty(login))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawny login";
                return false;
            }

            if (!IsNotEmpty(imie))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawne imię";
                return false;
            }

            if (!IsNotEmpty(nazwisko))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawne nazwisko";
                return false;
            }

            if (!IsValidPESEL(pesel))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawny numer PESEL";
                return false;
            }

            if (!IsNotEmpty(plec))
            {
                errorMessage = "Błąd! Proszę wprowadzić płeć";
                return false;
            }

            if (!IsValidEmail(email))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawny adres e-mail";
                return false;
            }

            if (!IsValidPhoneNumber(phone))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawny numer telefonu";
                return false;
            }

            if (!IsNotEmpty(miejscowosc))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawną nazwę miejscowości";
                return false;
            }

            if (!IsValidPostalCode(kodPocztowy))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawny kod pocztowy (format XX-XXX)";
                return false;
            }

            if (!IsNotEmpty(ulica))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawną nazwę ulicy";
                return false;
            }

            if (!IsNotEmpty(nrPosesji))
            {
                errorMessage = "Błąd! Proszę wprowadzić poprawny numer posesji";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}
