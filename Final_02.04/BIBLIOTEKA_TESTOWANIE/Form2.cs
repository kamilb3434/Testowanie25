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
using System.Data.SqlClient;

namespace BIBLIOTEKA_TESTOWANIE
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=LAPTOPIK-K4514\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";
        private int edytowanyUzytkownikID = -1;

        public Form2()
        {
            InitializeComponent();
            dataGridViewUzytkownicy.CellClick += dataGridViewUzytkownicy_CellClick;
            button.Click += button_Click;
            buttonEdytuj.Click += buttonEdytuj_Click_1;
            buttonUzupelnij.Click += buttonUzupelnij_Click;
            LoadComboBoxes();
            AutoUzupelnijFormularz();
            WyswietlUzytkownikow();
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

        private void AutoUzupelnijFormularz()
        {
            textBoxLogin.Text = "testuser";
            textBoxImie.Text = "Jan";
            textBoxNazwisko.Text = "Kowalski";
            textBoxPesel.Text = "67052439545";
            dateTimePickerDataUrodzenia.Value = new DateTime(2001, 1, 1);
            textBoxEmail.Text = "jan.kowalski@example.com";
            textBoxTelefon.Text = "123456789";
            textBoxMiejscowosc.Text = "Warszawa";
            textBoxKodPocztowy.Text = "00-001";
            textBoxUlica.Text = "Testowa";
            textBoxNrPosesji.Text = "12A";
            textBoxNrLokalu.Text = "3";
            comboBoxPlec.SelectedIndex = 0;
            comboBoxRola.SelectedIndex = 0;
        }

        private void buttonUzupelnij_Click(object sender, EventArgs e)
        {
            AutoUzupelnijFormularz();
            MessageBox.Show("Formularz został uzupełniony!");
        }

        private void buttonEdytuj_Click_1(object sender, EventArgs e)
        {
            if (edytowanyUzytkownikID == -1)
            {
                MessageBox.Show("Nie wybrano użytkownika do edycji.");
                return;
            }

            string imie = textBoxImie.Text.Trim();
            string nazwisko = textBoxNazwisko.Text.Trim();
            string pesel = textBoxPesel.Text.Trim();
            string login = textBoxLogin.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string telefon = textBoxTelefon.Text.Trim();

            if (!Validator.ValidateUserDataDetailed(login, pesel, email, telefon, "x", "00-000", "x", "x", out string errorMsg))
            {
                MessageBox.Show("Błąd walidacji: " + errorMsg);
                return;
            }

            bool sukces = DatabaseHelper.UpdateUser(connectionString, edytowanyUzytkownikID, imie, nazwisko, pesel, login, email, telefon);

            if (sukces)
            {
                MessageBox.Show("Dane użytkownika zostały zaktualizowane!");
                edytowanyUzytkownikID = -1;
                WyswietlUzytkownikow();
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizacji użytkownika.");
            }
        }

        private void WyswietlUzytkownikow()
        {
            var dt = DatabaseHelper.GetUzytkownicy(connectionString);
            dataGridViewUzytkownicy.DataSource = dt;
            dataGridViewUzytkownicy.Columns["ID_uzytkownik"].Visible = false;
        }
        private void dataGridViewUzytkownicy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUzytkownicy.Rows[e.RowIndex];
                edytowanyUzytkownikID = Convert.ToInt32(row.Cells["ID_uzytkownik"].Value);

                textBoxImie.Text = row.Cells["imie"].Value.ToString();
                textBoxNazwisko.Text = row.Cells["nazwisko"].Value.ToString();
                textBoxPesel.Text = row.Cells["PESEL"].Value.ToString();
                textBoxLogin.Text = row.Cells["Login_uzytkownika"].Value.ToString();
                textBoxEmail.Text = row.Cells["email"].Value.ToString();
                textBoxTelefon.Text = row.Cells["Numer_telefonu"].Value.ToString();
            }
        }

        private void button_Click(object sender, EventArgs e)
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
            string nrLokalu = textBoxNrLokalu.Text.Trim();
            DateTime dataUrodzenia = dateTimePickerDataUrodzenia.Value;

            int idPlec = ((KeyValuePair<int, string>)comboBoxPlec.SelectedItem).Key;
            int idRola = ((KeyValuePair<int, string>)comboBoxRola.SelectedItem).Key;

            if (!Validator.ValidateUserDataDetailed(login, pesel, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, out string errorMsg))
            {
                MessageBox.Show(errorMsg, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseHelper.IsUserExists(connectionString, login, pesel, email))
            {
                MessageBox.Show("Użytkownik o podanym loginie, PESEL-u lub adresie e-mail już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool sukces = DatabaseHelper.AddUser(
                connectionString, login, imie, nazwisko, pesel, email, telefon,
                miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu,
                dataUrodzenia, idPlec, idRola);

            if (sukces)
            {
                MessageBox.Show("Użytkownik dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WyswietlUzytkownikow();
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Click_1(object sender, EventArgs e)
        {

        }
    }
}
