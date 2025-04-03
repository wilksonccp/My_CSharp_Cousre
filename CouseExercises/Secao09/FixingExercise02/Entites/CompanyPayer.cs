using System.Globalization;
namespace FixingExercise02.Entites;

public class CompanyPayer : Payer
{
    public int EmployeeNumber { get; set; }

    public CompanyPayer()
    {
    }
    public CompanyPayer(string nome, double anualIncome, int employeeNumber) : base(nome, anualIncome)
    {
        EmployeeNumber = employeeNumber;
    }
    public override double Tax()
    {
        double tax = 0;
        if(EmployeeNumber <= 10)
        {
            tax = AnualIncome * 0.16;
        }
        else
        {
            tax = AnualIncome * 0.14;
        }
        return tax;
    }
    public override string ToString()
    {
        return $"{Name}: R$ {Tax().ToString("f2", CultureInfo.InvariantCulture)}";
    }

}
