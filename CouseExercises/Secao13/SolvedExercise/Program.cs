using System.IO;
using SolvedExercise.Entities;

namespace SolvedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Enter file fill path:");
            string filePath = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] parts = sr.ReadLine().Split(' '); // Split chamado apenas uma vez
                        set.Add(new LogRecord(parts[0], DateTime.Parse(parts[1]))); // Usa o array já criado
                    }
                }
                Console.WriteLine("Total users: " + set.Count);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}