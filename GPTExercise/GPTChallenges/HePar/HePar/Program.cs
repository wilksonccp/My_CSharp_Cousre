using System;
using System.Globalization;

namespace ExercicioHePar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor insira um número qualquer");
            Console.Write("Ou '0' para sair: ");

            while (true)
            {
                string num = Console.ReadLine();
                Console.Clear();
                if (num.Trim().ToLower() == "zero" || num == "0")
                {
                    break;
                }

                if (int.TryParse(num, out int num))
                {
                    if (num % 2 != 0)
                    {
                        Console.WriteLine($" Você digitou {num} e ele é PAR");
                    }
                    else
                    {
                        Console.WriteLine($" Você digitou {num} e ele é IMPAR");
                    }
                }
                Console.WriteLine("quer continuar?");
                Console.Write("É só digitar outro número, ou 'zero' para sair: ");
                num = double.Parse(Console.ReadLine());
                else
                {
                    Console.WriteLine("Desculpe, esse programa é muito simples, só aceita NÚMEROS INTEIROS");
                    Console.Write("Por gentileza insira um NÚMERO INTEIRO ou 'zero' para sair: ");
                    num = double.Parse(Console.ReadLine());
                    Console.Clear();
                }
                Console.WriteLine("Obrigado :)");


            }
            Console.Write("Obrigado por usar essse programa:");

        }
    }
}


