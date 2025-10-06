using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Admin:Trabajador
    {
        private string _funcion;
        
        public string Funcion
        {
            get { return _funcion; }
            set { _funcion = value; }
        }

        public Admin(int dni, string name, int sueldo, string funcion):base(dni, sueldo, name)
        {
            Funcion = funcion;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Sueldo: {Sueldo}\n" +
                $"Funcion: {Funcion}\n"+
                $"---------\n";
        }
    }
}
