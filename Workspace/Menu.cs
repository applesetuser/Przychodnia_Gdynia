using System;
using System.Threading;
using static System.Console;
using System.Data.SQLite;
using Przychodnia_Gdynia;

namespace Przychodnia_Gdynia
{
    class Menu
    {
        public static void Menu_Glowne()
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
                String[] opcje = { "---PANEL UŻYTKOWNIKA---","---REJESTRACJA---", "---AKTUALNOŚCI---", "---RODO---", "---WYJŚCIE---" };
                Menu_Config mainMenu = new Menu_Config(opcje);
                int opt = mainMenu.Uruchom(opcje.Length);
                switch (opt)
                {
                    case 0:
                        Menu.Menu_Logowanie();
                        break;
                    case 1:
                        Menu.Menu_Rejestracja();
                        break;
                    case 2:
                        Menu_Opcje.AKTUALNOSCI();
                        Funkcje_Pomocnicze.TimerDot(3);
                        Funkcje_Pomocnicze.ClickToContinue();
                        Menu.Menu_Glowne();
                        break;
                    case 3:
                        Menu_Opcje.RODO();
                        Funkcje_Pomocnicze.TimerDot(3);
                        Funkcje_Pomocnicze.ClickToContinue();
                        Menu.Menu_Glowne();
                        break;
                    case 4:
                        Frame.Wyjscie();
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        public static void Menu_Rejestracja()
        {
            Console.Clear();
            Frame.Rejestracja();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String[] opcje = {"---ZAREJESTRUJ SIĘ W SYSTEMIE---", "---POWRÓT---" };
            Menu_Config mainMenu = new Menu_Config(opcje);
            switch (mainMenu.Uruchom(opcje.Length))
            {
                case 0:
                    Frame.Rejestracja();
                    Rejestracja.DodawanieUzytkownika();
                    break;

                case 1:
                    Menu.Menu_Glowne();
                    break;
            }
        }
        public static void Menu_Logowanie()
        {
            Console.Clear();
            Frame.Panel_Uzytkownika();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String[] opcje = {"---ZALOGUJ SIĘ DO SYSTEMU---", "---POWRÓT---" };
            Menu_Config mainMenu = new Menu_Config(opcje);
            switch (mainMenu.Uruchom(opcje.Length))
            {
                case 0:
                    Frame.Logowanie();
                    Logowanie.LogowanieUzytkownika();
                    break;

                case 1:
                    Menu.Menu_Glowne();
                    break;
            }
        }
        public static void User_Panel()
        {
            Console.Clear();
            Frame.Panel_Uzytkownika();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String[] opcje = {"---RECEPTY---", "---LEKARZE---","---TERMINY WIZYT---", "---detka kys---", "---WYLOGUJ SIĘ---" };
            Menu_Config mainMenu = new Menu_Config(opcje);
            switch (mainMenu.Uruchom(opcje.Length))
            {
                case 0:
                    System.Console.WriteLine("RECEPTY DO HUJA");
                    Funkcje_Pomocnicze.EmptySpaceDots(3);
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.User_Panel();
                    break;

                case 1:
                    System.Console.WriteLine("LEKARZE CRING");
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.User_Panel();
                    break;

                case 2:
                    System.Console.WriteLine("WIZYTY DO HUJA");
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.User_Panel();
                    break;

                case 3:
                System.Console.WriteLine("dętka xd");
                Funkcje_Pomocnicze.ClickToContinue();
                Menu.User_Panel();
                break;

                case 4:
                //User_Panel.Wylogowanie();
                System.Console.WriteLine("naura");
                Funkcje_Pomocnicze.ClickToContinue();
                Menu.Menu_Glowne();
                break;
            }
        }
    }
}
