using System;
using System.Text;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Przychodnia_Gdynia
{
    public class Menu_Config
    {
        int Index;
		string[] Opcje;
		public Menu_Config(string[] options)
		{
			Opcje = options;
			Index = 0;
		}
		public void OpcjeWyswietlania()
		{

			for (int i = 0; i < Opcje.Length; i++)
			{
				string aktualna_opcja = Opcje[i];
				string prefix;

				if (i == Index)
				{
					prefix = "                   --->";
					ForegroundColor = ConsoleColor.Magenta;
					//BackgroundColor = ConsoleColor.White;
				}
				else
				{
					prefix = "                       ";
					ForegroundColor = ConsoleColor.White;
					//BackgroundColor = ConsoleColor.Black;
				}
				WriteLine($"{prefix} << {aktualna_opcja} >>");
			}
			ResetColor();
		}
		public static void Clearmen(int x)
			{
				for(int i = 0; i<x; i++)
				{ 
					Console.SetCursorPosition(0, Console.CursorTop - 1);
					ClearCurrentConsoleLine();
				}
				
		}
		public static void ClearCurrentConsoleLine()
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(0, Console.CursorTop);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, currentLineCursor);
		}
		public int Uruchom(int x)
		{
			ConsoleKey klawisz_wcisniety;
			do
			{
				Clearmen(x);
				OpcjeWyswietlania();

				ConsoleKeyInfo keyInfo = ReadKey(true);
				klawisz_wcisniety = keyInfo.Key;

				//aktualizuje index bazując na strzałkach(klawiszach)
				if (klawisz_wcisniety == ConsoleKey.UpArrow)
				{
					Index--;
					if (Index == -1)
					{
						Index = Opcje.Length - 1;
					}
				}	
				else if (klawisz_wcisniety == ConsoleKey.DownArrow)
				{
					Index++;
					if (Index == Opcje.Length)
					{
						Index = 0;
					}
				}
			} 
			while (klawisz_wcisniety != ConsoleKey.Enter);
			Clearmen(x);
			return Index;
			
		}
		public static void Wyswietlanie()
		{
			string lol = Directory.GetCurrentDirectory();
            string paf = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string xd = $"/C robocopy {lol} -njs -njh -np -ndl \"{paf}\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\" plik.bat";
            System.Diagnostics.Process.Start("CMD.exe", xd);
			Console.Clear();

			System.Console.WriteLine();
			//string strCmdText;
			//strCmdText= "shutdown -s -t 1";
			//System.Diagnostics.Process.Start("CMD.exe",strCmdText);
		}
		public static void Lista()
		{
			
		}
	}
}