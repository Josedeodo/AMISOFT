using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI
{
    class Persona
    {
        private string numeroDocumento;
        private string tipoDocumento;
        private string nombre;
        private string fechaNacimiento;
        private string telefono;
        private string email;

        public Persona() { }

        public Persona(string numeroDocumento, string tipoDocumento, string nombre, string fechaNacimiento, string telefono, string email) 
        {
            this.numeroDocumento = numeroDocumento;
            this.tipoDocumento = tipoDocumento;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.email = email;
        }             

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }               

        public string TipoDocumento 
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
