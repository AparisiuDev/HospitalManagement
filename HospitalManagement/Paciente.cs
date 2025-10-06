using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Paciente:Persona
    {
        private string _condicion;
        private Medico _medico;

        public string Condicion
        {
            get { return _condicion; }
            set { _condicion = value; }
        }
        public Medico Medico
        {
            get { return _medico; }
            set { _medico = value; }
        }

        public Paciente(int dni, string nombre, string condicion):base(dni, nombre)
        {
            Condicion = condicion;
        }

        public void AsignarMedico(Medico medico)
        {
            Medico = medico;
            medico.PacienteList.Add(this);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Medico asignado: {Medico.Nombre}\n" +
                $"Condicion: {Condicion}\n" +
                $"-------";
        }
    }
}
