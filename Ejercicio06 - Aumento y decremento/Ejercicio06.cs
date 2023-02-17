using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                6. Ingrese un número y muestre dos resultados que provengan de éste: aumentado un 10 % y
                   disminuido en un 20 %
            */

            Console.Write("Ingrese un número: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n10% aumento: {N * 1.10}");
            Console.WriteLine($"20% disminuido: {N * 0.80}");
        }
    }
}
