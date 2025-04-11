using System.Collections.Generic;
namespace ExercicioRevisao02;
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
        // Predicate<Product> FinProdA = p => p.Name.ToLower().Contains("a");
        // var produtosComA = produtos.FindAll(FinProdA);
        // foreach(var p in produtosComA)
        // {
        //     Console.WriteLine($"{p.Name} - R$ {p.Price.ToString("f2")}");
        // }

        // Predicate<Product> lessFive = p=> p.Name.Length <= 5;
        // var prodFiveCha = produtos.FindAll(lessFive);
        // foreach(var p in prodFiveCha)
        //     Console.WriteLine(p.Name);
        
        // Predicate<Product> range = p => p.Price >=300 && p.Price <= 900;
        // var prodRange = produtos.FindAll(range);
        // foreach(var p in prodRange)
        //     Console.WriteLine($"{p.Name}: R$ {p.Price.ToString("f2")}");

        Predicate<Product> vogaDuplicada = p =>
        {
            string nome = p.Name.ToLower();
            for(int i =0; i<nome.Length-1; i++)
            {
                if("aeiou".Contains(nome[i]) && nome[i] == nome[i+1])
                {
                    return true;
                }
            }
            return false;
        };

        var prodVogDup = produtos.FindAll(vogaDuplicada);
        foreach(var p in prodVogDup)
            Console.WriteLine($"{p.Name}: R$ {p.Price.ToString("f2")}");
    }
}