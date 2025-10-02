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
        }

        public void AddStaff()
        {

        }
    }
}
