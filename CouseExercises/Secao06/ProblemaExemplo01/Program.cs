using System;
using System.Globalization;

namespace ProblemaExemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altSum = 0;
            Console.Write("Quantas alturas serão inseridas: ");
            int altQtd = int.Parse(Console.ReadLine());
            double[] alt = new double[altQtd];
            for (int i = 0; i < altQtd; i++)
            {
                alt[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < altQtd; i++)
            {
                altSum += alt[i];
            }
            double aver = altSum / altQtd;
            Console.Write("AVERGE HEIGHT = " + aver.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


