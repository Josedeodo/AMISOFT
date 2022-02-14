using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI
{
    class Vehiculo
    {
        public Cliente Cliente;
        private int id;
        private string placa;
        private string color;
        private string marca;
        private string modelo;
        private string servicio;

        public Vehiculo() { }

        public Vehiculo(int id, string placa, string color, string marca, string modelo, string servicio) 
        {
            this.id = id;
            this.placa = placa;
            this.color = color;
            this.marca = marca;
            this.modelo = modelo;
            this.servicio = servicio;
        }        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }
    }
}
