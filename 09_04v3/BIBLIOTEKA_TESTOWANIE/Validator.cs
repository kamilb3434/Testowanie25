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

        public static bool ValidateUserDataDetailed(
    string login,
    string imie,
    string nazwisko,
    string pesel,
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
                errorMessage = "Login nie może być pusty.";
                return false;
            }

            if (!IsNotEmpty(imie))
            {
                errorMessage = "Imię nie może być puste.";
                return false;
            }

            if (!IsNotEmpty(nazwisko))
            {
                errorMessage = "Nazwisko nie może być puste.";
                return false;
            }

            if (!IsValidPESEL(pesel))
            {
                errorMessage = "PESEL jest nieprawidłowy (format lub cyfra kontrolna).";
                return false;
            }

            if (!IsValidEmail(email))
            {
                errorMessage = "Adres e-mail jest nieprawidłowy.";
                return false;
            }

            if (!IsValidPhoneNumber(phone))
            {
                errorMessage = "Numer telefonu musi składać się z dokładnie 9 cyfr.";
                return false;
            }

            if (!IsNotEmpty(miejscowosc))
            {
                errorMessage = "Miejscowość nie może być pusta.";
                return false;
            }

            if (!IsValidPostalCode(kodPocztowy))
            {
                errorMessage = "Kod pocztowy musi mieć format XX-XXX.";
                return false;
            }

            if (!IsNotEmpty(ulica))
            {
                errorMessage = "Ulica nie może być pusta.";
                return false;
            }

            if (!IsNotEmpty(nrPosesji))
            {
                errorMessage = "Numer posesji nie może być pusty.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

    }
}