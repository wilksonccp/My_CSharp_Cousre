using System;
using System.Globalization;

namespace ExercicioFixacao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double CotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write("Quantos dólares você vai comprar? ");
            double QtdUSD = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = {Calculadora.ConvUSDBLR(QtdUSD,CotDolar).ToString("f2", CultureInfo.InvariantCulture)}");


        }
    }
}


