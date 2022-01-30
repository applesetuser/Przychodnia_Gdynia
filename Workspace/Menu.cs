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
                        WyboryTekstowe.AKTUALNOSCI();
                        Funkcje_Pomocnicze.TimerDot(3);
                        Funkcje_Pomocnicze.ClickToContinue();
                        Menu.Menu_Glowne();
                        break;
                    case 3:
                        WyboryTekstowe.RODO();
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
        public static void Menu_userPanel()
        {
            Console.Clear();
            Frame.Panel_Uzytkownika();
            System.Console.WriteLine();
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
                    User_Panel.Recepty();
                    System.Console.WriteLine("Lista otrzymanych recept: ");
                    Funkcje_Pomocnicze.EmptySpaceDots(3);
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.Menu_userPanel();
                    break;

                case 1:
                    User_Panel.Lekarze();
                    System.Console.WriteLine("Lista lekarzy specjalistów:");
                    Funkcje_Pomocnicze.EmptySpaceDots(3);
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.Menu_Lekarze();
                    break;

                case 2:
                    User_Panel.Wizyty();
                    System.Console.WriteLine("Terminy wizyt: ");
                    Funkcje_Pomocnicze.EmptySpaceDots(3);
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.Menu_userPanel();
                    break;

                case 3:
                    //User_Panel.
                    System.Console.WriteLine("insane gameplay xd");
                    Funkcje_Pomocnicze.EmptySpaceDots(3);
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.Menu_userPanel();
                break;

                case 4:
                    Logowanie.WylogowanieUzytkownika();
                    Menu.Menu_Glowne();
                break;
            }
        }
        public static void Menu_Lekarze()
        {

            Console.Clear();
            //Frame.Lekarze();
            System.Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String[] opcje = {"---KARDIOLOG---", "---NEUROLOG---","---STOMATOLOG---", "---ANESTEZJOLOG---", "---POWRÓT---" };
            Menu_Config mainMenu = new Menu_Config(opcje);
            switch (mainMenu.Uruchom(opcje.Length))
            {
                case 0:
                    Menu_Wizyta("kardiolog");
                break;

                case 1:
                    Menu_Wizyta("neurolog");   
                break;

                case 2:
                    Menu_Wizyta("stomatolog");
                break;

                case 3:
                    Menu_Wizyta("anestezjolog");
                break;

                case 4:
                    Menu.Menu_userPanel();
                break;
            }        
        }
        public static void Menu_Wizyta(string temp)
        {
            Console.Clear();
            //Frame.Wizyta();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String[] opcje = {"---UMÓW SIĘ NA WIZYTĘ ZE SPECJALISTA---", "---POWRÓT---" };
            Menu_Config mainMenu = new Menu_Config(opcje);
            switch (mainMenu.Uruchom(opcje.Length))
            {
                case 0:
                    switch(temp)
                    {
                        case "kardiolog":
                        Menu.Menu_LekarzKardiolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        Menu.Menu_userPanel();
                        break;
                        
                        case "neurolog":
                        Menu.Menu_LekarzNeurolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        Menu.Menu_userPanel();
                        break;

                        case "stomatolog":
                        Menu.Menu_LekarzStomatolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        Menu.Menu_userPanel();
                        break;
                        
                        case "anestezjolog":
                        Menu_LekarzAnestezjolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        Menu.Menu_userPanel();
                        break;
                    }
                break;

                case 1:
                    Menu.Menu_Glowne();
                    break;
            }

        }
        public static void Menu_LekarzNeurolog()
        {
           System.Console.WriteLine("neurolog"); 
        }
        public static void Menu_LekarzStomatolog()
        {
            System.Console.WriteLine("stomatolog");
        }
        public static void Menu_LekarzAnestezjolog()
        {
            System.Console.WriteLine("ANESTEZJOLOG");
        }
        public static void Menu_LekarzKardiolog()
        {
            System.Console.WriteLine("kardiolog");
        }
    }
}
