using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Diseñe un algoritmo que, dados dos números, imprima su suma.

            Console.Write("Ingrese el primer número: ");
            int N1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int N2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLa suma es: {N1 + N2}");
        }
    }
}
