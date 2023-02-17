using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Diseñe un algoritmo que imprima el número siguiente al ingresado.

            Console.Write("Ingrese un número: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine($"El número siguiente es {++N}\n");
        }
    }
}
