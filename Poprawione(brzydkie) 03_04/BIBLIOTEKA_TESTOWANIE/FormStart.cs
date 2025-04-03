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
    public partial class FormStart : Form
    {
        private string connectionString = "Server=LAPTOPIK-K4514\\SQLEXPRESS;Database=Testowanie;Integrated Security=True;TrustServerCertificate=True";
        private int edytowanyUzytkownikID = -1;

        public FormStart()
        {
            InitializeComponent();
            //dataGridViewUzytkownicy = new DataGridView();
            //this.Controls.Add(dataGridViewUzytkownicy);
            // WyswietlUzytkownikow();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }
        private void buttonDodaj_Click_1(object sender, EventArgs e)
        {
            FormDodaj formDodaj = new FormDodaj();
            formDodaj.Show();
            this.Hide();

        }
        private void buttonPodglad_Click_1(object sender, EventArgs e)
        {
            FormPodglad formPodglad = new FormPodglad();
            formPodglad.Show();
            this.Hide();
        }
        private void buttonZapomnieni_Click_1(object sender, EventArgs e)
        {
            FormZapomnieni formZapomnieni = new FormZapomnieni();
            formZapomnieni.Show();
            this.Hide();
        }
    }

}
