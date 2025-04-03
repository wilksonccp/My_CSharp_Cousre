using System;
using System.Globalization;
using ExercicioResolvido01.Entites;
using ExercicioResolvido01.Entites.Enuns;


namespace ExercicioResolvido01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary:");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, salary, dept);

            Console.Write("How many contracts to this worker? ");
            int contr = int.Parse(Console.ReadLine());

            for (int i = 1; i<=contr;i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, hour, duration);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string incomeDate = Console.ReadLine();
            int month = int.Parse(incomeDate.Substring(0,2));
            int year = int.Parse(incomeDate.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {incomeDate}: {worker.Income(month, year).ToString("f2", CultureInfo.InvariantCulture)}");


        }
    }
}



