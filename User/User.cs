
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Przychodnia_Gdynia
{    
    public class User
    {
        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private string PESEL { get; set; }
        private string Email { get; set; }
        private string Haslo { get; set; }
        public Boolean Zalogowany { get; set; }
        //public Boolean Zarejestrowany { get; set; }
        //public string GetImie() { return this.Imie; }
        //public string GetNazwisko() { return this.Nazwisko; }
        //public string GetEmail() { return this.Email; }
        //public string GetHaslo() { return this.Haslo; }
        //public Boolean GetZalogowany() { return this.Zalogowany; }
        //public Boolean GetZarejestrowany() { return this.Zarejestrowany; }
        //public User(Boolean zalogowany, Boolean zarejestrowany)
        //{
        //    this.Zalogowany = zalogowany;
        //    this.Zarejestrowany = zarejestrowany;
        //}
        //public User(Boolean zalogowany, Boolean zarejestrowany, string imie, string nazwisko, string email, string haslo)
        //{
        //    this.Imie = imie;
        //    this.Nazwisko = nazwisko;
        //    this.Email = email;
        //    this.Haslo = haslo;
        //    this.Zalogowany = zalogowany;
        //    this.Zarejestrowany = zarejestrowany;
        //}
    }
}