using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAM_LITTLE_EXTERMINATORS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PROGRAMA QUE CALCULA EL PROMEDIO DE 4 PUNTUACIONES DE UN ALUMNO*/

            Console.WriteLine("PROGRAMACION ESTRUCTURADA O&M 0463");
            Console.WriteLine("INGENIERIA INDUSTRIAL");

            Console.WriteLine("MADELIN RODRIGRUEZ   16-SIIT-1-042");
            Console.WriteLine("CORAL CRUZ           16-SIIT-1-016");
            Console.WriteLine("CRISTOPHER GIL       16-SIIN-1-177");

            //INTRODUCCION DE LAS VARIABLES
            int PUNTUACION1, PUNTUACION2, PUNTUACION3, PUNTUACION4;
            string linea;
            Console.Write("Ingrese la primera puntuación");
            linea = Console.ReadLine();
            PUNTUACION1 = int.Parse(linea);
            Console.Write("Ingrese la segunda puntuación");
            linea = Console.ReadLine();
            PUNTUACION2 = int.Parse(linea);
            Console.Write("Ingrese la tercera puntuación");
            linea = Console.ReadLine();
            PUNTUACION3 = int.Parse(linea);
            Console.Write("Ingrese la cuarta puntuación");
            linea = Console.ReadLine();
            PUNTUACION4 = int.Parse(linea);
            int promedio = (PUNTUACION1 + PUNTUACION2 + PUNTUACION3 + PUNTUACION4) / 4;

            //CONDICIONES IF
            if (promedio > 70)
            {
                Console.Write("Promocionado: ");
                Console.WriteLine(promedio);
            }
            else
            
                if (promedio < 70)
                {
                    Console.Write("Repitente");
                }

            //IMPLEMENTACION DEL BUCLE


            {
                int p = 1;

                Console.WriteLine("INTRODUCE LA POTENCIA A LA CUAL DESEAS ELEVAR");
                int.TryParse(Console.ReadLine(), out p);

                for (int n = 1; n <= 10; n++)

                {

                    double m = Math.Pow(n, p);

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine(n + " ^ " + p + " = " + m);

                }
            }
            Console.WriteLine("ESPERAMOS QUE LES HAYA GUSTADO EL PROGRAMA");
            Console.ReadLine();

            Console.ReadKey();

            /* Programa hecho por:
             *MADELIN RODRIGUEZ          16-SIIT-1-042  SECCION 0463
             * CORAL CRUZ                16-SIIT-1-016  SECCION 0463
             * CRISTOPHER GIL            16-SIIN-1-177  SECCION 0463*/
        }
    }
}
