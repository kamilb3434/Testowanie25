using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BIBLIOTEKA_TESTOWANIE
{
    public static class DatabaseHelper
    {
        public static bool IsUserExists(string connectionString, string login, string pesel, string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Uzytkownik WHERE Login_uzytkownika = @login OR PESEL = @pesel OR email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pesel", pesel);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static bool AddUser(string connectionString,
            string login,
            string imie,
            string nazwisko,
            string pesel,
            string email,
            string telefon,
            string miejscowosc,
            string kodPocztowy,
            string ulica,
            string nrPosesji,
            string nrLokalu,
            DateTime dataUrodzenia,
            int idPlec,
            int idRola)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string insertAdresQuery = @"INSERT INTO Adres (Kraj, Miejscowosc, Kod_pocztowy, Ulica, Numer_ulicy, Numer_lokalu)
                                                OUTPUT INSERTED.ID_adres
                                                VALUES (@Kraj, @Miejscowosc, @KodPocztowy, @Ulica, @NrPosesji, @NrLokalu)";
                    int idAdres;

                    using (SqlCommand cmdAdres = new SqlCommand(insertAdresQuery, conn, transaction))
                    {
                        cmdAdres.Parameters.AddWithValue("@Kraj", "Polska");
                        cmdAdres.Parameters.AddWithValue("@Miejscowosc", miejscowosc);
                        cmdAdres.Parameters.AddWithValue("@KodPocztowy", kodPocztowy);
                        cmdAdres.Parameters.AddWithValue("@Ulica", ulica);
                        cmdAdres.Parameters.AddWithValue("@NrPosesji", nrPosesji);
                        cmdAdres.Parameters.AddWithValue("@NrLokalu", nrLokalu);

                        idAdres = (int)cmdAdres.ExecuteScalar();
                    }

                    string insertUserQuery = @"INSERT INTO Uzytkownik (imie, nazwisko, FK_ID_plec, Data_urodzenia, PESEL,
                                                Numer_telefonu, Login_uzytkownika, Haslo, email, FK_ID_rola, FK_ID_adres, Czy_zapomniany)
                                               VALUES (@Imie, @Nazwisko, @IDPlec, @DataUrodzenia, @PESEL,
                                                @Telefon, @Login, @Haslo, @Email, @IDRola, @IDAdres, 0)";

                    using (SqlCommand cmdUser = new SqlCommand(insertUserQuery, conn, transaction))
                    {
                        cmdUser.Parameters.AddWithValue("@Imie", imie);
                        cmdUser.Parameters.AddWithValue("@Nazwisko", nazwisko);
                        cmdUser.Parameters.AddWithValue("@IDPlec", idPlec);
                        cmdUser.Parameters.AddWithValue("@DataUrodzenia", dataUrodzenia);
                        cmdUser.Parameters.AddWithValue("@PESEL", pesel);
                        cmdUser.Parameters.AddWithValue("@Telefon", telefon);
                        cmdUser.Parameters.AddWithValue("@Login", login);
                        cmdUser.Parameters.AddWithValue("@Haslo", "HasloDomyslne123");
                        cmdUser.Parameters.AddWithValue("@Email", email);
                        cmdUser.Parameters.AddWithValue("@IDRola", idRola);
                        cmdUser.Parameters.AddWithValue("@IDAdres", idAdres);

                        cmdUser.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Błąd SQL:\n" + ex.Message, "Wyjątek SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static DataTable GetUzytkownicy(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                                    ID_uzytkownik,
                                    imie,
                                    nazwisko,
                                    PESEL,
                                    Login_uzytkownika,
                                    email,
                                    Numer_telefonu
                                FROM Uzytkownik";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool UpdateUser(string connectionString, int id, string imie, string nazwisko, string pesel, string login, string email, string telefon)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Uzytkownik
                                 SET imie = @Imie,
                                     nazwisko = @Nazwisko,
                                     PESEL = @PESEL,
                                     Login_uzytkownika = @Login,
                                     email = @Email,
                                     Numer_telefonu = @Telefon
                                 WHERE ID_uzytkownik = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Imie", imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    cmd.Parameters.AddWithValue("@PESEL", pesel);
                    cmd.Parameters.AddWithValue("@Login", login);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telefon", telefon);
                    cmd.Parameters.AddWithValue("@ID", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
