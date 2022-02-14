using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI
{
    class Rol
    {
        public Usuario Usuario;
        private int id;
        private string nombreRol;
        private string descripcion;

        public Rol() { }

        public Rol(int id, string nombreRol, string descripcion) 
        {
            this.id = id;
            this.nombreRol = nombreRol;
            this.descripcion = descripcion;
        }  

        public int Id
        {   
            get { return id; }
            set { id = value; }
        }

        public string NombreRol
        {
            get { return nombreRol; }
            set { nombreRol = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
