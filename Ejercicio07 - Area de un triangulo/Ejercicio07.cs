using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                7. Diseñe un algoritmo que imprima el área de un triángulo cuya base y altura se ingresan por teclado.
                   (área = (b * h) / 2)
            */

            Console.Write("Ingrese la base del triángulo: ");
            float Base = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            float Altura = float.Parse(Console.ReadLine());

            float trianguloArea = (Base * Altura) / 2;

            Console.WriteLine($"\nEl area del triángulo es: {Math.Round(trianguloArea, 2)}");
        }
    }
}
