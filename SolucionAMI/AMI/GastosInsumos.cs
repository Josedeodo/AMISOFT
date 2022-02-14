using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI
{
    class GastosInsumos
    {
        public Caso Caso;
        private int id;
        private string nombreInsumo;
        private double costoInsumo;
        private int cantidad;
        private double costoTotal;

        public GastosInsumos(int id, string nombreInsumo, double costoInsumo, int cantidad, double costoTotal) 
        {
            this.id = id;
            this.nombreInsumo = nombreInsumo;
            this.costoInsumo = costoInsumo;
            this.cantidad = cantidad;
            this.costoTotal = costoTotal;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombreInsumo
        {
            get { return nombreInsumo; }
            set { nombreInsumo = value; }
        }

        public double CostoInsumo
        {
            get { return costoInsumo; }
            set { costoInsumo = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double CostoTotal
        {
            get { return costoTotal; }
            set { costoTotal = value; }
        }
    }
}
