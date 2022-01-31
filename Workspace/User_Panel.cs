using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Przychodnia_Gdynia
{
    class User_Panel
    {
        public static void Recepty()
        {
            //lista recept otrzymanych
            Console.Clear();
            Frame.Recepty();
            System.Console.WriteLine("Lista otrzymanych recept: ");
            Funkcje_Pomocnicze.Kontynuacja();
        }
        public static void Wizyty()
        {
            //lista umowionych wizyt
            Console.Clear();
            Frame.Wizyty();
            System.Console.WriteLine("Terminy wizyt: ");
            Funkcje_Pomocnicze.Kontynuacja();
        }
        public static void Lekarze()
        {
            //a tutaj odwolanie do klasy wywolujacej menu wyboru czy chcemy sie umowic na wizyte/recepte
            //System.Console.WriteLine("Lista lekarzy specjalistów: ");

            Menu.Menu_Lekarze();
        }
    }
}