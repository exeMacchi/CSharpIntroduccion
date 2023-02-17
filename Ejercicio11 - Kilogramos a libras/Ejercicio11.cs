using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                11. Diseñe un algoritmo que, dado el peso de un objeto en kg, calcule y muestre dicho peso en libras
                    (1 libra es igual a 0.453592 kg).
            */

            Console.Write("Ingrese un peso en kilogramos: ");
            float Num = float.Parse(Console.ReadLine());

            double libra = Num * 2.205;

            Console.WriteLine($"\nEl peso en libras: {Math.Round(libra, 2)} lbs.");
        }
    }
}
