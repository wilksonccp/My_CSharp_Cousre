using System;
using System.Globalization;
using ExercicioFixacao03;

namespace ExercicioFicacao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            A.Nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            
            Console.WriteLine($"NOTA FINAL: {A.NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}");
            if (A.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {A.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }

        }
    }
}


