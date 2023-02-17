using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                8. Diseñe un algoritmo que imprima el perímetro de un triángulo cuyos tres lados se ingresan por
                   teclado. (perímetro = a + b + c) 
            */

            Console.Write("Primer lado del triángulo: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Segundo lado del triángulo: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Tercer lado del triángulo: ");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEl perímetro del triángulo es {A + B + C}");
        }
    }
}
