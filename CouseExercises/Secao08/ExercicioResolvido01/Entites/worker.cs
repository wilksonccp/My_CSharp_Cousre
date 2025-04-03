using System.Diagnostics;
using ExercicioResolvido01.Entites.Enuns;
namespace ExercicioResolvido01.Entites;

public class Worker
{
    public string Name { get; set; }   
    public WorkerLevel Level { get; set; }
    public double Salary { get; set; }
    public Departament Departament{ get; set; }
    public List<HourContract> Contracts { get; set; } = new List<HourContract>();

    public Worker()
    {
    }
    public Worker(string name, WorkerLevel level, double salary, Departament departament)
    {
        Name = name;
        Level = level;
        Salary = salary;
        Departament = departament;
    }

    public void AddContract(HourContract contract)
    {
        Contracts.Add(contract);
    }
    public void RemoveContract(HourContract contract)
    {
        Contracts.Remove(contract);
    }
    public double Income(int year, int month)
    {
        double sum = Salary;
        foreach(HourContract contract in Contracts)
        {
            if(contract.Date.Year == year && contract.Date.Month == month)
            {
                sum += contract.TotalValue();
            }
        }
        return sum;
    }
}