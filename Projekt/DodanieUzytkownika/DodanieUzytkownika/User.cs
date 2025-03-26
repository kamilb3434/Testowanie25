using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodanieUzytkownika
{
    public class User
    {
        public string Login { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Plec { get; set; }

        public User(string login, string imie, string nazwisko, string pesel, string email, string telefon, string plec)
        {
            Login = login;
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            Email = email;
            Telefon = telefon;
            Plec = plec;
        }
    }
}
