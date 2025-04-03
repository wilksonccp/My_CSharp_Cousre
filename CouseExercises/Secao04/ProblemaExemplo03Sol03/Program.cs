using System;
using System.Globalization;

namespace ProblemaExemplo03Sol03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {Calculadora.Circunferencia(raio).ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Calculadora.Volume(raio).ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi}");
        }
    }
}


