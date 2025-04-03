using System;
using System.Globalization;

namespace ProblemaExemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triangulo X:");
            double L1X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double L2X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double L3X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pX = (L1X + L2X + L3X) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - L1X) * (pX - L2X) * (pX - L3X));

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            double L1Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double L2Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double L3Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pY = (L1Y + L2Y + L3Y) / 2.0;
            double areaY = Math.Sqrt(pY * (pY - L1Y) * (pY - L2Y) * (pY - L3Y));

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


