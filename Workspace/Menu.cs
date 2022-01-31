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
            String[] opcje = {"---RECEPTY---", "---TERMINY WIZYT---","---LEKARZE---", "---WYLOGUJ SIĘ---" };
            Menu_Config mainMenu = new Menu_Config(opcje);
            switch (mainMenu.Uruchom(opcje.Length))
            {
                case 0:
                    User_Panel.Recepty();
                    Menu.Menu_userPanel();
                break;

                case 1:
                    User_Panel.Wizyty();
                    Menu.Menu_userPanel();
                break;

                case 2:
                    
                    User_Panel.Lekarze();
                break;

                case 3:
                    Logowanie.WylogowanieUzytkownika();
                    Menu.Menu_Glowne();
                break;
            }
        }
        public static void Menu_Lekarze()
        {

            Console.Clear();
            Frame.ListaLekarzy();
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
                Clear();
                    Frame.Kardiolog();
                    Menu_Wizyta("kardiolog");
                break;

                case 1:
                Clear();
                    Frame.Neurolog();
                    Menu_Wizyta("neurolog");   
                break;

                case 2:
                Clear();
                    Frame.Stomatolog();
                    Menu_Wizyta("stomatolog");
                break;

                case 3:
                Clear();
                    Frame.Anestezjolog();
                    Menu_Wizyta("anestezjolog");
                break;

                case 4:
                    Menu.Menu_userPanel();
                break;
            }        
        }
        public static void Menu_Wizyta(string temp)
        {
            //Console.Clear();
            //Frame.Wizyty();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String[] opcje = {"---UMÓW SIĘ NA WIZYTĘ ZE SPECJALISTA---", "---USUŃ WIZYTĘ ZE SPECJALISTA", "---POWRÓT---" };
            Menu_Config mainMenu = new Menu_Config(opcje);
            switch (mainMenu.Uruchom(opcje.Length))
            {
                case 0:
                    //string temp2 = "wizyta";
                    //zeby zrobic kolejna opcje wyboru dodajesz stringa wyzej w opcjach i dodajesz opcje do pierwszego switha
                    
                    switch(temp)
                    {
                        //zeby zrobic dodawanie recept i wizyt osobno skopiowac menu_lekarzx + wizyta/recepta i tam bedzie otwierac baze danych i rekord potrzebny
                        case "kardiolog":
                        Clear();
                        Frame.Kardiolog();
                        Menu.Menu_WizytaKardiolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        //Menu.Menu_userPanel();
                        break;
                        
                        case "neurolog":
                        Clear();
                        Frame.Neurolog();
                        Menu.Menu_WizytaNeurolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        //Menu.Menu_userPanel();
                        break;

                        case "stomatolog":
                        Clear();
                        Frame.Stomatolog();
                        Menu.Menu_WizytaStomatolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        //Menu.Menu_userPanel();
                        break;
                        
                        case "anestezjolog":
                        Clear();
                        Frame.Anestezjolog();
                        Menu.Menu_WizytaAnestezjolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        //Menu.Menu_userPanel();
                        break;
                    }
                    Menu.Menu_userPanel();
                break;

                case 1:
                //temp2 = "recepta";
                switch(temp)
                    {
                        case "kardiolog":
                        Menu.Menu_UsunWizytaKardiolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        //Menu.Menu_userPanel();
                        break;
                        
                        case "neurolog":
                        Menu.Menu_UsunWizytaNeurolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        //Menu.Menu_userPanel();
                        break;

                        case "stomatolog":
                        Menu.Menu_UsunWizytaStomatolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        //Menu.Menu_userPanel();
                        break;
                        
                        case "anestezjolog":
                        Menu.Menu_UsunWizytaAnestezjolog();
                        Funkcje_Pomocnicze.Kontynuacja();
                        //Menu.Menu_userPanel();
                        break;
                    }
                    Menu.Menu_userPanel();
                break;

                case 2:
                    Menu.Menu_Lekarze();
                break;
            }

        }
        public static void Menu_WizytaNeurolog()
        {
           System.Console.WriteLine("wizyta neurolog"); 
        }
        public static void Menu_WizytaStomatolog()
        {
            System.Console.WriteLine("wizyta stomatolog");
        }
        public static void Menu_WizytaAnestezjolog()
        {
            System.Console.WriteLine("wizyta anestezjolog");
        }
        public static void Menu_WizytaKardiolog()
        {
            System.Console.WriteLine("wizyta kardiolog");
        }
        public static void Menu_UsunWizytaNeurolog()
        {
           System.Console.WriteLine("wizyta neurolog"); 
        }
        public static void Menu_UsunWizytaStomatolog()
        {
            System.Console.WriteLine("usun wizyta stomatolog");
        }
        public static void Menu_UsunWizytaAnestezjolog()
        {
            System.Console.WriteLine("usun wizyta anestezjolog");
        }
        public static void Menu_UsunWizytaKardiolog()
        {
            System.Console.WriteLine("usun wizyta kardiolog");
        }
    }
}
