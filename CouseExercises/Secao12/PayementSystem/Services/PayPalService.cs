namespace PayementSystem.Services;

public class PayPalService : IPayService
{
    public double CalculateInstallment(double amount, int installmentsNumber)
    {
        double interest = amount * 0.01 * installmentsNumber;
        double fee = (amount + interest) * 0.02;
        return amount + interest + fee;
    }
}
