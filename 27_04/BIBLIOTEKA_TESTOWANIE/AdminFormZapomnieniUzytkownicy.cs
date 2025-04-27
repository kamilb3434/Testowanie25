using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BIBLIOTEKA_TESTOWANIE
{
    public partial class AdminFormZapomnieniUzytkownicy : Form
    {
        private string connectionString = "Server=LAPTOPIK-K4514\\SQLEXPRESS;Database=TEST1;Integrated Security=True;TrustServerCertificate=True";

        public AdminFormZapomnieniUzytkownicy()
        {
            InitializeComponent();
            this.Text = "LibraSys | Zapomniani użytkownicy";
            WyswietlZapomnianychUzytkownikow();
        }

        private void WyswietlZapomnianychUzytkownikow()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                u.ID_uzytkownik AS [ID użytkownika],
                u.Imie AS [Imię po zapomnieniu],
                u.Nazwisko AS [Nazwisko po zapomnieniu],
                z.Data_zapomnienia AS [Data zapomnienia],
                z.Zglaszacz AS [ID zgłaszającego]
            FROM dbo.Uzytkownik u
            INNER JOIN dbo.Zapominany z ON u.ID_uzytkownik = z.FK_ID_uzytkownik
            WHERE u.Czy_zapomniany = 1";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Brak zapomnianych użytkowników.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_zapomniani.DataSource = null;
                }
                else
                {
                    dataGridView_zapomniani.DataSource = dt;
                    dataGridView_zapomniani.Refresh();
                }
            }
        }


        private void button_ZnajdzZapomnianych_Click(object sender, EventArgs e)
        {
            WyswietlZapomnianychUzytkownikow();
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            AdminFormPanelGlowny formStart = new AdminFormPanelGlowny();
            formStart.Show();
            this.Close();
        }

        private void AdminFormZapomnieniUzytkownicy_Load(object sender, EventArgs e)
        {
            // Opcjonalnie możesz tu też dać WyswietlZapomnianychUzytkownikow() jeśli chcesz automatycznie odświeżać po wejściu.
        }
    }
}
