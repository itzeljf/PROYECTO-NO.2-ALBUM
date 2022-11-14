using System;

namespace PROYECTO_NO._2_ALBUM
{
    class Program
    {
        static Album album;
        static void marcarEstampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if (i >= 0)
            {
                album.estampas[i].marcar();

            }
            else
            {
                Console.WriteLine("Estampa no encontrada");
            }
        }

        static void RepetirEstampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if (i >= 0)
            {
                album.estampas[i].repetir();

            }
            else
            {
                Console.WriteLine("Estampa repetida");
            }
        }

        static void EstampaFaltante(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if (i >= 0)
            {
                album.estampas[i].faltar();
            }
            else
            {
                Console.WriteLine("Estampa faltante");
            }
        }


        static void Main(string[] args)
        {
            album = new Album();

            album.mostrarMarcadas();

            int opcion = 0;
            do
            {
                Console.WriteLine("Ingresar el codigo de la estampa: ");
                String code = Console.ReadLine();

                Console.WriteLine("Seleccione una de las opciones: ");
                Console.WriteLine("Ingrese 1 para mostrar estampas marcadas");
                Console.WriteLine("Ingrese 2 para mostrar estampas repetidas");
                Console.WriteLine("Ingrese 3 para mostrar estampas faltantes ");
                Console.WriteLine("Ingrese 4 para: Salir");

                Console.Write("Ingresar Opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    marcarEstampa(code);
                    album.mostrarMarcadas();
                }

                else if (opcion == 2)
                {
                    RepetirEstampa(code);
                    album.mostrarRepetidas();
                }

                else if (opcion == 3)
                {
                    EstampaFaltante(code);
                    album.mostrarFalatantes();
                }

                else if (opcion == 4)
                {
                    Console.WriteLine("Has elegido Salir");
                }

                else Console.WriteLine("Eleccion no valida");

                Console.ReadKey();
                Console.Clear();

            } while (opcion != 4);
        }
    }

}