using System;
using System.Globalization;
using ExercicioFixacao01;

namespace Exercicio1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo= new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Altura= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Largura= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {retangulo.Area().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {retangulo.Perimetro().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal().ToString("f2", CultureInfo.InvariantCulture)}");
        }

    }
}


