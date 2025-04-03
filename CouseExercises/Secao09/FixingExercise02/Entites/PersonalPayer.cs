
using System.Globalization;
namespace FixingExercise02.Entites;

public class PersonalPayer : Payer
{
    public double HealtExpenditure { get; set; }

    public PersonalPayer(string name, double AnualIncome, double healtExpenditure) : base(name, AnualIncome)
    {
        HealtExpenditure = healtExpenditure;
    }
    public override double Tax()
    {
        double tax = 0;
        if(AnualIncome <20000.00)
        {
            tax = AnualIncome * 0.15;
        }
        else
        {
            tax = AnualIncome * 0.25;
        }
        tax-= HealtExpenditure * 0.5;

        return tax;
    }
    public override string ToString()
    {
        return $"{Name}: R$ {Tax().ToString("f2", CultureInfo.InvariantCulture)}";
    }

}
