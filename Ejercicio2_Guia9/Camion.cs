using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Guia9
{
    class Camion
    {
        private int paradas;
        private int cantM5;
        private int cantM10;
        private int des5litros;
        private int des10litros;
        private int c5litros;
        private int c10litros;
        private int totalDescargas5Litros;
        private int totalDescargas10Litros;

        public Camion(int bidones5Litros, int bidones10litros)
        {
            this.c5litros = bidones5Litros;
            this.c10litros = bidones10litros;
        }
        public int C5litros
        {
            get { return c5litros; }
        }

        public int C10litros
        {
            get { return c10litros; }
        }

        public void Descarga(int cant5, int cant10)
        {
            if (cant5 != 0)
            {
                des5litros++;
                c5litros -= cant5;
                totalDescargas5Litros += cant5;
                if (cant5 > cantM5)
                    cantM5 = cant5;
            }

            if (cant10 != 0)
            {
                des10litros++;

                if (cant10 > cantM10)
                    cantM10 = cant10;
                c10litros -= cant10;
                totalDescargas10Litros += cant10;

            }
           if(cant5!=0 || cant10!=0)
            paradas++;

        }
        public double Promedio5litros()
        {

            double promedio5litros;
            if (des5litros > 0)
                promedio5litros = (double)totalDescargas5Litros / (double)des5litros;
            else promedio5litros = 0;
            return promedio5litros;
        }
        public double Promedio10litros()
        {
            double promedio10litros;
            if (des10litros > 0)
                promedio10litros = (double)totalDescargas10Litros / (double)des10litros;
            else promedio10litros = 0;
            return promedio10litros;


        }
        public int Mayor5litros()
        {



            return cantM5;
        }
        public int Mayor10litros()
        {

            return cantM10;

        }
        public int CantidadParadas()
        {


            return paradas;
        }
    }
}
