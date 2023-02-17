using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10. Diseñe un algoritmo que, dadas las longitudes de los lados de un trapecio, calcule
            // e imprima perímetro.

            Console.Write("Ingrese el primer lado del trapecio: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo lado del trapecio: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer lado del trapecio: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto lado del trapecio: ");
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEl perímetro del trapecio es {A + B + C + D}");
        }
    }
}
