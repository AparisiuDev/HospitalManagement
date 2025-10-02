using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Program
    {
        public static int artBottomY;
        static void Main(string[] args)
        {
            bool exit = true;

            AsciiArt();
            artBottomY = Console.CursorTop;
            Console.WriteLine("Introduce el nombre de tu hospital");
            Hospital hospital = new Hospital(Console.ReadLine());
            CleanUp();

            while (true)
            {
                Console.WriteLine($"Bienvend@ al hospital {hospital.Name}!");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:

                }
            }

        }

        public static void AsciiArt()
        {
            Console.WriteLine(@"  _   _                 _ _        _   ____  _                 _       _             
 | | | | ___  ___ _ __ (_) |_ __ _| | / ___|(_)_ __ ___  _   _| | __ _| |_ ___  _ __ 
 | |_| |/ _ \/ __| '_ \| | __/ _` | | \___ \| | '_ ` _ \| | | | |/ _` | __/ _ \| '__|
 |  _  | (_) \__ \ |_) | | || (_| | |  ___) | | | | | | | |_| | | (_| | || (_) | |   
 |_| |_|\___/|___/ .__/|_|\__\__,_|_| |____/|_|_| |_| |_|\__,_|_|\__,_|\__\___/|_|   
                 |_|                                                                 ");
        }

        public static void CleanUp()
        {
            int totalLines = Console.WindowHeight - artBottomY; 
            for (int y = 0; y < totalLines; y++)
            {
                Console.SetCursorPosition(0, artBottomY + y);
                Console.Write(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, artBottomY);
        }
    }
}
