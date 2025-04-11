using System.Collections.Generic;
namespace ExercicioRevisao04;
class Program
{
    static void Main(string[] args)
    {
        List<Product> produtos = new List<Product>
            {
                new Product("TV", 900.00),
                new Product("Mouse", 50.00),
                new Product("Tablet", 350.00),
                new Product("HD Case", 80.90),
                new Product("Computer", 850.00),
                new Product("Monitor", 290.00)
            };
        Func<Product, string> nomMaiuscula = p => p.Name.ToUpper();
        var nomes = produtos.Select(nomMaiuscula).ToList();
        foreach(var p in nomes)
        {
            Console.WriteLine(p);
        }

        Func<Product, double> calImposto = p => p.Price * 0.12;

        var newList = produtos.Select(p => new {
            Nome = p.Name,
            Price = calImposto(p)
        });
        foreach (var p in newList)
        {
            Console.WriteLine($"{p.Nome} - Imposto: R$ {p.Price:F2}");
        }

        Func<Product, string> newTarget = p => $"[{p.Name.ToUpper()}] - R$ {p.Price:f2}";
        var target = produtos.Select(newTarget);
        foreach (var p in target)
        {
            Console.WriteLine(p);
        } 
    }
}