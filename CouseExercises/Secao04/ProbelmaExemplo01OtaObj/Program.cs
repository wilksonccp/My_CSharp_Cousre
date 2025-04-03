using System;
using System.Globalization;
using ProbelmaExemplo01OtaObj;

namespace ProblemaExemplo01OtaObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            X.L1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.L2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.L3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaX = X.Area();

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            Y.L1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.L2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.L3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaY = Y.Area();
            
            Console.WriteLine($"Área de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine($"Maior área: X");
            }
            else
            {
                Console.WriteLine($"Maior área: Y");
            }
        }
    }
}


