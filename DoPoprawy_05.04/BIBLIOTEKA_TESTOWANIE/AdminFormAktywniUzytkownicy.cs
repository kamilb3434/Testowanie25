using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BIBLIOTEKA_TESTOWANIE
{
    public partial class AdminFormAktywniUzytkownicy : Form
    {
        private string connectionString = "Server=LAPTOPIK-K4514\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";
        //private string connectionString = "Server=desktop-7l2t535;Database=TEsting;Trusted_Connection=True;TrustServerCertificate=True;";

        public AdminFormAktywniUzytkownicy()
        {
            InitializeComponent();
            WyswietlUzytkownikow();
            this.Text = "Podgląd użytkowników";

            textBoxImie.TextChanged += FiltrujUzytkownikow;
            textBoxNazwisko.TextChanged += FiltrujUzytkownikow;
            textBoxLogin.TextChanged += FiltrujUzytkownikow;
        }

        private void WyswietlUzytkownikow()
        {
            var dt = DatabaseHelper.GetUzytkownicy(connectionString);
            dataGridViewUzytkownicy.DataSource = dt;
            dataGridViewUzytkownicy.Columns["ID_uzytkownik"].Visible = false;
        }

        private void FiltrujUzytkownikow(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text.Trim();
            string nazwisko = textBoxNazwisko.Text.Trim();
            string login = textBoxLogin.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM dbo.Uzytkownik WHERE 1=1";

                if (!string.IsNullOrEmpty(imie))
                    query += " AND Imie LIKE @imie";
                if (!string.IsNullOrEmpty(nazwisko))
                    query += " AND Nazwisko LIKE @nazwisko";
                if (!string.IsNullOrEmpty(login))
                    query += " AND Login_uzytkownika LIKE @login";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(imie))
                    cmd.Parameters.AddWithValue("@imie", "%" + imie + "%");
                if (!string.IsNullOrEmpty(nazwisko))
                    cmd.Parameters.AddWithValue("@nazwisko", "%" + nazwisko + "%");
                if (!string.IsNullOrEmpty(login))
                    cmd.Parameters.AddWithValue("@login", "%" + login + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUzytkownicy.DataSource = dt;
                if (dt.Columns.Contains("ID_uzytkownik"))
                    dataGridViewUzytkownicy.Columns["ID_uzytkownik"].Visible = false;
            }
        }

        private void buttonSzczegoly_Click(object sender, EventArgs e)
        {
            if (dataGridViewUzytkownicy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika z listy.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewUzytkownicy.SelectedRows[0].Cells["ID_uzytkownik"].Value);

            AdminFormPodgladDanych szczegoly = new AdminFormPodgladDanych(id, connectionString);
            szczegoly.FormClosed += (s, args) => WyswietlUzytkownikow();
            szczegoly.ShowDialog();
            this.Hide();
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            AdminFormPanelGlowny formStart = new AdminFormPanelGlowny();
            formStart.Show();
            this.Close();
        }

        private void FormPodglad_Load(object sender, EventArgs e)
        {

        }
    }
}
