using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DodanieUzytkownika
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPlec.Items.Add("Kobieta");
            cmbPlec.Items.Add("M�czyzna");
            cmbPlec.Items.Add("Inne");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //Pobranie danych z formularza
            string login = txtLogin.Text;
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            string pesel = txtPesel.Text;
            string adresEmail = txtEmail.Text;
            string telefon = txtTelefon.Text;
            string plec = cmbPlec.SelectedItem?.ToString();

            //Walidacja p�l
            if (!ValidateInputs(login, pesel, adresEmail, telefon))
                return;
            //Dodanie u�ytkownika do listy i od�wie�enie widoku
            users.Add(new User(login, imie, nazwisko, pesel, adresEmail, telefon, plec));
            UpdateUserGrid();
            ClearInputs();
        }



        private bool ValidateInputs(string login, string pesel, string email, string telefon)
        {
            lblError.Text = "";

            //Sprawdzenie unikalno�ci loginu
            if (users.Any(u => u.Login == login))
            {
                lblError.Text = "Login musi by� unikalny.";
                return false;
            }

            //Walidacja PESELu
            if (!ValidatePesel(pesel))
            {
                lblError.Text = "Nieprawid�owy numer PESEL.";
                return false;
            }

            //Walidacja e-mail
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblError.Text = "Nieprawid�owy adres email.";
                return false;
            }

            //Walidacja numeru telefonu (9 cyfr)
            telefon = telefon.Trim().Replace(" ", "");

            if (!Regex.IsMatch(telefon, @"^\d{9}$"))
            {
                lblError.Text = "Numer telefonu musi sk�ada� si� z 9 cyfr";
                return false;
            }

            return true;
        }

        private bool ValidatePesel(string pesel)
        {
            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
                return false;

            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;
            for (int i = 0; i < 10; i++)
                sum += (pesel[i] - '0') * weights[i];

            int controlDigit = (10 - (sum % 10)) % 10;
            return controlDigit == (pesel[10] - '0');
        }

        private void UpdateUserGrid()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = users;
        }

        private void ClearInputs()
        {
            txtLogin.Clear();
            txtImie.Clear();
            txtNazwisko.Clear();
            txtPesel.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            cmbPlec.SelectedIndex = -1;
        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}