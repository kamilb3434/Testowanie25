using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BIBLIOTEKA_TESTOWANIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string imie = textBoxImie.Text.Trim();
            string nazwisko = textBoxNazwisko.Text.Trim();
            string pesel = textBoxPesel.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string telefon = textBoxTelefon.Text.Trim();
            string miejscowosc = textBoxMiejscowosc.Text.Trim();
            string kodPocztowy = textBoxKodPocztowy.Text.Trim();
            string ulica = textBoxUlica.Text.Trim();
            string nrPosesji = textBoxNrPosesji.Text.Trim();

            // Sprawdzenie, czy wszystkie wymagane pola są wypełnione
            if (!Validator.IsNotEmpty(login) || !Validator.IsNotEmpty(imie) || !Validator.IsNotEmpty(nazwisko) ||
                !Validator.IsNotEmpty(pesel) || !Validator.IsNotEmpty(email) || !Validator.IsNotEmpty(telefon) ||
                !Validator.IsNotEmpty(miejscowosc) || !Validator.IsNotEmpty(kodPocztowy) || !Validator.IsNotEmpty(ulica) ||
                !Validator.IsNotEmpty(nrPosesji))
            {
                MessageBox.Show("Wszystkie pola są wymagane!");
                return;
            }

            // Walidacja PESEL
            if (!Validator.IsValidPESEL(pesel))
            {
                MessageBox.Show("Nieprawidłowy numer PESEL.");
                return;
            }

            // Walidacja e-maila
            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Nieprawidłowy adres e-mail.");
                return;
            }

            // Walidacja numeru telefonu
            if (!Validator.IsValidPhoneNumber(telefon))
            {
                MessageBox.Show("Numer telefonu musi mieć dokładnie 9 cyfr.");
                return;
            }

            // Walidacja kodu pocztowego
            if (!Validator.IsValidPostalCode(kodPocztowy))
            {
                MessageBox.Show("Nieprawidłowy kod pocztowy. Poprawny format: XX-XXX.");
                return;
            }

            // Jeśli wszystkie dane są poprawne
            MessageBox.Show("Dane poprawne! Można dodać użytkownika.");
        }


    }

}
