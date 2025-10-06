using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Persona
    {
        private int _dni;
        private string _nombre;

        public int DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                $"DNI: {DNI}\n";
        }
    }
}

