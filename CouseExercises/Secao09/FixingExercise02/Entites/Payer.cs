namespace FixingExercise02.Entites;

public abstract class Payer
{
    public string Name { get; set; }
    public double AnualIncome { get; set; }

    public Payer()
    {
    }
    public Payer(string name, double anualIncome)
    {
        Name = name;
        AnualIncome = anualIncome;
    }

    public abstract  double Tax();
}
