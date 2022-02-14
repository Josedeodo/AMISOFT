using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI
{
    class Servicios
    {
        public Caso Caso;
        private int id;
        private string nombre;
        private string descripcion;
        private double valor;

        public Servicios() { }

        public Servicios(int id, string nombre, string descripcion, double valor) 
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.valor = valor;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }       

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string  Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
