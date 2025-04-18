﻿using System;
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
    public partial class AdminFormZapomnieniUzytkownicy : Form
    {
        private string connectionString = "Server=DESKTOP-LE67A8P\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";
        private int edytowanyUzytkownikID = -1;

        public AdminFormZapomnieniUzytkownicy()
        {
            InitializeComponent();
            WyswietlZapomnianychUzytkownikow();
            this.Text = "Zapomnieni użytkownicy";
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
        private void button_ZnajdzZapomnianych_Click_1(object sender, EventArgs e)
        {
            WyswietlZapomnianychUzytkownikow();
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            AdminFormPanelGlowny formStart = new AdminFormPanelGlowny();
            formStart.Show();
            this.Close();
        }

        private void FormZapomnieni_Load(object sender, EventArgs e)
        {

        }
    }
}
