using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Przychodnia_Gdynia
{
    class Rejestracja
    {
        public static void DodawanieUzytkownika()
        {
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            System.Console.WriteLine();
            string pesel = Funkcje_Pomocnicze.WritePESEL();
            string name = Funkcje_Pomocnicze.WriteVariable("Imie");
            string surname = Funkcje_Pomocnicze.WriteVariable("Nazwisko");

            Console.Write("Podaj Hasło: ");
            string password = ReadLine();
            Console.Write("Powtórz Hasło: ");
            string password2 = ReadLine();
            Funkcje_Pomocnicze.ValidatePassword(password, password2);

            Console.Write("Podaj date urodzenia w formacie [dd.mm.rrrr]: ");
            string birth;
            while (true)
            {
                string input = Console.ReadLine();
                if (Funkcje_Pomocnicze.DateCheck(input) == true)
                {
                    birth = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Podana data jest nieprawidlowa.");
                    Console.Write("Podaj date jeszcze raz: ");
                }
            }

            using var cmd4 = new SQLiteCommand(con);
            cmd4.CommandText = $"INSERT INTO users(name, surname, pesel, birth, password, user_isLog) VALUES(@name,@surname,@pesel,@birth,@password,@user_isLog)"; //tutaj wskazuje teblice oraz miejsca w tej tablicy w ktore chce wpisac dane klienta (jak widac nie wpisuje liczby porzadkowej,poniewaz w ustawieniach bazy ona automatycznie sie zwieksza)
            cmd4.Parameters.AddWithValue("@name", name);
            cmd4.Parameters.AddWithValue("@surname", surname);
            cmd4.Parameters.AddWithValue("@pesel", pesel);
            cmd4.Parameters.AddWithValue("@birth", birth);
            cmd4.Parameters.AddWithValue("@password", password);
            cmd4.Parameters.AddWithValue("@user_isLog", false);
            cmd4.Prepare();
            cmd4.ExecuteNonQuery();
            
            Console.Clear();
            Frame.Rejestracja();
            Console.WriteLine("Klient " + name + " " + surname + " dodany");
            Funkcje_Pomocnicze.EmptySpaceDots(3);
            Funkcje_Pomocnicze.ClickToContinue();
            Menu.Menu_Glowne();
        }
    }
}
