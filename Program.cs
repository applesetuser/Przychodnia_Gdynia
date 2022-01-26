using System;
using System.Threading;
using System.Windows.Input;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Data.SQLite;


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
            Funkcje_Pomocnicze.TimerDot(3);
        }
        public static void Wyjscie()
        {
            Console.Clear();
            Funkcje_Pomocnicze.TimerDot(3);
            Console.WriteLine(@"██████╗  ██████╗     ███████╗ ██████╗ ██████╗  █████╗  ██████╗███████╗███████╗███╗   ██╗██╗ █████╗ ██╗
██╔══██╗██╔═══██╗    ╚══███╔╝██╔═══██╗██╔══██╗██╔══██╗██╔════╝╚══███╔╝██╔════╝████╗  ██║██║██╔══██╗██║
██║  ██║██║   ██║      ███╔╝ ██║   ██║██████╔╝███████║██║       ███╔╝ █████╗  ██╔██╗ ██║██║███████║██║
██║  ██║██║   ██║     ███╔╝  ██║   ██║██╔══██╗██╔══██║██║      ███╔╝  ██╔══╝  ██║╚██╗██║██║██╔══██║╚═╝
██████╔╝╚██████╔╝    ███████╗╚██████╔╝██████╔╝██║  ██║╚██████╗███████╗███████╗██║ ╚████║██║██║  ██║██╗
╚═════╝  ╚═════╝     ╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚══════╝╚══════╝╚═╝  ╚═══╝╚═╝╚═╝  ╚═╝╚═╝
                                                                                                      ");
        }
        public static void LogRej()
        {
            Console.Clear();
            Console.WriteLine(@"██╗      ██████╗  ██████╗  ██████╗ ██╗    ██╗ █████╗ ███╗   ██╗██╗███████╗    ██╗██████╗ ███████╗     ██╗███████╗███████╗████████╗██████╗  █████╗  ██████╗     ██╗ █████╗ 
██║     ██╔═══██╗██╔════╝ ██╔═══██╗██║    ██║██╔══██╗████╗  ██║██║██╔════╝   ██╔╝██╔══██╗██╔════╝     ██║██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔════╝     ██║██╔══██╗
██║     ██║   ██║██║  ███╗██║   ██║██║ █╗ ██║███████║██╔██╗ ██║██║█████╗    ██╔╝ ██████╔╝█████╗       ██║█████╗  ███████╗   ██║   ██████╔╝███████║██║          ██║███████║
██║     ██║   ██║██║   ██║██║   ██║██║███╗██║██╔══██║██║╚██╗██║██║██╔══╝   ██╔╝  ██╔══██╗██╔══╝  ██   ██║██╔══╝  ╚════██║   ██║   ██╔══██╗██╔══██║██║     ██   ██║██╔══██║
███████╗╚██████╔╝╚██████╔╝╚██████╔╝╚███╔███╔╝██║  ██║██║ ╚████║██║███████╗██╔╝   ██║  ██║███████╗╚█████╔╝███████╗███████║   ██║   ██║  ██║██║  ██║╚██████╗╚█████╔╝██║  ██║
╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝╚═╝    ╚═╝  ╚═╝╚══════╝ ╚════╝ ╚══════╝╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚════╝ ╚═╝  ╚═╝");
        }
        public static void Logowanie()
        {
            Console.Clear();
            Console.WriteLine(@"██╗      ██████╗  ██████╗  ██████╗ ██╗    ██╗ █████╗ ███╗   ██╗██╗███████╗
██║     ██╔═══██╗██╔════╝ ██╔═══██╗██║    ██║██╔══██╗████╗  ██║██║██╔════╝
██║     ██║   ██║██║  ███╗██║   ██║██║ █╗ ██║███████║██╔██╗ ██║██║█████╗  
██║     ██║   ██║██║   ██║██║   ██║██║███╗██║██╔══██║██║╚██╗██║██║██╔══╝  
███████╗╚██████╔╝╚██████╔╝╚██████╔╝╚███╔███╔╝██║  ██║██║ ╚████║██║███████╗
╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝");
        }    
        public static void Rejestracja()
        {
            Console.Clear();
            Console.WriteLine(@"██████╗ ███████╗     ██╗███████╗███████╗████████╗██████╗  █████╗  ██████╗     ██╗ █████╗ 
██╔══██╗██╔════╝     ██║██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔════╝     ██║██╔══██╗
██████╔╝█████╗       ██║█████╗  ███████╗   ██║   ██████╔╝███████║██║          ██║███████║
██╔══██╗██╔══╝  ██   ██║██╔══╝  ╚════██║   ██║   ██╔══██╗██╔══██║██║     ██   ██║██╔══██║
██║  ██║███████╗╚█████╔╝███████╗███████║   ██║   ██║  ██║██║  ██║╚██████╗╚█████╔╝██║  ██║
╚═╝  ╚═╝╚══════╝ ╚════╝ ╚══════╝╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚════╝ ╚═╝  ╚═╝");
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
                DateTime thisDay = DateTime.Now;
                // Display the date in the default (general) format.
                Console.WriteLine("                          " + thisDay.ToString());
                Console.WriteLine();
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
                    //do zrobienia - user panel widoczny jedynie w momencie gdy uzytkownik jest zalogowany.
                    //inaczej komunikat ze najpierw musi sie zalogowac
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
                    Menu.Wybor_LogRej();
                    break;
                    case 3:
                    Menu_Opcje.RODO();
                    Funkcje_Pomocnicze.TimerDot(3);
                    Funkcje_Pomocnicze.ClickToContinue();
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
            int opt = mainMenu.Uruchom(opcje.Length);
            switch (opt)
            {
                case 0:
                Frame.Logowanie();
                Menu.Logowanie();
                break;

                case 1:
                Frame.Rejestracja();
                Menu.Rejestracja();
                break;

                case 2:
                Menu.Glowne();
                break;
            }
        }
        public static void Logowanie()
        {
           
        }
        public static void Rejestracja()
        {

        }
    
    }
    class Menu_Opcje
    {
        public static void USER_PANEL()
        {
            Uzytkownik Franek = new Uzytkownik(false, true);
            Console.Clear();
            Frame.Panel_Uzytkownika();
            if(Franek.GetZalogowany() == true) Console.WriteLine("Status Uzytkownika: zalogowany");
            else WriteLine("Status Uzytkownika: niezalogowany");
        }
        public static void AKTUALNOSCI()
        {
            Console.Clear();
            Frame.Aktualnosci();
        }
        public static void RODO()
        {
            Console.Clear();
            Frame.Rodo();
            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.WriteLine("OCHRONA DANYCH OSOBOWYCH");
            Console.WriteLine();
            Console.WriteLine("1. Administratorem danych osobowych jest Przychodnia w Gdyni Sp. z o.o. 81-000   Gdynia ul. Gdyńska 1x.");
            Console.WriteLine();
            Console.WriteLine("2. Celem przetwarzania danych jest świadczenie przez Administratora usług medycznych.");
            Console.WriteLine();
            Console.WriteLine("3. Podstawą prawną przetwarzania jest art. 6 ust.1 lit. c) oraz art. 9 ust. 2 lit.h) RODO oraz przepisy polskich ustaw z obszaru prawa medycznego, pozostających w związku z celami zdrowotnymi przetwarzania, w szczególności ustawa o prawach pacjenta i Rzeczniku Praw pacjenta.");
            Console.WriteLine();
            Console.WriteLine("4. Administrator przekazuje dane osobowe pacjentów wyłącznie podmiotom uprawnionym na podstawie przepisów prawa lub podmiotów, z którymi zawarł umowę powierzenia przetwarzania danych osobowych.");
            Console.WriteLine();
            Console.WriteLine("5. Dokumentacja medyczna przechowywana jest przez okres 20 lat, licząc do końca roku kalendarzowego, w którym dokonano ostatniego wpisu , z wyjątkiem:");
            Console.WriteLine();
            Console.WriteLine("a) dokumentacji medycznej w przypadku zgonu pacjenta na skutek uszkodzenia ciała lub zatrucia, która jest przechowywana przez okres 30 lat, licząc od końca roku kalendarzowego, w którym nastąpił zgon;");
            Console.WriteLine();
            Console.WriteLine("b) dokumentacji medycznej zawierającej dane niezbędne do monitorowania losów krwi i jej składników, która jest przechowywana przez okres 30lat, licząc do końca roku kalendarzowego, w którym dokonano ostatniego wpis;");
            Console.WriteLine();
            Console.WriteLine("c) zdjęć rentgenowskich przechowywanych poza dokumentacją medyczną pacjenta,które są przechowywane przez okres 10 lat, licząc do końca roku kalendarzowego, w którym wykonano zdjęcie;");
            Console.WriteLine();
            Console.WriteLine("d) skierowań na badania lub zleceń lekarza, które są przechowywane przez okres:");
            Console.WriteLine();
            Console.WriteLine("    - 5 lat, licząc od końca roku kalendarzowego, w którym udzielono świadczenia zdrowotnego będącego przedmiotem skierowania lub zlecenia lekarza,");
            Console.WriteLine();
            Console.WriteLine("    - 2 lat, licząc od końca roku kalendarzowego, w którym wystawiono skierowanie - w przypadku gdy świadczenie zdrowotne nie zostało udzielone z powodu niezgłoszenia się pacjenta w ustalonym terminie, chyba że pacjent odebrał skierowanie;");
            Console.WriteLine();
            Console.WriteLine("    - dokumentacji medycznej dotyczącej dzieci do ukończenia 2 roku życia, która jest przechowywana przez okres 22 lat.");
            Console.WriteLine();
            Console.WriteLine("6. Osobie, której dane dotyczą przysługuje prawo dostępu do danych, ich sprostowania i uzupełnienia.");
            Console.WriteLine();
            Console.WriteLine("a. prawo dostępu do danych ( art. 15 RODO )");
            Console.WriteLine();
            Console.WriteLine("b. prawo do sprostowania i uzupełniania danych osobowych ( art. 16 RODO )");
            Console.WriteLine();
            Console.WriteLine("c. prawo do usunięcia danych ( art. 17 RODO )");
            Console.WriteLine();
            Console.WriteLine("d. prawo do żądania ograniczenia przetwarzania danych ( art. 18 RODO )");
            Console.WriteLine();
            Console.WriteLine("e. prawo do przenoszenia danych ( art. 20 RODO )");
            Console.WriteLine();
            Console.WriteLine("f. prawo do sprzeciwu wobec przetwarzania danych ( art. 21 RODO ).");
            Console.WriteLine();
            Console.WriteLine("Część uprawnień nie znajduje zastosowania w stosunku do danych osobowych przetwarzanych na podstawie art. 9 ust. 2 lit h) RODO, w tym w szczególności wobec danych przetwarzanych w ramach dokumentacji medycznej i innych przetwarzanych w oparciu o ww. przesłankę.");
            Console.WriteLine();
            Console.WriteLine("7. Osobie, której dane dotyczą ma prawo wniesienia skargi do organu nadzorczego właściwego dla ochrony danych osobowych.");
            Console.WriteLine();
            Console.WriteLine("8. podanie danych osobowych w rejestracji online jest dobrowolne, zaś osoba, której dane dotyczą może odmówić ich podania. Niepodanie danych będzie skutkować brakiem możliwości umówienia się na wizytę oraz konieczność skontaktowania się z Administratorem celem skutecznego umówienia wizyty i skorzystania ze świadczeń opieki zdrowotnej.");
            Console.WriteLine();

        }
    }
    class Program
    {   
        

        
        
        static void Main(string[] args)
        {
                //««««DEBUG««««//
                //–––––––––––––//
                //Menu.Glowne();
            //string stm = "SELECT * FROM users";
            string cs = "Data Source=./uzytkownicy.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM users";

            using var cmd3 = new SQLiteCommand(stm, con);               //odwolanie sie okreslonej tablicy (w tym przypadku zmiennej "client" ktora jest zdefiniowana na poczatku)
            using SQLiteDataReader reader = cmd3.ExecuteReader();    
           
            while (reader.Read())
            {

                Console.WriteLine($"{reader.GetInt32(0)+ "."} {reader.GetString(2)}");  //getint(0) getstring(1) jak pisalem wczesniej tu trzeba okreslic typ zwrazanych dannych oraz indek okresla co to sa za dane(np 0 to indeks, 1 to nazwa)

            }
            Console.Write(": ");
            
            
            
            
            
            


            
        }
    }
}
