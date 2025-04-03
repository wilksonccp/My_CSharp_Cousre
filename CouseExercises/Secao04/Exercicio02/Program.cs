using System;
using System.Globalization;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario A = new Funcionario();
            Funcionario B = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome:");
            A.nome = Console.ReadLine();
            Console.Write("Salário:");
            A.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome:");
            B.nome = Console.ReadLine();
            Console.Write("Salário:");
            B.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medias = (B.salario+A.salario)/2.0;
            Console.WriteLine($"Salário médio: {medias.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}


