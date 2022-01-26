using System;
using System.Threading;
using static System.Console;
using System.Data.SQLite;
using System.Collections.Generic;


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
        public static bool DateCheck(string date)
        {
            string today = System.DateTime.Now.ToString("yyyy.MM.dd");

            List<string> now = new List<string>(today.Split('.'));
            int thisDay = int.Parse(now[2]);
            int thisMonth = int.Parse(now[1]);
            int thisYear = int.Parse(now[0]);

            List<string> data = new List<string>(date.Split('.'));
            int day;
            int month;
            int year;

            if (data.Count == 3)
            {

                int.TryParse(data[0], out day);
                int.TryParse(data[1], out month);
                int.TryParse(data[2], out year);
            }
            else
                return false;

            if (day > 0 && day <= 31 && month > 0 && month <= 12 && year > 1900 && year < 3000 && thisDay + thisMonth * 10 + thisYear * 1000 > day + month * 10 + year * 1000)
                return true;
            else
                return false;

        }
        public static bool PeselCheck(string pesel)
        {
            int number = pesel.Length;
            if(number == 11) return true;
            else return false;
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
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();
            Console.Write("Podaj imie potrzebne do rejestracji: ");
            string name = ReadLine();
            Console.Write("Podaj nazwisko potrzebne do rejestracji: ");
            string surname = ReadLine();
            Console.Write("Podaj pesel potrzebny do rejestracji: ");
            string pesel;
            while (true)
            {
                pesel = Console.ReadLine();
                if (Funkcje_Pomocnicze.PeselCheck(pesel) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Pesel musi składać się z 11 liczb");
                    Console.Write("Podaj numer Pesel jeszcze raz: ");
                }
            }
            Console.Write("Podaj haslo potrzebne do rejestracji: ");
            string password = ReadLine();
            

            
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
            Console.WriteLine("Klient " + name + " " + surname +" dodany");
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
        public static void Wyswietlanie()
        {
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();
            string users = "SELECT * FROM users WHERE name = 'kmbfdb'";
            using var cmd2 = new SQLiteCommand(users, con);
            using SQLiteDataReader reader2 = cmd2.ExecuteReader();
            Console.WriteLine();
            while (reader2.Read())
            {

                if($"{reader2.GetString(6)}" == "0") Console.WriteLine("kmbfdb"); 

            }
            Console.WriteLine();
        } 
        static void Main(string[] args)
        {
                //««««DEBUG««««//
                //–––––––––––––//
                Menu.Glowne();
            
            //Menu.Rejestracja();
            //Program.Wyswietlanie();
            


            
        }
    }
}
