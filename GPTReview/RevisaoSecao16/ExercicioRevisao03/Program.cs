using System.Collections.Generic;
namespace ExercicioRevisao03;
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
        List<Product> produtosAtual = new List<Product>
            {
                new Product("TV", 900.00),
                new Product("Mouse", 50.00),
                new Product("Tablet", 350.00),
                new Product("HD Case", 80.90),
                new Product("Computer", 850.00),
                new Product("Monitor", 290.00)
            };
        
        Action<Product> finalOutput = p => Console.WriteLine($"Produto: {p.Name} - R$ {p.Price:f2}");
        Action<Product> logOutput = p => Console.WriteLine($"[LOG] Produto abaixo de R$300.00: {p.Name} - R$ {p.Price:f2}");
        Predicate<Product> find300 = p => p.Price > 300;
        Action<Product> prodPromo = p => 
        {
            if(p.Price > 500)
            {
                p.Price *= 0.85;
            }
        };
        produtos.ForEach(prodPromo);
        produtos.ForEach(finalOutput);
        produtos = produtosAtual;
        Console.WriteLine("\n====================================");
        produtos.FindAll(find300).ForEach(finalOutput);

    }
}