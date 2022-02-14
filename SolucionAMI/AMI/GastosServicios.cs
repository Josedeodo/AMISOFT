using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI
{
    class GastosServicios
    {
        public Servicios Servicios;
        public Caso Caso;
        public Factura Factura;
        private int id;
        
        public GastosServicios() { }

        public GastosServicios(int id) { this.id = id; }
                
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
