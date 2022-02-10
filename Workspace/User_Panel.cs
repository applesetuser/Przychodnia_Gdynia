using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Przychodnia_Gdynia
{
    class User_Panel
    {
        public static void Recepty()
        {
            //lista recept otrzymanych
            Console.Clear();
            Frame.Recepty();

            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd3 = new SQLiteCommand($"SELECT pesel FROM users WHERE user_isLog = true", con);

            object pesel_zalogowanego = cmd3.ExecuteScalar();
            string pesel = pesel_zalogowanego.ToString();
            System.Console.WriteLine();
            System.Console.WriteLine("Lista otrzymanych recept dla użytkownika o numerze PESEL "+pesel+":");
            System.Console.WriteLine("");
            using var cmd4 = new SQLiteCommand($"SELECT lekarz, tresc FROM Recepty WHERE pesel = '{pesel}'", con);
            using (SQLiteDataReader reader = cmd4.ExecuteReader())
            {
                while(reader.Read())
                {
                    System.Console.Write(reader["lekarz"]+ " - "); 
                    System.Console.Write("\""+reader["tresc"]+"\"");
                    System.Console.WriteLine();
                }
            }
            

            
            //cmd4.ExecuteReader();

            Funkcje_Pomocnicze.Kontynuacja();

        }
        public static void Wizyty()
        {
            //lista umowionych wizyt
            Console.Clear();
            Frame.Wizyty();
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd3 = new SQLiteCommand($"SELECT pesel FROM users WHERE user_isLog = true", con);

            object pesel_zalogowanego = cmd3.ExecuteScalar();
            string pesel = pesel_zalogowanego.ToString();
            System.Console.WriteLine();
            System.Console.WriteLine("Lista wizyt dla użytkownika o numerze PESEL "+pesel+":");
            System.Console.WriteLine("");
            using var cmd4 = new SQLiteCommand($"SELECT Data_wizyty, Godzina_wizyty, Lekarz_wizytowany FROM Wizyta WHERE Pesel_wizytującego = '{pesel}'", con);
            using (SQLiteDataReader reader = cmd4.ExecuteReader())
            {
                while(reader.Read())
                {
                    System.Console.Write(reader["Data_wizyty"]+", ");
                    System.Console.Write(reader["Godzina_wizyty"]+ ":00");
                    System.Console.Write(" - "+reader["Lekarz_wizytowany"]);
                    System.Console.WriteLine();
                }
            }
            Funkcje_Pomocnicze.Kontynuacja();
        }
        public static void Lekarze()
        {
            //a tutaj odwolanie do klasy wywolujacej menu wyboru czy chcemy sie umowic na wizyte/recepte
            //System.Console.WriteLine("Lista lekarzy specjalistów: ");

            Menu.Menu_Lekarze();
        }
        public static void Dane_Wyswietlanie()
        {
            string cs = "Data Source=./uzytkownicy.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd3 = new SQLiteCommand($"SELECT pesel, name, surname, birth FROM users WHERE user_isLog = true", con);
            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();

            using var cmd4 = new SQLiteCommand($"SELECT pesel, name, surname, birth FROM users WHERE pesel = '{pesel}'", con);
            using (SQLiteDataReader reader = cmd4.ExecuteReader())
            {
                while(reader.Read())
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Dane zalogowanego użytkownika: ");
                    System.Console.Write("IMIĘ I NAZWISKO: "+reader["name"]+" ");
                    System.Console.Write(reader["surname"]+",");
                    System.Console.Write(" NR PESEL: "+reader["pesel"]+","); 
                    System.Console.Write(" DATA URODZENIA: "+reader["birth"]+"r.");
                }
            }
        }
    }
}