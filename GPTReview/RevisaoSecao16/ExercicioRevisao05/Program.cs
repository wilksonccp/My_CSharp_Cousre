using System.Collections.Generic;
using System.Xml;
namespace ExercicioRevisao05;
class Program
{
    static void Main(string[] args)
    {
        string pathProd = @"C:\Temp\produtos.txt";


        try
        {
            var outputProdt = File.ReadAllLines(pathProd)
                                .Select(linha => linha.Split(","))
                                .Select(campos => new Product(campos[0], campos[1], double.Parse(campos[2])))
                                .Where(product => product.Category.ToLower() == "computers")
                                .OrderBy(x => x.Price);
            
            foreach(var p in outputProdt)
            {
                Console.WriteLine($"{p.Name}, {p.Category}, {p.Price:f2}");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Erro ao ler o arquivo");
            Console.WriteLine(ex.Message);
        }

    }
}