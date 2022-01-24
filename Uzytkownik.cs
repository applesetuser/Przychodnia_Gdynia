using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Przychodnia_Gdynia
{
    public class Uzytkownik
    {
        private string Imie;
        private string Nazwisko;
        private string Email;
        private string Haslo;
        public Boolean Zalogowany;
        public Boolean Zarejestrowany;
        public string GetImie() { return this.Imie; }
        public string GetNazwisko() { return this.Nazwisko; }
        public string GetEmail() { return this.Email; }
        public string GetHaslo() { return this.Haslo; }
        public Boolean GetZalogowany() { return this.Zalogowany; }
        public Boolean GetZarejestrowany() { return this.Zarejestrowany; }
        public Uzytkownik(Boolean zalogowany, Boolean zarejestrowany)
        {
            this.Zalogowany = zalogowany;
            this.Zarejestrowany = zarejestrowany;
        }
        public Uzytkownik(Boolean zalogowany, Boolean zarejestrowany, string imie, string nazwisko, string email, string haslo)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Email = email;
            this.Haslo = haslo;
            this.Zalogowany = zalogowany;
            this.Zarejestrowany = zarejestrowany;
        }
    }

}