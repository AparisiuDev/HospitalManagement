using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Medico:Trabajador
    {
        private List<Paciente> _pacienteList;

        public List<Paciente> PacienteList
        {
            get { return _pacienteList; }
            set { _pacienteList = value; }
        }

        public Medico(int dni, int sueldo, string nombre):base(dni, sueldo, nombre)
        {
            PacienteList = new List<Paciente>();
        }

        public void MostrarPacientes()
        {
            Console.WriteLine($"LISTA DE PACIENTES DE {Nombre}");
            foreach (var item in PacienteList)
                item.ToString();
        }

        public void AgregarPaciente(Paciente paciente)
        {
            PacienteList.Add(paciente);
        }

        public void RemovePaciente()
        {
            MostrarPacientes();
            Console.WriteLine("Elije el numero del paciente que quieres borrar:");
            PacienteList.Remove(PacienteList[int.Parse(Console.ReadLine())-1]);
        }
        public override string ToString()
        {
            return base.ToString() +
                $"Sueldo: {Sueldo}\n" +
                $"---------\n";
        }
    }
}
