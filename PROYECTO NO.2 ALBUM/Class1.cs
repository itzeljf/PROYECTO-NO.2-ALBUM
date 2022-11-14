using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_NO._2_ALBUM
{
    class Album
    {
        static string[] codigosEspeciales = new string[] { "FWC" };

        static int inicioEspeciales = 0;
        static int finEspeciales = 30;

        static string[] codigosSelecciones = new string[] {
            "QAT","ECU","SEN","NED",
            "ENG","IRN","USA","WAL",
            "ARG","KSA","MEX","POL",
            "FRA","AUS","DEN","TUN",
            "ESP","CRC","GER","JPN",
            "BEL","CAN","MAR","CRO",
            "BRA","SRB","SUI","CMR",
            "POR","GHA","URU","KOR"
        };

        static int inicioSelecciones = 1;
        static int finSelecciones = 20;

        public Estampa[] estampas;
        public int totalEstampas;

        public Album()
        {
            this.totalEstampas = (finEspeciales - inicioEspeciales) * codigosEspeciales.Length + (finSelecciones - inicioSelecciones) * codigosSelecciones.Length;
            estampas = new Estampa[totalEstampas];
            // codigo para crear estampas

            int i = 0;

            for (int j = 0; j < codigosEspeciales.Length; j++)
            {

                for (int k = inicioEspeciales; k < finEspeciales; k++)
                {
                    estampas[i] = new Estampa(codigosEspeciales[j], k);
                    i++;
                }
            }

            for (int j = 0; j < codigosSelecciones.Length; j++)
            {

                for (int k = inicioSelecciones; k < finSelecciones; k++)
                {
                    estampas[i] = new Estampa(codigosSelecciones[j], k);
                    i++;
                }
            }
        }

        public int buscarEstampa(string codigo)
        {
            for (int i = 0; i < totalEstampas; i++)
            {
                if (estampas[i].codigo.Equals(codigo))
                {
                    return i;
                }
            }
            return -1;
        }

        public void mostrarMarcadas()
        {
            for (int i = 0; i < totalEstampas; i++)
            {
                if (estampas[i].esMarcada())
                {
                    Console.WriteLine(estampas[i].codigo);
                }
            }
        }

        public void mostrarRepetidas()
        {
            for (int i = 0; i < totalEstampas; i++)
            {
                if (estampas[i].esRepetida())
                {
                    Console.WriteLine(estampas[i].codigo);
                }
            }
        }

        public void mostrarFalatantes()
        {
            for (int i = 0; i < totalEstampas; i++)
            {
                if (estampas[i].esFaltante())
                {
                    Console.WriteLine(estampas[i].codigo);
                }
            }
        }
    }
}
