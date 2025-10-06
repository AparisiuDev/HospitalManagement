using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
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
            string filePath = "hosp.json";
            Hospital hospital;

            AsciiArt();
            artBottomY = Console.CursorTop;

            // Cargar hospital si existe
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                hospital = JsonSerializer.Deserialize<Hospital>(json);
                Console.WriteLine($"Hospital cargado: {hospital.Name}");
            }
            else
            {
                Console.WriteLine("Introduce el nombre de tu hospital:");
                hospital = new Hospital(Console.ReadLine());
                GuardarHospital(hospital, filePath);
            }

            CleanUp();

            while (exit)
            {
                CleanUp();
                Console.WriteLine($"\nBienvend@ al hospital {hospital.Name}!");
                Console.WriteLine("1. Añadir personal");
                Console.WriteLine("2. Eliminar personal");
                Console.WriteLine("3. Asignar médico a paciente");
                Console.WriteLine("4. Mostrar personas");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        hospital.AddStaff();
                        break;
                    case 2:
                        hospital.RemoveStaff(); 
                        break;
                    case 3:
                        int p, m;
                        Console.WriteLine("Elije el numero del paciente que quieres asignar un medico:");
                        hospital.MostrarPacientes();
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Elije el numero del medico que quieres asignar al paciente:");
                        hospital.MostrarMedicos();
                        m = int.Parse(Console.ReadLine());
                        hospital.Pacientes[p-1].AsignarMedico(hospital.Medicos[m-1]);
                        break;
                    case 4:
                        hospital.MostrarPersonas();
                        break;
                    case 5:
                        GuardarHospital(hospital, filePath);
                        Console.WriteLine("Saliendo y guardando datos...");
                        exit = false;
                        return;
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
        public static void GuardarHospital(Hospital hospital, string path)
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            };

            string json = JsonSerializer.Serialize(hospital, opciones);
            File.WriteAllText(path, json);
        }
    }
}
