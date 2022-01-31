using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
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
        public static string WriteVariable(string variable)
        {
            while (true)
            {
                Console.Write($"Podaj {variable}: ");
                string name;
                name = Console.ReadLine();
                if(ValidateLength(name)==true)
                {
                    bool containsInt = name.Any(char.IsDigit);
                    if (!containsInt)
                    {
                        return name;
                    }
                }
                Console.Clear();
                Frame.Rejestracja();
                Console.WriteLine($"Niepoprawne {variable}. Spróbuj ponownie.");
            }
        }
        public static string WritePESEL()
        {
            Console.Write("Podaj NR PESEL: ");
            string pesel;
            while (true)
            {
                pesel = Console.ReadLine();
                if (ValidatePesel(pesel) == true)
                {
                    return pesel;
                }
                
            }
        }
        public static bool ValidateLength(string variable)
        {
            if (variable.Length >= 3 && variable.Length <= 32)
            {
                return true;
            }
            else
                return false;
        }
        public static bool ValidatePassword(string pass1 , string pass2)
        {
            if (pass1 == pass2) return true;
            else
                return false;
        }
        public static bool ValidatePesel(string pesel)
        {
            long temp;
            bool successfullyParsed = long.TryParse(pesel, out temp);
            if (successfullyParsed)
            {
                if (pesel.Length == 11)
                {
                    if (CheckPesel(pesel))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else 
                {
                    Console.Clear();
                    Frame.Rejestracja();
                    System.Console.WriteLine();
                    Console.WriteLine("Niepoprawny PESEL");
                    Console.WriteLine("Nr PESEL powinien skladac sie z 11 liczb");
                    Console.Write("Podaj numer PESEL ponownie: ");
                    return false;
                }
            }
            else 
            {
                Console.Clear();
                Frame.Rejestracja();
                System.Console.WriteLine();
                Console.WriteLine("Niepoprawny numer PESEL");
                Console.WriteLine("Nr PESEL powinien skladac sie z 11 liczb");
                Console.Write("Podaj numer PESEL ponownie: ");
                return false;
            }

        }
        public static bool CheckPesel(string pesel)
        {
            string cs = "Data Source=./uzytkownicy.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            string stm = $"SELECT * FROM users WHERE pesel={pesel};";
            using var cmd = new SQLiteCommand(stm, con);
            var result = cmd.ExecuteScalar();
            con.Close();
            if (result!=null)
            {
                Console.Clear();
                Frame.Rejestracja();
                System.Console.WriteLine();
                Console.WriteLine("Podany numer Pesel już znajduje się w bazie!");
                Console.Write("Podaj właściwy numer PESEL lub spróbuj się zalogować. ");
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public static void Kontynuacja()
        {
            EmptySpaceDots(3);
            ClickToContinue();
        }
    }
}
