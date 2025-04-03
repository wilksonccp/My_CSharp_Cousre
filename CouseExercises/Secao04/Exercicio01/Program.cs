using System;
using System.Globalization;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            A.nome = Console.ReadLine();
            Console.Write("Idade:");
            A.idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            B.nome = Console.ReadLine();
            Console.Write("Idade:");
            B.idade = int.Parse(Console.ReadLine());

            if(A.idade>B.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {A.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {B.nome}");
            }
        }
    }
}


