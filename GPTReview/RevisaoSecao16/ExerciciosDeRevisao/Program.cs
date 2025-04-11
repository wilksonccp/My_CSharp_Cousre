using ExerciciosDeRevisao.Entities;
using System.Linq;
using System.Runtime.Serialization;
using System.Globalization;

namespace ExerciciosDeRevisao;

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

        produtos.Sort((p1,p2) => p1.Name.CompareTo(p2.Name));

        foreach(var p in produtos)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("=============================================\n");

        //produtos.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));

        foreach(var p in produtos)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("=============================================\n");

        produtos.FindAll(p => p.Name.StartsWith("M"))
                .ForEach(p => Console.WriteLine(p.Name));

        Console.WriteLine("=============================================\n");

        produtos.FindAll(p => p.Price < 500)
                .ForEach(p => Console.WriteLine(p.Name));

        Console.WriteLine("=============================================\n");

        produtos.ForEach(p => Console.WriteLine($"{p.Name} - {(p.Price *= 1.10).ToString("f2")}"));
    }
}