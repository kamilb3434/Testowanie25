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
        private string connectionString = "Server=LAPTOPIK-K4514\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";
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
      
        private void buttonDodaj_Click_1(object sender, EventArgs e)
        {
            AdminFormDodajUzytkownika formDodaj = new AdminFormDodajUzytkownika();
            formDodaj.Show();
            this.Hide();

        }
        private void buttonPodglad_Click_1(object sender, EventArgs e)
        {
            AdminFormAktywniUzytkownicy formPodglad = new AdminFormAktywniUzytkownicy();
            formPodglad.Show();
            this.Hide();
        }
        private void buttonZapomnieni_Click_1(object sender, EventArgs e)
        {
            AdminFormZapomnieniUzytkownicy formZapomnieni = new AdminFormZapomnieniUzytkownicy();
            formZapomnieni.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }
    }

}
