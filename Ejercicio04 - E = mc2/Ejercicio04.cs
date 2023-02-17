using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Halle la energía según la masa m y la velocidad de la luz c con la
            // célebre fórmula de Einstein E = mc2

            Console.Write("Ingrese la masa (kg): ");
            double masa = double.Parse(Console.ReadLine());
            const double VELOCIDADLUZ = 299_793_458.0;
            double velocidad = VELOCIDADLUZ * VELOCIDADLUZ;

            double energia = masa * velocidad;

            Console.WriteLine($"Energía total: {energia} joules");
        }
    }
}
