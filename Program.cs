using System;
using System.Threading;
using System.Windows.Input;
using System.Collections.Generic;
using System.Text;
using static System.Console;
//using System.Data.SQLite;

namespace Przychodnia_Gdynia
{   
    class Funkcje_Pomocnicze
    {  
        public static void TimerDot(int time) //Timer but in dots (number == dots number)
        {
        for(int i = time; time>0; time--)
        {
            Console.WriteLine(".");
            Thread.Sleep(1);
        }
        }
        public static void TimerNum(int time) //Timer counting numbers until 0
        {
        for(int i = time; time>0; time--)
        {
            Console.WriteLine(time);
            Thread.Sleep(1000);
        }
        }
        public static void ClickToContinue() //Basically click to continue
        {
        Console.WriteLine("Nacisnij przycisk aby kontynuowac...");
        Console.ReadKey();
        Console.Clear();
        }
        public static void EmptySpaceDots(int times)  //Vertical dots
        {
        for(int i = times; times>0; times--)
        Console.WriteLine(".");      
        }
        public static void EmptySpaceLine(int times)  //Horizontal lines
        {
        for(int i = times; times>0; times--)
        Console.Write("-");
        Console.WriteLine("");    
        }
        public static void EmptySpaceRoof(int times)  //Horizontal roof mark
        {
        for(int i = times; times>0; times--)
        Console.Write("^"); 
        }
        public static void EmptySpaceBlank(int times) //Blank spot vertical
        {
        for(int i = times; times>0; times--)
        Console.WriteLine("");      
        }
        public static void EmptySpaceBlankLine(int times) //w lini do prawo pusto
        {
        for(int i = times; times>0; times--)
        Console.Write(""); 
        }  
    
    }
    class Frame
    {
        public static void Przychodnia()
        {
            System.Console.WriteLine(@"██████╗ ██████╗ ███████╗██╗   ██╗ ██████╗██╗  ██╗ ██████╗ ██████╗ ███╗   ██╗██╗ █████╗ 
██╔══██╗██╔══██╗╚══███╔╝╚██╗ ██╔╝██╔════╝██║  ██║██╔═══██╗██╔══██╗████╗  ██║██║██╔══██╗
██████╔╝██████╔╝  ███╔╝  ╚████╔╝ ██║     ███████║██║   ██║██║  ██║██╔██╗ ██║██║███████║
██╔═══╝ ██╔══██╗ ███╔╝    ╚██╔╝  ██║     ██╔══██║██║   ██║██║  ██║██║╚██╗██║██║██╔══██║
██║     ██║  ██║███████╗   ██║   ╚██████╗██║  ██║╚██████╔╝██████╔╝██║ ╚████║██║██║  ██║
╚═╝     ╚═╝  ╚═╝╚══════╝   ╚═╝    ╚═════╝╚═╝  ╚═╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝╚═╝  ╚═╝
                                                                                       ");
        }
        public static void Panel_Uzytkownika()
        {
            System.Console.WriteLine(@"██████╗  █████╗ ███╗   ██╗███████╗██╗         ██╗   ██╗███████╗██╗   ██╗████████╗██╗  ██╗ ██████╗ ██╗    ██╗███╗   ██╗██╗██╗  ██╗ █████╗ 
██╔══██╗██╔══██╗████╗  ██║██╔════╝██║         ██║   ██║╚══███╔╝╚██╗ ██╔╝╚══██╔══╝██║ ██╔╝██╔═══██╗██║    ██║████╗  ██║██║██║ ██╔╝██╔══██╗
██████╔╝███████║██╔██╗ ██║█████╗  ██║         ██║   ██║  ███╔╝  ╚████╔╝    ██║   █████╔╝ ██║   ██║██║ █╗ ██║██╔██╗ ██║██║█████╔╝ ███████║
██╔═══╝ ██╔══██║██║╚██╗██║██╔══╝  ██║         ██║   ██║ ███╔╝    ╚██╔╝     ██║   ██╔═██╗ ██║   ██║██║███╗██║██║╚██╗██║██║██╔═██╗ ██╔══██║
██║     ██║  ██║██║ ╚████║███████╗███████╗    ╚██████╔╝███████╗   ██║      ██║   ██║  ██╗╚██████╔╝╚███╔███╔╝██║ ╚████║██║██║  ██╗██║  ██║
╚═╝     ╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝╚══════╝     ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝  ╚═╝ ╚═════╝  ╚══╝╚══╝ ╚═╝  ╚═══╝╚═╝╚═╝  ╚═╝╚═╝  ╚═╝");
        }
        public static void Aktualnosci()
        {
            Console.WriteLine(@" █████╗ ██╗  ██╗████████╗██╗   ██╗ █████╗ ██╗     ███╗   ██╗ ██████╗ ███████╗ ██████╗██╗
██╔══██╗██║ ██╔╝╚══██╔══╝██║   ██║██╔══██╗██║     ████╗  ██║██╔═══██╗██╔════╝██╔════╝██║
███████║█████╔╝    ██║   ██║   ██║███████║██║     ██╔██╗ ██║██║   ██║███████╗██║     ██║
██╔══██║██╔═██╗    ██║   ██║   ██║██╔══██║██║     ██║╚██╗██║██║   ██║╚════██║██║     ██║
██║  ██║██║  ██╗   ██║   ╚██████╔╝██║  ██║███████╗██║ ╚████║╚██████╔╝███████║╚██████╗██║
╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝ ╚═════╝╚═╝");
        }
        public static void Rodo()
        {
            Console.WriteLine(@"██████╗  ██████╗ ██████╗  ██████╗ 
██╔══██╗██╔═══██╗██╔══██╗██╔═══██╗
██████╔╝██║   ██║██║  ██║██║   ██║
██╔══██╗██║   ██║██║  ██║██║   ██║
██║  ██║╚██████╔╝██████╔╝╚██████╔╝
╚═╝  ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝ ");
        }
        public static void Wyjscie()
        {
            Console.WriteLine(@"██╗    ██╗██╗   ██╗   ██╗███████╗ ██████╗██╗███████╗
██║    ██║╚██╗ ██╔╝   ██║██╔════╝██╔════╝██║██╔════╝
██║ █╗ ██║ ╚████╔╝    ██║███████╗██║     ██║█████╗  
██║███╗██║  ╚██╔╝██   ██║╚════██║██║     ██║██╔══╝  
╚███╔███╔╝   ██║ ╚█████╔╝███████║╚██████╗██║███████╗
 ╚══╝╚══╝    ╚═╝  ╚════╝ ╚══════╝ ╚═════╝╚═╝╚══════╝");
        }
    }
    class Menu
    {
        public static void Glowne()
        {
            
            {
                Console.Clear();
                //Console.WriteLine("---PRZYCHODNIA GDYNIA---");
                Frame.Przychodnia();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                String[] opcje = { "---PANEL UŻYTKOWNIKA---", "---AKTUALNOŚCI---", "---REJESTRACJA/LOGOWANIE---", "---RODO---", "---WYJŚCIE---" };
                Menu_Config mainMenu = new Menu_Config(opcje);
                int opt = mainMenu.Uruchom(opcje.Length);
                switch (opt)
                {
                    case 0:
                    Menu_Opcje.USER_PANEL();
                    Funkcje_Pomocnicze.TimerDot(3);
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.Glowne();
                    break;
                    case 1:
                    Menu_Opcje.AKTUALNOSCI();
                    Funkcje_Pomocnicze.TimerDot(3);
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.Glowne();
                    break;
                    case 2:
                    //Rejestracja.Wybor();
                    break;
                    case 3:
                    Menu_Opcje.RODO();
                    Funkcje_Pomocnicze.TimerDot(3);
                    Funkcje_Pomocnicze.ClickToContinue();
                    Menu.Glowne();
                    break;
                    case 4:
                    Funkcje_Pomocnicze.TimerDot(3);
                    Console.WriteLine("Do zobaczenia!");
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
        public static void Wybor_LogRej()
        {

        }
        public static void Logowanie()
        {

        }
        public static void Rejestracja()
        {

        }
    
    }
        /*
        private void Info(string imie, string nazwisko, string email, string haslo, Boolean zalogowany, Boolean zarejestrowany)  
        {
            
            this.Nazwisko = nazwisko;
            this.Email = email;
            this.Haslo = haslo;
            this.Zalogowany = zalogowany;
            this.Zarejestrowany = zarejestrowany;
        }
        */
    class Dodawanie_Uzytkownika
    {

    }
    class Program
    {   
        /*
        public static Uzytkownik User;
        public static string imie;
        public static string nazwisko;
        public static string email;
        public static string haslo;
        public static Boolean zalogowany;
        public static Boolean zarejestrowany;
        */
        static void Main(string[] args)
        {
                                //««««DEBUG««««//
                            //–––––––––––––//

            //Uzytkownik Franek = new Uzytkownik("Mata", "Matczak", "mata@email.com", "MC", true, true);

            //WriteLine("Franek Imie = {0} Nazwisko = {1} Email = {3} Haslo = {4}", Franek.GetImie, Franek.GetNazwisko, Franek.GetEmail, Franek.GetHaslo);               
            //Menu.Glowne();
            //Menu_Opcje.AKTUALNOSCI();
            //Menu_Opcje.USER_PANEL();
            Frame.Przychodnia();
            Frame.Aktualnosci();
        }
    }
}
