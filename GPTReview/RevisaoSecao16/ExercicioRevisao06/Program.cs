using System.Xml;
using ExercicioRevisao05;
namespace ExercicioRevisao06;
class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Temp\produtos.txt";

        try
        {
            var outputProdt02 = File.ReadLines(path)
                .Select(linha => linha.Split(","))
                .Select(prod => new Product(prod[0], prod[1], double.Parse(prod[2])))
                .Where(product => product.Category.ToLower() == "tools")
                .OrderBy(x => x.Name);

            foreach(var p in outputProdt02)
            {
                Console.WriteLine(p.Name + " , " + p.Price.ToString("f2"));
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Erro ao ler o arquivo");
            Console.WriteLine(ex.Message);
        }
    }
}