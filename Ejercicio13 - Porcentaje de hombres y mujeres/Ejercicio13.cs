using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                13. Diseñe un algoritmo para calcular el porcentaje de hombres y de mujeres que hay en un grupo,
                    dados los totales de hombres y de mujeres.
            */

            Console.Write("Cantidad total de hombres: ");
            int cantidadHombres = int.Parse(Console.ReadLine());

            Console.Write("Cantidad total de mujeres: ");
            int cantidadMujeres = int.Parse(Console.ReadLine());

            int cantidadTotal = cantidadHombres + cantidadMujeres;

            int porcentajeHombres = (cantidadHombres * 100) / cantidadTotal;
            int porcentajeMujeres = 100 - porcentajeHombres;

            Console.WriteLine($"\nEn el grupo, el {porcentajeHombres}% son hombres y el " +
                              $"{porcentajeMujeres}% son mujeres.");
        }
    }
}
