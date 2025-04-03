namespace InterfaceExercise;

public class BRTax : ITaxCalculator
{
    public double CalculateTax(double amount)
    {
        return amount * 0.15;
    }
}
