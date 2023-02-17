using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Diseñe un algoritmo que, dados tres números, calcule e imprima el promedio.

            Console.Write("Ingrese el primer número: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int C = int.Parse(Console.ReadLine());

            float promedio = (A + B + C) / 3.0F;

            Console.WriteLine($"\nEl promedio es {promedio.ToString("#.##")}");
        }
    }
}
