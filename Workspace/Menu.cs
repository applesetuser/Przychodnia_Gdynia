using System;
using System.Threading;
using static System.Console;
using System.Data.SQLite;
using Przychodnia_Gdynia;

namespace Przychodnia_Gdynia
{
    class Menu
    {
        //public static string pesel = "temp";
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
                        System.Environment.Exit(0);
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
            User_Panel.Dane_Wyswietlanie();
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
            //System.Console.WriteLine("wizyta neurolog"); 
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd3 = new SQLiteCommand($"SELECT pesel FROM users WHERE user_isLog = true", con);

            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();

            //string pesel_wizytujacego = pesel;
            //cmd3.ExecuteScalar();
            System.Console.WriteLine();
            Console.Write("Podaj datę wizyty w formacie [dd.mm.rrrr]: ");
            string Data;
            while (true)
            {
                string input = Console.ReadLine();
                if (Funkcje_Pomocnicze.Wizyta_DateCheck(input) == true)
                {
                    Data = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Podana data jest nieprawidlowa.");
                    Console.Write("Podaj datę jeszcze raz: ");
                }
            }
            Console.Clear();
            Frame.Neurolog();
            System.Console.WriteLine();
            System.Console.WriteLine("Przychodnia przyjmuje wizyty o pełnych godzinach, w porach od 10:00-16:00");
            System.Console.WriteLine("Podaj godzinę wizyty: ");
            int czas;
            int godzina;
            //czas = int.Parse(Console.ReadLine());
            while(true)
            {
                czas = int.Parse(Console.ReadLine());
                if(Funkcje_Pomocnicze.Wizyta_GodzinaCheck(czas) == true)
                {
                    godzina = czas;
                    break;
                }
                else
                {
                Console.WriteLine("Przychodnia przyjmuje wizyty o pełnych godzinach, w porach od 10:00-16:00");
                System.Console.Write("Podaj godzinę w formacie {godzina}:00.");
                Console.Write(" Godzina: ");
                }
            }
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = $"INSERT INTO Wizyta(Data_wizyty, Godzina_wizyty, Lekarz_wizytowany, Pesel_wizytującego) VALUES(@Data_wizyty, @Godzina_wizyty, 'Neurolog', @Pesel_wizytującego)";
            cmd.Parameters.AddWithValue("@Data_wizyty", Data);
            cmd.Parameters.AddWithValue("@Pesel_wizytującego", pesel);
            cmd.Parameters.AddWithValue("@Godzina_wizyty", czas);
            System.Console.WriteLine();
            System.Console.WriteLine("Wizyta została dodana pomyślnie.");
            //Funkcje_Pomocnicze.Kontynuacja();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        public static void Menu_WizytaStomatolog()
        {
            //System.Console.WriteLine("wizyta neurolog"); 
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd3 = new SQLiteCommand($"SELECT pesel FROM users WHERE user_isLog = true", con);

            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();

            //string pesel_wizytujacego = pesel;
            //cmd3.ExecuteScalar();
            System.Console.WriteLine();
            Console.Write("Podaj datę wizyty w formacie [dd.mm.rrrr]: ");
            string Data;
            while (true)
            {
                string input = Console.ReadLine();
                if (Funkcje_Pomocnicze.Wizyta_DateCheck(input) == true)
                {
                    Data = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Podana data jest nieprawidlowa.");
                    Console.Write("Podaj datę jeszcze raz: ");
                }
            }
            Console.Clear();
            Frame.Neurolog();
            System.Console.WriteLine();
            System.Console.WriteLine("Przychodnia przyjmuje wizyty o pełnych godzinach, w porach od 10:00-16:00");
            System.Console.WriteLine("Podaj godzinę wizyty: ");
            int czas;
            int godzina;
            //czas = int.Parse(Console.ReadLine());
            while(true)
            {
                czas = int.Parse(Console.ReadLine());
                if(Funkcje_Pomocnicze.Wizyta_GodzinaCheck(czas) == true)
                {
                    godzina = czas;
                    break;
                }
                else
                {
                Console.WriteLine("Przychodnia przyjmuje wizyty o pełnych godzinach, w porach od 10:00-16:00");
                System.Console.WriteLine("Podaj godzinę w formacie {godzina}:00.");
                Console.Write(" Godzina: ");
                }
            }
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = $"INSERT INTO Wizyta(Data_wizyty, Godzina_wizyty, Lekarz_wizytowany, Pesel_wizytującego) VALUES(@Data_wizyty, @Godzina_wizyty, 'Stomatolog', @Pesel_wizytującego)";
            cmd.Parameters.AddWithValue("@Data_wizyty", Data);
            cmd.Parameters.AddWithValue("@Pesel_wizytującego", pesel);
            cmd.Parameters.AddWithValue("@Godzina_wizyty", czas);
            System.Console.WriteLine();
            System.Console.WriteLine("Wizyta została dodana pomyślnie.");
            //Funkcje_Pomocnicze.Kontynuacja();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        public static void Menu_WizytaAnestezjolog()
        {
            //System.Console.WriteLine("wizyta neurolog"); 
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd3 = new SQLiteCommand($"SELECT pesel FROM users WHERE user_isLog = true", con);

            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();

            //string pesel_wizytujacego = pesel;
            //cmd3.ExecuteScalar();
            System.Console.WriteLine();
            Console.Write("Podaj datę wizyty w formacie [dd.mm.rrrr]: ");
            string Data;
            while (true)
            {
                string input = Console.ReadLine();
                if (Funkcje_Pomocnicze.Wizyta_DateCheck(input) == true)
                {
                    Data = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Podana data jest nieprawidlowa.");
                    Console.Write("Podaj datę jeszcze raz: ");
                }
            }
            Console.Clear();
            Frame.Neurolog();
            System.Console.WriteLine();
            System.Console.WriteLine("Przychodnia przyjmuje wizyty o pełnych godzinach, w porach od 10:00-16:00");
            System.Console.WriteLine("Podaj godzinę wizyty: ");
            int czas;
            int godzina;
            //czas = int.Parse(Console.ReadLine());
            while(true)
            {
                czas = int.Parse(Console.ReadLine());
                if(Funkcje_Pomocnicze.Wizyta_GodzinaCheck(czas) == true)
                {
                    godzina = czas;
                    break;
                }
                else
                {
                Console.WriteLine("Przychodnia przyjmuje wizyty o pełnych godzinach, w porach od 10:00-16:00");
                System.Console.WriteLine("Podaj godzinę w formacie {godzina}:00.");
                Console.Write(" Godzina: ");
                }
            }
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = $"INSERT INTO Wizyta(Data_wizyty, Godzina_wizyty, Lekarz_wizytowany, Pesel_wizytującego) VALUES(@Data_wizyty, @Godzina_wizyty, 'Anestezjolog', @Pesel_wizytującego)";
            cmd.Parameters.AddWithValue("@Data_wizyty", Data);
            cmd.Parameters.AddWithValue("@Pesel_wizytującego", pesel);
            cmd.Parameters.AddWithValue("@Godzina_wizyty", czas);
            System.Console.WriteLine();
            System.Console.WriteLine("Wizyta została dodana pomyślnie.");
            //Funkcje_Pomocnicze.Kontynuacja();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        public static void Menu_WizytaKardiolog()
        {
            //System.Console.WriteLine("wizyta neurolog"); 
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd3 = new SQLiteCommand($"SELECT pesel FROM users WHERE user_isLog = true", con);

            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();

            //string pesel_wizytujacego = pesel;
            //cmd3.ExecuteScalar();
            System.Console.WriteLine();
            Console.Write("Podaj datę wizyty w formacie [dd.mm.rrrr]: ");
            string Data;
            while (true)
            {
                string input = Console.ReadLine();
                if (Funkcje_Pomocnicze.Wizyta_DateCheck(input) == true)
                {
                    Data = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Podana data jest nieprawidlowa.");
                    Console.Write("Podaj datę jeszcze raz: ");
                }
            }
            Console.Clear();
            Frame.Neurolog();
            System.Console.WriteLine();
            System.Console.WriteLine("Przychodnia przyjmuje wizyty o pełnych godzinach, w porach od 10:00-16:00");
            System.Console.WriteLine("Podaj godzinę wizyty: ");
            int czas;
            int godzina;
            //czas = int.Parse(Console.ReadLine());
            while(true)
            {
                czas = int.Parse(Console.ReadLine());
                if(Funkcje_Pomocnicze.Wizyta_GodzinaCheck(czas) == true)
                {
                    godzina = czas;
                    break;
                }
                else
                {
                Console.WriteLine("Przychodnia przyjmuje wizyty o pełnych godzinach, w porach od 10:00-16:00");
                System.Console.WriteLine("Podaj godzinę w formacie {godzina}:00.");
                Console.Write(" Godzina: ");
                }
            }
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = $"INSERT INTO Wizyta(Data_wizyty, Godzina_wizyty, Lekarz_wizytowany, Pesel_wizytującego) VALUES(@Data_wizyty, @Godzina_wizyty, 'Kardiolog', @Pesel_wizytującego)";
            cmd.Parameters.AddWithValue("@Data_wizyty", Data);
            cmd.Parameters.AddWithValue("@Pesel_wizytującego", pesel);
            cmd.Parameters.AddWithValue("@Godzina_wizyty", czas);
            System.Console.WriteLine();
            System.Console.WriteLine("Wizyta została dodana pomyślnie.");
            //Funkcje_Pomocnicze.Kontynuacja();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        //tutaj usuwanie wizyt juz//
        public static void Menu_UsunWizytaNeurolog()
        {
            //System.Console.WriteLine("wizyta neurolog"); 
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            //wyswietlanie
            using var cmd3 = new SQLiteCommand($"SELECT pesel, name, surname, birth FROM users WHERE user_isLog = true", con);
            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();


            using var cmd4 = new SQLiteCommand($"SELECT Data_wizyty, Godzina_wizyty, Lekarz_wizytowany FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Neurolog'", con);
            using (SQLiteDataReader reader = cmd4.ExecuteReader())
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Wizyty umówione z Neurologiem:");
                System.Console.WriteLine();
            while(reader.Read())
            {
                System.Console.Write("Wizyta w dniu "+reader["Data_wizyty"]+"r. o godzinie ");
                Console.Write(reader["Godzina_wizyty"]+":00.");
                System.Console.WriteLine();
            }
                System.Console.WriteLine("-----------------------------------------------");
            }
            
            using var cmd5 = new SQLiteCommand($"SELECT Data_wizyty FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Neurolog'", con);
            using var cmd8 = new SQLiteCommand($"SELECT COUNT (Data_wizyty) FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Neurolog'", con);
            object check = cmd8.ExecuteScalar();
            string RecordCheck = check.ToString();
            int checkR = int.Parse(RecordCheck);
            //System.Console.WriteLine(checkR);
            
            string DataWizyty = "null";
            if(checkR>0)
            {
                object dataW = cmd5.ExecuteScalar();
                DataWizyty = dataW.ToString();
                System.Console.WriteLine("Podaj datę wizyty z Neurologiem, którą chcesz usunąć: ");
                System.Console.Write("Data: ");
            }
            else 
            {
            System.Console.WriteLine("Brak zarejestrowanych wizyt!");
            Funkcje_Pomocnicze.ClickToContinue();
            Menu.Menu_Lekarze();
            }
            string Data;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (Funkcje_Pomocnicze.Wizyta_DateCheck(input) == true)
                    {
                        Data = input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Podana data jest nieprawidlowa.");
                        Console.Write("Podaj datę jeszcze raz: ");
                    }
                }
            if(Data == DataWizyty && checkR > 0)
            {
                using var cmd6 = new SQLiteCommand(con);
                cmd5.CommandText = $"DELETE FROM Wizyta WHERE Lekarz_wizytowany = 'Neurolog' AND Pesel_wizytującego = {pesel} AND Data_wizyty = '{Data}'";
                //System.Console.WriteLine("Wizyty z Neurologiem zostały usunięte pomyślnie.");
                cmd5.Prepare();
                cmd5.ExecuteNonQuery();
                Console.Clear();
                Frame.Neurolog();
                System.Console.WriteLine();
                System.Console.WriteLine("Wizyta z Neurologiem została usunięta pomyślnie.");
            }
            else
            {
                System.Console.WriteLine("Nie ma wizyty zarejestrowanej na podaną datę!");
                Funkcje_Pomocnicze.ClickToContinue();
                Menu.Menu_Lekarze();
            }
        }
        public static void Menu_UsunWizytaStomatolog()
        {
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            //wyswietlanie
            using var cmd3 = new SQLiteCommand($"SELECT pesel, name, surname, birth FROM users WHERE user_isLog = true", con);
            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();


            using var cmd4 = new SQLiteCommand($"SELECT Data_wizyty, Godzina_wizyty, Lekarz_wizytowany FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Stomatolog'", con);
            using (SQLiteDataReader reader = cmd4.ExecuteReader())
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Wizyty umówione z Stomatologiem:");
                System.Console.WriteLine();
            while(reader.Read())
            {
                System.Console.Write("Wizyta w dniu "+reader["Data_wizyty"]+"r. o godzinie ");
                Console.Write(reader["Godzina_wizyty"]+":00.");
                System.Console.WriteLine();
            }
                System.Console.WriteLine("-----------------------------------------------");
            }
            
            using var cmd5 = new SQLiteCommand($"SELECT Data_wizyty FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Stomatolog'", con);
            using var cmd8 = new SQLiteCommand($"SELECT COUNT (Data_wizyty) FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Stomatolog'", con);
            object check = cmd8.ExecuteScalar();
            string RecordCheck = check.ToString();
            int checkR = int.Parse(RecordCheck);
            //System.Console.WriteLine(checkR);
            
            string DataWizyty = "null";
            if(checkR>0)
            {
                object dataW = cmd5.ExecuteScalar();
                DataWizyty = dataW.ToString();
                System.Console.WriteLine("Podaj datę wizyty ze Stomatologiem, którą chcesz usunąć: ");
                System.Console.Write("Data: ");
            }
            else 
            {
            System.Console.WriteLine("Brak zarejestrowanych wizyt!");
            Funkcje_Pomocnicze.ClickToContinue();
            Menu.Menu_Lekarze();
            }
            string Data;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (Funkcje_Pomocnicze.Wizyta_DateCheck(input) == true)
                    {
                        Data = input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Podana data jest nieprawidlowa.");
                        Console.Write("Podaj datę jeszcze raz: ");
                    }
                }
            if(Data == DataWizyty && checkR > 0)
            {
                using var cmd6 = new SQLiteCommand(con);
                cmd5.CommandText = $"DELETE FROM Wizyta WHERE Lekarz_wizytowany = 'Stomatolog' AND Pesel_wizytującego = {pesel} AND Data_wizyty = '{Data}'";
                //System.Console.WriteLine("Wizyty z Neurologiem zostały usunięte pomyślnie.");
                cmd5.Prepare();
                cmd5.ExecuteNonQuery();
                Console.Clear();
                Frame.Neurolog();
                System.Console.WriteLine();
                System.Console.WriteLine("Wizyta ze Stomatologiem została usunięta pomyślnie.");
            }
            else
            {
                System.Console.WriteLine("Nie ma wizyty zarejestrowanej na podaną datę!");
                Funkcje_Pomocnicze.ClickToContinue();
                Menu.Menu_Lekarze();
            }
        }
        public static void Menu_UsunWizytaAnestezjolog()
        {
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            //wyswietlanie
            using var cmd3 = new SQLiteCommand($"SELECT pesel, name, surname, birth FROM users WHERE user_isLog = true", con);
            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();


            using var cmd4 = new SQLiteCommand($"SELECT Data_wizyty, Godzina_wizyty, Lekarz_wizytowany FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Anestezjolog'", con);
            using (SQLiteDataReader reader = cmd4.ExecuteReader())
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Wizyty umówione z Anestezjologiem:");
                System.Console.WriteLine();
            while(reader.Read())
            {
                System.Console.Write("Wizyta w dniu "+reader["Data_wizyty"]+"r. o godzinie ");
                Console.Write(reader["Godzina_wizyty"]+":00.");
                System.Console.WriteLine();
            }
                System.Console.WriteLine("-----------------------------------------------");
            }
            
            using var cmd5 = new SQLiteCommand($"SELECT Data_wizyty FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Anestezjolog'", con);
            using var cmd8 = new SQLiteCommand($"SELECT COUNT (Data_wizyty) FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Anestezjolog'", con);
            object check = cmd8.ExecuteScalar();
            string RecordCheck = check.ToString();
            int checkR = int.Parse(RecordCheck);
            //System.Console.WriteLine(checkR);
            
            string DataWizyty = "null";
            if(checkR>0)
            {
                object dataW = cmd5.ExecuteScalar();
                DataWizyty = dataW.ToString();
                System.Console.WriteLine("Podaj datę wizyty z Anestezjologiem, którą chcesz usunąć: ");
                System.Console.Write("Data: ");
            }
            else 
            {
            System.Console.WriteLine("Brak zarejestrowanych wizyt!");
            Funkcje_Pomocnicze.ClickToContinue();
            Menu.Menu_Lekarze();
            }
            string Data;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (Funkcje_Pomocnicze.Wizyta_DateCheck(input) == true)
                    {
                        Data = input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Podana data jest nieprawidlowa.");
                        Console.Write("Podaj datę jeszcze raz: ");
                    }
                }
            if(Data == DataWizyty && checkR > 0)
            {
                using var cmd6 = new SQLiteCommand(con);
                cmd5.CommandText = $"DELETE FROM Wizyta WHERE Lekarz_wizytowany = 'Anestezjolog' AND Pesel_wizytującego = {pesel} AND Data_wizyty = '{Data}'";
                //System.Console.WriteLine("Wizyty z Neurologiem zostały usunięte pomyślnie.");
                cmd5.Prepare();
                cmd5.ExecuteNonQuery();
                Console.Clear();
                Frame.Neurolog();
                System.Console.WriteLine();
                System.Console.WriteLine("Wizyta z Anestezjologiem została usunięta pomyślnie.");
            }
            else
            {
                System.Console.WriteLine("Nie ma wizyty zarejestrowanej na podaną datę!");
                Funkcje_Pomocnicze.ClickToContinue();
                Menu.Menu_Lekarze();
            }
        }
        public static void Menu_UsunWizytaKardiolog()
        {
            string cs = "Data Source=./uzytkownicy.db"; //connection string  (wskazuje sciezke do bazy danych)
            using var con = new SQLiteConnection(cs);
            con.Open();

            //wyswietlanie
            using var cmd3 = new SQLiteCommand($"SELECT pesel, name, surname, birth FROM users WHERE user_isLog = true", con);
            object pesel_wizytujacego = cmd3.ExecuteScalar();
            string pesel = pesel_wizytujacego.ToString();


            using var cmd4 = new SQLiteCommand($"SELECT Data_wizyty, Godzina_wizyty, Lekarz_wizytowany FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Kardiolog'", con);
            using (SQLiteDataReader reader = cmd4.ExecuteReader())
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Wizyty umówione z Kardiologiem:");
                System.Console.WriteLine();
            while(reader.Read())
            {
                System.Console.Write("Wizyta w dniu "+reader["Data_wizyty"]+"r. o godzinie ");
                Console.Write(reader["Godzina_wizyty"]+":00.");
                System.Console.WriteLine();
            }
                System.Console.WriteLine("-----------------------------------------------");
            }
            
            using var cmd5 = new SQLiteCommand($"SELECT Data_wizyty FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Kardiolog'", con);
            using var cmd8 = new SQLiteCommand($"SELECT COUNT (Data_wizyty) FROM Wizyta WHERE pesel_wizytującego = {pesel} AND Lekarz_wizytowany = 'Kardiolog'", con);
            object check = cmd8.ExecuteScalar();
            string RecordCheck = check.ToString();
            int checkR = int.Parse(RecordCheck);
            //System.Console.WriteLine(checkR);
            
            string DataWizyty = "null";
            if(checkR>0)
            {
                object dataW = cmd5.ExecuteScalar();
                DataWizyty = dataW.ToString();
                System.Console.WriteLine("Podaj datę wizyty z Kardiologiem, którą chcesz usunąć: ");
                System.Console.Write("Data: ");
            }
            else 
            {
            System.Console.WriteLine("Brak zarejestrowanych wizyt!");
            Funkcje_Pomocnicze.ClickToContinue();
            Menu.Menu_Lekarze();
            }
            string Data;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (Funkcje_Pomocnicze.Wizyta_DateCheck(input) == true)
                    {
                        Data = input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Podana data jest nieprawidlowa.");
                        Console.Write("Podaj datę jeszcze raz: ");
                    }
                }
            if(Data == DataWizyty && checkR > 0)
            {
                using var cmd6 = new SQLiteCommand(con);
                cmd5.CommandText = $"DELETE FROM Wizyta WHERE Lekarz_wizytowany = 'Kardiolog' AND Pesel_wizytującego = {pesel} AND Data_wizyty = '{Data}'";
                //System.Console.WriteLine("Wizyty z Neurologiem zostały usunięte pomyślnie.");
                cmd5.Prepare();
                cmd5.ExecuteNonQuery();
                Console.Clear();
                Frame.Neurolog();
                System.Console.WriteLine();
                System.Console.WriteLine("Wizyta z Kardiologiem została usunięta pomyślnie.");
            }
            else
            {
                System.Console.WriteLine("Nie ma wizyty zarejestrowanej na podaną datę!");
                Funkcje_Pomocnicze.ClickToContinue();
                Menu.Menu_Lekarze();
            }
        }
    }
}
