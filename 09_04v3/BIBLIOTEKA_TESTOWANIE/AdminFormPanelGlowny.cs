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
    public partial class AdminFormPanelGlowny : Form
    {
        private string connectionString = "Server=DESKTOP-LE67A8P\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";
        //private string connectionString = "Server=desktop-7l2t535\\SQLEXPRESS;Database=TEsting;Integrated Security=True;TrustServerCertificate=True";
        //private string connectionString = "Server=desktop-7l2t535;Database=TEsting;Trusted_Connection=True;TrustServerCertificate=True;";
        //private string connectionString = "Server=localhost;Database=TEsting;Trusted_Connection=True;TrustServerCertificate=True;";

        private int edytowanyUzytkownikID = -1;

        public AdminFormPanelGlowny()
        {
            InitializeComponent();
            //dataGridViewUzytkownicy = new DataGridView();
            //this.Controls.Add(dataGridViewUzytkownicy);
            // WyswietlUzytkownikow();
        }
        private void buttonDodajUzytkownika_Click(object sender, EventArgs e)
        {
            AdminFormDodajUzytkownika formDodaj = new AdminFormDodajUzytkownika();
            formDodaj.Show();
            this.Hide();
        }

        private void buttonAktywniUzytkownicy_Click(object sender, EventArgs e)
        {
            AdminFormAktywniUzytkownicy formPodglad = new AdminFormAktywniUzytkownicy();
            formPodglad.Show();
            this.Hide();
        }

        private void buttonZapomnieniUzytkownicy_Click(object sender, EventArgs e)
        {
            AdminFormZapomnieniUzytkownicy formZapomnieni = new AdminFormZapomnieniUzytkownicy();
            formZapomnieni.Show();
            this.Hide();
        }
    }

}
