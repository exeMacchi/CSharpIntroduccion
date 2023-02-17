using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Diseñe un algoritmo que imprima el cuadrado y el cubo de un número ingresado.

            Console.Write("Ingrese un número: ");
            int N = int.Parse(Console.ReadLine());

            int cuadrado = N * N;
            int cubo = N * N * N;

            Console.WriteLine($"\nEl {N} al cuadrado es {cuadrado}");
            Console.WriteLine($"El {N} al cubo es {cubo}\n");
        }
    }
}
