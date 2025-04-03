using System;
using System.Globalization;
using System.IO;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathPr = @"C:\Temp\products.csv";
            string pathSum = @"C:\Temp\out\summary.csv";
            string pathNd = @"C:\Temp\out";
            Directory.CreateDirectory(pathNd);
            try
            {
                using (StreamReader sr = File.OpenText(pathPr))
                using (StreamWriter sw = File.AppendText(pathSum))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);
                        double total = price * quantity;

                        sw.WriteLine(name + "," + total.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
                Console.WriteLine("Arquivo processado com sucesso!");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}


