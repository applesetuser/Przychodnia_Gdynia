using System;
using System.Threading;
using static System.Console;
using System.Data.SQLite;
using Przychodnia_Gdynia.Registration;

namespace Przychodnia_Gdynia
{
    class Menu
    {
        public static void Glowne()
        {
            
            {
                Console.Clear();
                //Console.WriteLine("---PRZYCHODNIA GDYNIA---");
                Frame.Przychodnia();
                DateTime thisDay = DateTime.Now;
                // Display the date in the default (general) format.
                Console.WriteLine("                          " + thisDay.ToString());
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                String[] opcje = { "---PANEL UŻYTKOWNIKA---","---REJESTRACJA/LOGOWANIE---", "---AKTUALNOŚCI---", "---RODO---", "---WYJŚCIE---" };
                Menu_Config mainMenu = new Menu_Config(opcje);
                int opt = mainMenu.Uruchom(opcje.Length);
                switch (opt)
                {
                    case 0:
                    //do zrobienia - user panel widoczny jedynie w momencie gdy uzytkownik jest zalogowany.
                    //inaczej komunikat ze najpierw musi sie zalogowac
                        Menu_Opcje.USER_PANEL();
                        AdditionalFunctions.TimerDot(3);
                        AdditionalFunctions.ClickToContinue();
                        Menu.Glowne();
                        break;
                    case 1:
                        Menu.Wybor_LogRej();
                        break;
                    case 2:
                        Menu_Opcje.AKTUALNOSCI();
                        AdditionalFunctions.TimerDot(3);
                        AdditionalFunctions.ClickToContinue();
                        Menu.Glowne();
                        break;
                    case 3:
                        Menu_Opcje.RODO();
                        AdditionalFunctions.TimerDot(3);
                        AdditionalFunctions.ClickToContinue();
                        Menu.Glowne();
                        break;
                    case 4:
                        Frame.Wyjscie();
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        public static void Wybor_LogRej()
        {
            Console.Clear();
            Frame.LogRej();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String[] opcje = { "---LOGOWANIE---", "---REJESTRACJA---", "---POWRÓT---" };
            Menu_Config mainMenu = new Menu_Config(opcje);
            switch (mainMenu.Uruchom(opcje.Length))
            {
                case 0:
                    Frame.Logowanie();
                    Menu.Logowanie();
                break;

                case 1:
                    Frame.Rejestracja();
                    RegistrationService.Register();
                    break;

                case 2:
                    Menu.Glowne();
                    break;
            }
        }
        public static void Logowanie()
        {
           
        }
        /*public static void Register()
        {
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();
            Console.Write("Podaj Imie: ");
            string name = Console.ReadLine();
            Console.Write("Podaj Nazwisko: ");
            string surname = ReadLine();
            Console.Write("Podaj NR PESEL: ");
            string pesel;
            while (true)
            {
                pesel = Console.ReadLine();
                if (AdditionalFunctions.PeselCheck(pesel) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Niepoprawny numer PESEL");
                    Console.WriteLine("PESEL musi składać się z 11 liczb");
                    Console.Write("Podaj NR PESEL: ");
                }
            }
            Console.Write("Podaj Hasło: ");
            string password = ReadLine();
            Console.Write("Powtórz Hasło:");
            string password2 = ReadLine();



            Console.Write("Podaj date urodzenia w formacie [dd.mm.rrrr]: ");
            string birth;
            while (true)
            {
                string input = Console.ReadLine();
                if (AdditionalFunctions.DateCheck(input) == true)
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
            cmd4.CommandText = "INSERT INTO users(name, surname, pesel, birth, password, user_isLog) VALUES(@name,@surname,@pesel,@birth,@password,@user_isLog)"; //tutaj wskazuje teblice oraz miejsca w tej tablicy w ktore chce wpisac dane klienta (jak widac nie wpisuje liczby porzadkowej,poniewaz w ustawieniach bazy ona automatycznie sie zwieksza)
            cmd4.Parameters.AddWithValue("@name", name);
            cmd4.Parameters.AddWithValue("@surname", surname);
            cmd4.Parameters.AddWithValue("@pesel", pesel);
            cmd4.Parameters.AddWithValue("@birth", birth);
            cmd4.Parameters.AddWithValue("@password", password);
            cmd4.Parameters.AddWithValue("@user_isLog", true);
            cmd4.Prepare();
            cmd4.ExecuteNonQuery();
            Console.Clear();
            Console.WriteLine("Klient " + name + " " + surname + " dodany");
        }
        */


    }
}
