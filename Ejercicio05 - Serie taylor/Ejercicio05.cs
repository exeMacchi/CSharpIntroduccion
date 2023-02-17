using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 5. Halle el resultado de ex a partir del empleo de la siguiente serie Taylor:
           //       ex = 1 + (x / 1!) + (x2 / 2!) + (x3 / 3)
           //    El usuario debe ingresar solo el valor de x.


            Console.Write("Ingrese X: ");
            float X = float.Parse(Console.ReadLine());

            float respuesta = 1 + X + ((X * X) / 2) + ((X * X * X) / 6);

            Console.WriteLine($"\nSerie taylor: ex({X}) = {Math.Round(respuesta, 2)}");
        }
    }
}
