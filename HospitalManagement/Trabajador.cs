using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Trabajador:Persona
    {
        private int _sueldo;
        public int Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }

        public Trabajador(int dni, int sueldo, string nombre):base(dni,nombre)
        {
            DNI = dni;
            Sueldo = sueldo;
            Nombre = nombre;
        }
    }
}
