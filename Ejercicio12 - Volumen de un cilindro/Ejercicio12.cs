using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12. Diseñe un algoritmo que calcule el volumen de un cilindro dado su radio y altura (volumen=2.π.r.h).

            Console.Write("Radio del cilindro: ");
            float radio = float.Parse(Console.ReadLine());

            Console.Write("Altura del cilindro: ");
            float altura = float.Parse(Console.ReadLine());

            double volumen = 2 * Math.PI * radio * altura;

            Console.WriteLine($"\nVolumen del cilindro: {Math.Round(volumen, 2)}");
        }
    }
}
