using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BIBLIOTEKA_TESTOWANIE
{
    public partial class FormSzczegoly : Form
    {
        private int uzytkownikID;
        private Button buttonEdytuj;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBoxNrLokalu;
        private TextBox textBoxNrPosesji;
        private TextBox textBoxUlica;
        private TextBox textBoxKodPocztowy;
        private Label label1;
        private TextBox textBoxMiejscowosc;
        private ComboBox comboBoxPlec;
        private DateTimePicker dateTimePickerDataUrodzenia;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxTelefon;
        private TextBox textBoxEmail;
        private TextBox textBoxPesel;
        private Label rola;
        private ComboBox comboBoxRola;
        private Label label3;
        private Label imie;
        private Label dane;
        private TextBox textBoxNazwisko;
        private TextBox textBoxImie;
        private TextBox textBoxLogin;
        private string connectionString;

        public FormSzczegoly(int id, string connStr)
        {
            uzytkownikID = id;
            connectionString = connStr;
            InitializeComponent();
            WczytajDane();
        }

        private void WczytajDane()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT u.*, a.Miejscowosc, a.Kod_pocztowy, a.Ulica, a.Numer_ulicy, a.Numer_lokalu, r.Nazwa_Roli AS Rola, p.Rodzaj AS Plec
                                 FROM dbo.Uzytkownik u
                                 INNER JOIN dbo.Rola r ON u.FK_ID_rola = r.ID_rola
                                 INNER JOIN dbo.Plec p ON u.FK_ID_plec = p.ID_plec
                                 INNER JOIN dbo.Adres a ON u.FK_ID_adres = a.ID_adres
                                 WHERE u.ID_uzytkownik = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", uzytkownikID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBoxLogin.Text = reader["Login_uzytkownika"].ToString();
                    textBoxImie.Text = reader["Imie"].ToString();
                    textBoxNazwisko.Text = reader["Nazwisko"].ToString();
                    comboBoxRola.Text = reader["Rola"].ToString();
                    textBoxPesel.Text = reader["PESEL"].ToString();
                    dateTimePickerDataUrodzenia.Value = Convert.ToDateTime(reader["Data_urodzenia"]);
                    comboBoxPlec.Text = reader["Plec"].ToString();
                    textBoxEmail.Text = reader["Email"].ToString();
                    textBoxTelefon.Text = reader["Numer_telefonu"].ToString();
                    textBoxMiejscowosc.Text = reader["Miejscowosc"].ToString();
                    textBoxKodPocztowy.Text = reader["Kod_pocztowy"].ToString();
                    textBoxUlica.Text = reader["Ulica"].ToString();
                    textBoxNrPosesji.Text = reader["Numer_ulicy"].ToString();
                    textBoxNrLokalu.Text = reader["Numer_lokalu"].ToString();
                }
            }
        }
        private int GetForeignKeyId(SqlConnection conn, string tabela, string kolumnaNazwy, string wartosc)
        {
            string query = $"SELECT TOP 1 ID_{tabela.ToLower()} FROM dbo.{tabela} WHERE {kolumnaNazwy} = @wartosc";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@wartosc", wartosc);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void InitializeComponent()
        {
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNrLokalu = new System.Windows.Forms.TextBox();
            this.textBoxNrPosesji = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.textBoxKodPocztowy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMiejscowosc = new System.Windows.Forms.TextBox();
            this.comboBoxPlec = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.rola = new System.Windows.Forms.Label();
            this.comboBoxRola = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.Label();
            this.dane = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.BackColor = System.Drawing.Color.Peru;
            this.buttonEdytuj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdytuj.Location = new System.Drawing.Point(815, 329);
            this.buttonEdytuj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(161, 59);
            this.buttonEdytuj.TabIndex = 98;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = false;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(710, 259);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 96;
            this.label13.Text = "Numer lokalu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(710, 216);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 95;
            this.label12.Text = "Numer posesji:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(752, 177);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 94;
            this.label11.Text = "Ulica:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(710, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 93;
            this.label10.Text = "Kod pocztowy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(724, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 92;
            this.label9.Text = "Miejscowość:";
            // 
            // textBoxNrLokalu
            // 
            this.textBoxNrLokalu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNrLokalu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNrLokalu.Location = new System.Drawing.Point(859, 258);
            this.textBoxNrLokalu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNrLokalu.Name = "textBoxNrLokalu";
            this.textBoxNrLokalu.Size = new System.Drawing.Size(163, 24);
            this.textBoxNrLokalu.TabIndex = 91;
            // 
            // textBoxNrPosesji
            // 
            this.textBoxNrPosesji.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNrPosesji.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNrPosesji.Location = new System.Drawing.Point(859, 215);
            this.textBoxNrPosesji.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNrPosesji.Name = "textBoxNrPosesji";
            this.textBoxNrPosesji.Size = new System.Drawing.Size(163, 24);
            this.textBoxNrPosesji.TabIndex = 90;
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUlica.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUlica.Location = new System.Drawing.Point(859, 175);
            this.textBoxUlica.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(163, 24);
            this.textBoxUlica.TabIndex = 89;
            // 
            // textBoxKodPocztowy
            // 
            this.textBoxKodPocztowy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxKodPocztowy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKodPocztowy.Location = new System.Drawing.Point(859, 135);
            this.textBoxKodPocztowy.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKodPocztowy.Name = "textBoxKodPocztowy";
            this.textBoxKodPocztowy.Size = new System.Drawing.Size(163, 24);
            this.textBoxKodPocztowy.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(755, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Adres zamieszkania:";
            // 
            // textBoxMiejscowosc
            // 
            this.textBoxMiejscowosc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMiejscowosc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMiejscowosc.Location = new System.Drawing.Point(859, 90);
            this.textBoxMiejscowosc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMiejscowosc.Name = "textBoxMiejscowosc";
            this.textBoxMiejscowosc.Size = new System.Drawing.Size(163, 24);
            this.textBoxMiejscowosc.TabIndex = 86;
            // 
            // comboBoxPlec
            // 
            this.comboBoxPlec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPlec.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPlec.FormattingEnabled = true;
            this.comboBoxPlec.Location = new System.Drawing.Point(444, 394);
            this.comboBoxPlec.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPlec.Name = "comboBoxPlec";
            this.comboBoxPlec.Size = new System.Drawing.Size(132, 25);
            this.comboBoxPlec.TabIndex = 85;
            // 
            // dateTimePickerDataUrodzenia
            // 
            this.dateTimePickerDataUrodzenia.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerDataUrodzenia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDataUrodzenia.Location = new System.Drawing.Point(343, 344);
            this.dateTimePickerDataUrodzenia.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataUrodzenia.Name = "dateTimePickerDataUrodzenia";
            this.dateTimePickerDataUrodzenia.Size = new System.Drawing.Size(323, 24);
            this.dateTimePickerDataUrodzenia.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(372, 500);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Numer telefonu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(374, 434);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Adres e-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(374, 394);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "Płeć:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(374, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Data urodzenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(374, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Pesel:";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTelefon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTelefon.Location = new System.Drawing.Point(378, 524);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(199, 24);
            this.textBoxTelefon.TabIndex = 78;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(378, 457);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(199, 24);
            this.textBoxEmail.TabIndex = 77;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPesel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPesel.Location = new System.Drawing.Point(444, 271);
            this.textBoxPesel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(132, 24);
            this.textBoxPesel.TabIndex = 76;
            // 
            // rola
            // 
            this.rola.AutoSize = true;
            this.rola.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rola.Location = new System.Drawing.Point(378, 228);
            this.rola.Name = "rola";
            this.rola.Size = new System.Drawing.Size(54, 20);
            this.rola.TabIndex = 75;
            this.rola.Text = "Rola:";
            // 
            // comboBoxRola
            // 
            this.comboBoxRola.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxRola.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRola.FormattingEnabled = true;
            this.comboBoxRola.Location = new System.Drawing.Point(444, 227);
            this.comboBoxRola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRola.Name = "comboBoxRola";
            this.comboBoxRola.Size = new System.Drawing.Size(132, 25);
            this.comboBoxRola.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(339, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Nazwisko:";
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.Location = new System.Drawing.Point(378, 136);
            this.imie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(57, 20);
            this.imie.TabIndex = 72;
            this.imie.Text = "Imię:";
            this.imie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dane.Location = new System.Drawing.Point(374, 92);
            this.dane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(63, 20);
            this.dane.TabIndex = 71;
            this.dane.Text = "Login:";
            this.dane.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNazwisko.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwisko.Location = new System.Drawing.Point(444, 180);
            this.textBoxNazwisko.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(132, 24);
            this.textBoxNazwisko.TabIndex = 70;
            // 
            // textBoxImie
            // 
            this.textBoxImie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxImie.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImie.Location = new System.Drawing.Point(444, 136);
            this.textBoxImie.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(132, 24);
            this.textBoxImie.TabIndex = 69;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxLogin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(444, 90);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(132, 24);
            this.textBoxLogin.TabIndex = 68;
            // 
            // FormSzczegoly
            // 
            this.ClientSize = new System.Drawing.Size(1360, 594);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNrLokalu);
            this.Controls.Add(this.textBoxNrPosesji);
            this.Controls.Add(this.textBoxUlica);
            this.Controls.Add(this.textBoxKodPocztowy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMiejscowosc);
            this.Controls.Add(this.comboBoxPlec);
            this.Controls.Add(this.dateTimePickerDataUrodzenia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.rola);
            this.Controls.Add(this.comboBoxRola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormSzczegoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonEdytuj_Click_1(object sender, EventArgs e)
        {
            string errorMsg;
            if (!Validator.ValidateUserDataDetailed(
                textBoxLogin.Text,
                textBoxPesel.Text,
                textBoxEmail.Text,
                textBoxTelefon.Text,
                textBoxMiejscowosc.Text,
                textBoxKodPocztowy.Text,
                textBoxUlica.Text,
                textBoxNrPosesji.Text,
                out errorMsg))
            {
                MessageBox.Show(errorMsg, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                int idRola = GetForeignKeyId(conn, "Rola", "Nazwa_rolI", comboBoxRola.Text);
                int idPlec = GetForeignKeyId(conn, "Plec", "Rodzaj", comboBoxPlec.Text);

                string updateAdres = @"UPDATE dbo.Adres SET 
                                        Miejscowosc = @Miejscowosc, Kod_pocztowy = @Kod, Ulica = @Ulica, 
                                        Numer_ulicy = @NrUl, Numer_lokalu = @NrLok 
                                      WHERE ID_adres = (SELECT FK_ID_adres FROM dbo.Uzytkownik WHERE ID_uzytkownik = @ID)";

                SqlCommand cmdAdres = new SqlCommand(updateAdres, conn);
                cmdAdres.Parameters.AddWithValue("@Miejscowosc", textBoxMiejscowosc.Text);
                cmdAdres.Parameters.AddWithValue("@Kod", textBoxKodPocztowy.Text);
                cmdAdres.Parameters.AddWithValue("@Ulica", textBoxUlica.Text);
                cmdAdres.Parameters.AddWithValue("@NrUl", textBoxNrPosesji.Text);
                cmdAdres.Parameters.AddWithValue("@NrLok", textBoxNrLokalu.Text);
                cmdAdres.Parameters.AddWithValue("@ID", uzytkownikID);
                cmdAdres.ExecuteNonQuery();

                string updateUzytkownik = @"UPDATE dbo.Uzytkownik SET 
                                            Login_uzytkownika = @Login, Imie = @Imie, Nazwisko = @Nazwisko, PESEL = @PESEL,
                                            Data_urodzenia = @DataUr, Email = @Email, Numer_telefonu = @Tel,
                                            FK_ID_plec = @IDPlec, FK_ID_rola = @IDRola
                                          WHERE ID_uzytkownik = @ID";

                SqlCommand cmd = new SqlCommand(updateUzytkownik, conn);
                cmd.Parameters.AddWithValue("@Login", textBoxLogin.Text);
                cmd.Parameters.AddWithValue("@Imie", textBoxImie.Text);
                cmd.Parameters.AddWithValue("@Nazwisko", textBoxNazwisko.Text);
                cmd.Parameters.AddWithValue("@PESEL", textBoxPesel.Text);
                cmd.Parameters.AddWithValue("@DataUr", dateTimePickerDataUrodzenia.Value);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Tel", textBoxTelefon.Text);
                cmd.Parameters.AddWithValue("@IDPlec", idPlec);
                cmd.Parameters.AddWithValue("@IDRola", idRola);
                cmd.Parameters.AddWithValue("@ID", uzytkownikID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dane użytkownika zostały zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
