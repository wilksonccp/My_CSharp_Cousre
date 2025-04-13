using ExercicioRevisao05;
namespace ExercicioRevisao07;

class Program
{
    static void Main(string[] argms)
    {
        string path = @"C:\Temp\produtos.txt";

        var outputER07 = File.ReadAllLines(path)
            .Select(linha => linha.Split(","))
            .Select(item => new Product(item[0], item[1], double.Parse(item[2])))
            .GroupBy(cat => cat.Category);
        foreach (var grupos in outputER07)
        {
            Console.WriteLine($"Category: {grupos.Key}");
            Console.WriteLine($"    Itens Total: {grupos.Count()}");
            Console.WriteLine($"    Total value for group: {grupos.Sum(p => p.Price):f2}");

            int order = 1;
            foreach (var produtos in grupos)
            {
                Console.WriteLine($"       #{order} - {produtos.Name} R$ {produtos.Price:f2} ");
                order++;
            }
        }
    }
}