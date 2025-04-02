using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BIBLIOTEKA_TESTOWANIE
{
    public partial class Form3 : Form
    {
        private string connectionString = "Server=LAPTOPIK-K4514\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";
        private int edytowanyUzytkownikID = -1;

        public Form3()
        {
            InitializeComponent();
            WyswietlUzytkownikow();
            textBox1.TextChanged += textBox1_TextChanged;

            // Inicjalizacja ComboBoxa
            comboBoxKryterium.Items.Add("Imię");
            comboBoxKryterium.Items.Add("Nazwisko");
            comboBoxKryterium.Items.Add("Login");
            comboBoxKryterium.SelectedIndex = 0; // Domyślne kryterium: Imię
        }

        private void WyswietlUzytkownikow()
        {
            var dt = DatabaseHelper.GetUzytkownicy(connectionString);
            dataGridViewUzytkownicy.DataSource = dt;
            dataGridViewUzytkownicy.Columns["ID_uzytkownik"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(filterText))
            {
                WyswietlUzytkownikow();
                return;
            }

            string kolumna = "Imie"; // Domyślnie

            if (comboBoxKryterium.SelectedItem != null)
            {
                switch (comboBoxKryterium.SelectedItem.ToString())
                {
                    case "Imię":
                        kolumna = "Imie";
                        break;
                    case "Nazwisko":
                        kolumna = "Nazwisko";
                        break;
                    case "Login":
                        kolumna = "Login_uzytkownika";
                        break;
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM dbo.Uzytkownik WHERE {kolumna} LIKE @filter";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@filter", "%" + filterText + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUzytkownicy.DataSource = dt;
                dataGridViewUzytkownicy.Columns["ID_uzytkownik"].Visible = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
         
        }

        private void buttonSzczegoly_Click(object sender, EventArgs e)
        {
            if (dataGridViewUzytkownicy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika z listy.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewUzytkownicy.SelectedRows[0].Cells["ID_uzytkownik"].Value);

            FormSzczegoly szczegolyForm = new FormSzczegoly(id, connectionString);
            szczegolyForm.FormClosed += (s, args) => WyswietlUzytkownikow(); // Odświeżenie listy po zamknięciu
            szczegolyForm.ShowDialog();
        }
    }
}
