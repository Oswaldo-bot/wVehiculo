using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wVehiculo2
{
    class clsCrearParticular
    {

        //Declaracion de variables
        private string Placa;
        private string Color;
        private string Modelo;
        private string Potencia;

        //Encapsulamiento
        public string placa
        {
            get { return Placa; }
            set { Placa = value; }
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

        public string potencia
        {
            get { return Potencia; }
            set { Potencia = value; }
        }

        public string ManejarParticular()
        {
            return "Usted no tiene Multas";
        }
    }

}

