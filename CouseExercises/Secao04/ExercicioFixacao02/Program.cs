using System;
using System.Globalization;

namespace ExercicioFixacao02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario A = new Funcionario();

            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            A.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            A.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário {A}");
            
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double Aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.AumentasSalário(Aumento);
            
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {A}");

        }
    }
}


