using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BIBLIOTEKA_TESTOWANIE
{
    public partial class AdminFormDodajUzytkownika : Form
    {
        private string connectionString = "Server=DESKTOP-LE67A8P\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";

        public AdminFormDodajUzytkownika()
        {
            InitializeComponent();
            LoadComboBoxes();
            WypelnijLosowymiDanymi(); // <- Dodaj to, żeby od razu wypełniało
            this.Text = "Dodawanie użytkowników";
        }

        private void LoadComboBoxes()
        {
            comboBoxPlec.Items.Clear();
            comboBoxPlec.Items.Add(new KeyValuePair<int, string>(1, "M"));
            comboBoxPlec.Items.Add(new KeyValuePair<int, string>(2, "K"));
            comboBoxPlec.DisplayMember = "Value";
            comboBoxPlec.ValueMember = "Key";
            comboBoxPlec.SelectedIndex = 0;

            comboBoxRola.Items.Clear();
            comboBoxRola.Items.Add(new KeyValuePair<int, string>(1, "User"));
            comboBoxRola.Items.Add(new KeyValuePair<int, string>(2, "Admin"));
            comboBoxRola.DisplayMember = "Value";
            comboBoxRola.ValueMember = "Key";
            comboBoxRola.SelectedIndex = 0;
        }

        private void WypelnijLosowymiDanymi()
        {
            Random rnd = new Random();
            string[] imiona = { "Jan", "Anna", "Marek", "Katarzyna", "Tomasz" };
            string[] nazwiska = { "Kowalski", "Nowak", "Wiśniewski", "Wójcik", "Kamińska" };
            string[] miasta = { "Warszawa", "Kraków", "Gdańsk", "Poznań", "Wrocław" };
            string[] ulice = { "Słoneczna", "Polna", "Leśna", "Kwiatowa", "Długa" };

            string imie = imiona[rnd.Next(imiona.Length)];
            string nazwisko = nazwiska[rnd.Next(nazwiska.Length)];
            string login = imie.ToLower() + "." + nazwisko.ToLower() + rnd.Next(100, 999);
            string pesel = rnd.Next(100000000, 999999999).ToString() + rnd.Next(0, 9);
            string email = login + "@test.pl";
            string telefon = "5" + rnd.Next(10000000, 99999999).ToString();
            string miasto = miasta[rnd.Next(miasta.Length)];
            string kod = rnd.Next(10, 99) + "-" + rnd.Next(100, 999);
            string ulica = ulice[rnd.Next(ulice.Length)];
            string nrDomu = rnd.Next(1, 100).ToString();
            string nrLokalu = rnd.Next(1, 20).ToString();

            textBoxLogin.Text = login;
            textBoxImie.Text = imie;
            textBoxNazwisko.Text = nazwisko;
            textBoxPesel.Text = pesel;
            textBoxEmail.Text = email;
            textBoxTelefon.Text = telefon;
            textBoxMiejscowosc.Text = miasto;
            textBoxKodPocztowy.Text = kod;
            textBoxUlica.Text = ulica;
            textBoxNrPosesji.Text = nrDomu;
            textBoxNrLokalu.Text = nrLokalu;
            dateTimePickerDataUrodzenia.Value = new DateTime(rnd.Next(1960, 2005), rnd.Next(1, 13), rnd.Next(1, 28));
            comboBoxPlec.SelectedIndex = rnd.Next(0, comboBoxPlec.Items.Count);
            comboBoxRola.SelectedIndex = rnd.Next(0, comboBoxRola.Items.Count);
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz dodać użytkownika?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

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
            string nrLokalu = textBoxNrLokalu.Text.Trim();
            DateTime dataUrodzenia = dateTimePickerDataUrodzenia.Value;

            int idPlec = ((KeyValuePair<int, string>)comboBoxPlec.SelectedItem).Key;
            int idRola = ((KeyValuePair<int, string>)comboBoxRola.SelectedItem).Key;

            if (!Validator.ValidateUserDataDetailed(login, imie, nazwisko, pesel, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, out string errorMsg))
            {
                MessageBox.Show(errorMsg, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var konflikty = DatabaseHelper.GetExistingUserConflicts(connectionString, login, pesel, email);
            if (konflikty.Count > 0)
            {
                string msg = string.Join("\n", konflikty);
                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool sukces = DatabaseHelper.AddUser(
                connectionString, login, imie, nazwisko, pesel, email, telefon,
                miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu,
                dataUrodzenia, idPlec, idRola);

            if (sukces)
            {
                MessageBox.Show("Użytkownik dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WypelnijLosowymiDanymi(); // <- ponowne losowanie po sukcesie
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Czy na pewno chcesz anulować dodawanie użytkownika?",
               "Potwierdzenie",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AdminFormPanelGlowny adminFormPanelGlowny = new AdminFormPanelGlowny();
                adminFormPanelGlowny.Show();
                this.Close();
            }
            
        }
    }
}
