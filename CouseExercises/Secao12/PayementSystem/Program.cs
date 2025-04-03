using PayementSystem.Entities;
using PayementSystem.Services;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter contract data\nNumber: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Contract value: ");
        double totalValue = double.Parse(Console.ReadLine());
        Console.Write("Enter number of installments: ");
        int months = int.Parse(Console.ReadLine());

        Contract contract = new Contract(number, date, totalValue);
        ContractService contractService = new ContractService(new PayPalService());

        List<Installment> installments = contractService.ProcessContract(contract, months);

        Console.WriteLine("Installments:");
        foreach (Installment installment in installments)
        {
            Console.WriteLine(installment);
        }
    }
}