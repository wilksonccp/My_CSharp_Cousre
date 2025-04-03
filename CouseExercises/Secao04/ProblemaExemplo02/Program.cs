using System;
using System.Globalization;

namespace ProblemaExemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p.Nome}, R$ {p.Preco}, {p.Quantidade} unidades, TOTAL R$ {p.ValorTotalEmEstoque()}");
            Console.WriteLine(p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
            int Qtd = int.Parse(Console.ReadLine());
            p.AdicionaProduto(Qtd);
            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser removidos ao estoque:");
            Qtd = int.Parse(Console.ReadLine());
            p.RemoveProduto(Qtd);
            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();



            
        }
    }
}


