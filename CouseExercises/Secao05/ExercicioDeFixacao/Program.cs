using System;
using System.Globalization;
using ExercicioDeFixacao;

namespace ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interacoes inicio = new Interacoes();
            string interacaoInicial = inicio.InteracaoInicial01();
            string interacaoInicialerro = inicio.InteracaoInicialErro();
            string primeiroMenu = inicio.PrimeiroMenu();
            string menuDeOperacoes = inicio.MenuDeOperacoes();

            Sobre a = new Sobre();
            Conta nova = new Conta();
            double valor = 0;
            int OpcaoDois;
            Console.WriteLine(interacaoInicial);
            int OpcaoInicialInt = int.Parse(Console.ReadLine());


            while (OpcaoInicialInt != 1 && OpcaoInicialInt != 2)
            {
                Console.WriteLine(interacaoInicialerro);
                OpcaoInicialInt = int.Parse(Console.ReadLine());
            }
            while (OpcaoInicialInt == 1)
            {
                Console.WriteLine(a);
                Console.WriteLine();
                Console.WriteLine(primeiroMenu);
                OpcaoInicialInt = int.Parse(Console.ReadLine());
            }
            if (OpcaoInicialInt == 2)
            {
                Console.WriteLine(menuDeOperacoes);
                OpcaoDois = int.Parse(Console.ReadLine());

                while (OpcaoDois > 1 && OpcaoDois < 3)
                {

                    OpcaoDois = int.Parse(Console.ReadLine());

                }
                if (OpcaoDois == 1)
                {
                    Console.Write("Insira o numero da conta:");
                    int numero = int.Parse(Console.ReadLine());
                    Console.Write("Insira o nome do titular da conta:");
                    string titular = Console.ReadLine();
                    Console.Write("Haverá deposito inicial? (S/N)");
                    char depositoinicial = char.Parse(Console.ReadLine());
                    while(depositoinicial != 'S' && depositoinicial !='N')
                    {
                        Console.WriteLine("Insira um valor correto para opção de depósito:");
                        Console.WriteLine("S para sim");
                        Console.WriteLine("N para não");
                        Console.WriteLine("ATENÇÃO: use caixa alta (letra maiuscula)");
                        depositoinicial = char.Parse(Console.ReadLine());
                    }
                    if (depositoinicial == 'S')
                    {
                        Console.Write("Insira o valor do depósito inicial:");
                        double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        nova = new Conta(titular,numero,saldo);
                    }
                    else
                    {
                        nova = new Conta(titular,numero);
                    }
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(nova);
                    Console.WriteLine();
                    Console.Write("Entre com um valor para depósito:");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    nova.Deposito(valor);
                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine(nova);
                    Console.WriteLine();
                    Console.Write("Entre com um valor para saque:");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    nova.Saque(valor);
                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine(nova);
                }
            }

        }
    }
}


