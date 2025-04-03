using System;
using System.IO;
using System.Collections.Generic;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\in.txt";
            Dictionary<string, int> votes = new Dictionary<string, int>();

            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("Arquivo não encontrado.");
                    return;
                }

                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    string name = fields[0];
                    int count = int.Parse(fields[1]);

                    if (votes.ContainsKey(name))
                        votes[name] += count;
                    else
                        votes[name] = count;
                }

                foreach (var item in votes)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
