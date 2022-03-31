using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wVehiculo2
{
     class clsCrearTaxi
    {

        //Declaracion de variables metodo constructor
        private string Placa;
        private string Marca;
        private string Color;
        private string Modelo;


        //Encapsulamiento
        public string placa
        {
            get { return Placa; }
            set { Placa = value; }
        }
        public string marca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        public string color
        {
            get { return Color; }
            set { Color = value; }
        }

        public string modelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }

        public string ManejarTaxi()
        {
            return "Usted no tiene Multas";
        }
    }

}

