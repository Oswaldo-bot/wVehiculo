using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wVehiculo2
{
     public class ClsCrearBuseta
   {
        //Declaracion de variables metodo constructor
        private string Placa;
        private string Marca;
        private string Color;
        private string Modelo;
        private string Potencia;

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
            get { return Modelo;}
            set { Modelo = value;}
        }

        public string potencia 
        {
          get { return Potencia;}
          set { Potencia = value;}
        }

       public string ManejarBuseta()
       {
          return "Usted no tiene Multas......";
       }
     }

}
