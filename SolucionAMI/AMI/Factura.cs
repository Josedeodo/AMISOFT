using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI
{
    class Factura
    {
        public Caso Caso;
        private int id;
        private double subTotal;
        private double total;

        public Factura() { }

        public Factura(int id, double subTotal, double total) 
        {
            this.id = id;
            this.subTotal = subTotal;
            this.total = total;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
