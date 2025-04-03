namespace InterfaceExercise;

public class UsTax : ITaxCalculator
{
    public double CalculateTax(double amount)
    {
        return amount * 0.1;
    }
}

