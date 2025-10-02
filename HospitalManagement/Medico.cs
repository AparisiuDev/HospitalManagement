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
        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                $"DNI: {DNI}\n" +
                $"Sueldo: {Sueldo}\n" +
                $"---------\n";
        }
    }
}
