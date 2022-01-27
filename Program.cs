using System;
using System.Data.SQLite;


namespace Przychodnia_Gdynia
{
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
