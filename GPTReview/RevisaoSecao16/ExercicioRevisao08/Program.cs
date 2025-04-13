using ExercicioRevisao05;
namespace ExercicioRevisao08;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Temp\funcionarios.txt";

        var outputFunc = File.ReadLines(path)
            .Select(line => line.Split(","))
            .Select(empl => new Employee(empl[0], empl[1], empl[2], double.Parse(empl[3])))
            .GroupBy(employee => employee.Sector);

            foreach(var grupos in outputFunc)
            {
                Console.WriteLine($"Departemento: {grupos.Key}");
                Console.WriteLine($"Média salarial: R$ {grupos.Average(p => p.Salary):f2}");

                foreach (var employee in grupos)
                {
                    Console.WriteLine($"    - {employee.Name} (R$ {employee.Salary:f2})");
                }
            }
    }
}
