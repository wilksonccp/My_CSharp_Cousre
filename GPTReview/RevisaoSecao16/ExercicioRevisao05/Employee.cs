using System.ComponentModel.DataAnnotations;

namespace ExercicioRevisao05;

public class Employee
{
    public string  Name { get; set; }
    public string  Email { get; set; }
    public string Sector { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string email, string sector, double salary)
    {
        Name = name;
        Email = email;
        Sector = sector;
        Salary = salary;
    }
}
