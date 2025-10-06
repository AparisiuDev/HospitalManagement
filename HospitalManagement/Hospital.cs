using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Hospital
    {
        private string _name;
        private List<Admin> _staff;
        private List <Medico> _medicos;
        private List <Paciente> _pacientes;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Admin> Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }
        public List<Medico> Medicos
        {
            get { return _medicos;}
            set { _medicos = value; }
        }
        public List<Paciente> Pacientes
        {
            get { return _pacientes;}
            set { _pacientes = value;}
        }
        public Hospital(string name)
        {
            Name = name;
            Staff = new List<Admin>();
            Medicos = new List<Medico>();
            Pacientes = new List<Paciente>();
        }

        public void AddStaff()
        {
            Console.WriteLine("Elije que quieres agregar:\n1. Admin\n2. Medico\n3. Paciente\n");
            int option = int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                    Console.WriteLine("Ingrese el nombre del admin:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Ingrese el DNI del admin:");
                    int dni = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo del admin:");
                    int sueldo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la funcion del admin:");
                    string funcion = Console.ReadLine();
                    Admin admin = new Admin(dni, name, sueldo, funcion);
                    Staff.Add(admin);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre del medico:");
                    string nameM = Console.ReadLine();
                    Console.WriteLine("Ingrese el DNI del medico:");
                    int dniM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo del medico:");
                    int sueldoM = int.Parse(Console.ReadLine());
                    Medico medico = new Medico(dniM, sueldoM, nameM);
                    Medicos.Add(medico);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre del paciente:");
                    string nameP = Console.ReadLine();
                    Console.WriteLine("Ingrese el DNI del paciente:");
                    int dniP = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la condicion del paciente:");
                    string condicion = Console.ReadLine();
                    Paciente paciente = new Paciente(dniP, nameP, condicion);
                    Pacientes.Add(paciente);
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        public void RemoveStaff()
        {
            Console.WriteLine("Elije que quieres eliminar:\n1. Admin\n2. Medico\n3. Paciente\n");
            int option = int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                    MostrarStaff();
                    Console.WriteLine("Ingrese el numero del admin a eliminar:");
                    int n = int.Parse(Console.ReadLine());
                    Staff.RemoveAt(n-1);
                    break;
                case 2:
                    MostrarMedicos();
                    Console.WriteLine("Ingrese el numero del medico a eliminar:");
                    int m = int.Parse(Console.ReadLine());
                    Medicos.RemoveAt(m-1);
                    break;
                case 3:
                    MostrarPacientes();
                    Console.WriteLine("Ingrese el numero del paciente a eliminar:");
                    int p = int.Parse(Console.ReadLine());
                    Pacientes.RemoveAt(p-1);
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        public void MostrarPersonas()
        {
            Console.WriteLine("Que lista quieres ver:\n1. Admins\n2. Medicos\n3. Pacientes\n");
            int option = int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                    MostrarStaff();
                    Console.ReadKey();
                    break;
                case 2:
                    MostrarMedicos();
                    Console.ReadKey();
                    break;
                case 3:
                    MostrarPacientes();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    Console.ReadKey();
                    break;
            }
        }

        public void MostrarMedicos()
        {
            Console.WriteLine("LISTA DE MEDICOS");
            int n = 1;
            foreach (var item in Medicos)
            {
                Console.Write(n);
                n++;
                Console.Write(item);
            }
        }
        public void MostrarPacientes()
        {
            Console.WriteLine("LISTA DE PACIENTES");
            int n = 1;
            foreach (var item in Pacientes)
            {
                Console.Write(n);
                n++;
                Console.WriteLine(item);
            }
        }
        public void MostrarStaff()
        {
            Console.WriteLine("LISTA DE STAFF");
            int n = 1;
            foreach (var item in Staff)
            {
                Console.Write(n);
                n++;
                Console.WriteLine(item);
            }
        }
    }
}
