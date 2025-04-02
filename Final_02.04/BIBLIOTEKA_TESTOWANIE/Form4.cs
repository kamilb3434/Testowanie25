using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace BIBLIOTEKA_TESTOWANIE
{
    public partial class Form4 : Form
    {
        private string connectionString = "Server=LAPTOPIK-K4514\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";
        private int edytowanyUzytkownikID = -1;

        public Form4()
        {
            InitializeComponent();
            WyswietlUzytkownikow();
            WyswietlZapomnianychUzytkownikow();
        }

        private void ZapomnijUzytkownika(int userId)
            {
                string LosoweImie = GenerowanieLosowegoStringa(10);
                string LosoweNazwisko = GenerowanieLosowegoStringa(12);
                string LosowyPesel = GenerowanieLosowegoPeselu();
                string LosowaData = GenerowanieLosowejDaty();
                int LosowaPlec = new Random().Next(1, 3);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Pobranie ID użytkownika z rolą administratora (FK_ID_rola = 2)
                    int idAdmina = -1;
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 ID_uzytkownik FROM dbo.Uzytkownik WHERE FK_ID_rola = 2", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            idAdmina = Convert.ToInt32(result);
                        }
                    }

                    if (idAdmina == -1)
                    {
                        MessageBox.Show("Brak administratora w bazie!");
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE dbo.Uzytkownik " +
                        "SET Imie = @imie, Nazwisko = @nazwisko, PESEL = @pesel, Data_urodzenia = @data, FK_ID_Plec = @plec, Czy_zapomniany = 1 " +
                        "WHERE ID_uzytkownik = @id; " +
                        "INSERT INTO dbo.Zapominany (FK_ID_uzytkownik, Data_zapomnienia, Zglaszacz) VALUES (@id, GETDATE(), @zglaszacz);",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        cmd.Parameters.AddWithValue("@imie", LosoweImie);
                        cmd.Parameters.AddWithValue("@nazwisko", LosoweNazwisko);
                        cmd.Parameters.AddWithValue("@pesel", LosowyPesel);
                        cmd.Parameters.AddWithValue("@data", LosowaData);
                        cmd.Parameters.AddWithValue("@plec", LosowaPlec);
                        cmd.Parameters.AddWithValue("@zglaszacz", idAdmina);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            private string GenerowanieLosowegoStringa(int length)
            {
                const string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                return new string(Enumerable.Repeat(znaki, length).Select(s => s[new Random().Next(s.Length)]).ToArray());
            }

            private string GenerowanieLosowegoPeselu()
            {
                Random rnd = new Random();
                return rnd.Next(100000000, 999999999).ToString() + rnd.Next(10, 99).ToString();
            }

            private string GenerowanieLosowejDaty()
            {
                Random rnd = new Random();
                DateTime start = new DateTime(1950, 1, 1);
                DateTime end = new DateTime(2005, 12, 31);
                int range = (end - start).Days;
                return start.AddDays(rnd.Next(range)).ToString("yyyy-MM-dd");
            }


            private void WyswietlZapomnianychUzytkownikow()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
            SELECT 
                z.FK_ID_uzytkownik AS ID, 
                u.Imie AS Imie_po_zapomnieniu, 
                u.Nazwisko AS Nazwisko_po_zapomnieniu, 
                z.Data_zapomnienia, 
                z.Zglaszacz AS ID_zglaszajacego
            FROM dbo.Zapominany z
            JOIN dbo.Uzytkownik u ON z.FK_ID_uzytkownik = u.ID_uzytkownik
            WHERE u.Czy_zapomniany = 1";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Brak zapomnianych użytkowników", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView_zapomniani.DataSource = dt;
                    }
                }
            }

            private void WyswietlUzytkownikow()
            {
                var dt = DatabaseHelper.GetUzytkownicy(connectionString);
                dataGridViewUzytkownicy.DataSource = dt;
                dataGridViewUzytkownicy.Columns["ID_uzytkownik"].Visible = false;
            }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button_zapomnij_Click(object sender, EventArgs e)
        {
            if (dataGridViewUzytkownicy.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUzytkownicy.SelectedRows[0].Cells["ID_uzytkownik"].Value);
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zapomnieć dane użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ZapomnijUzytkownika(userId);
                    WyswietlUzytkownikow();
                    MessageBox.Show("Użytkownik został zapomniany.");
                }
            }
            else
            {
                MessageBox.Show("Wybierz użytkownika do zapomnienia.");
            }
        }

        private void button_ZnajdzZapomnianych_Click_1(object sender, EventArgs e)
        {
            WyswietlZapomnianychUzytkownikow();
        }
    }
}
