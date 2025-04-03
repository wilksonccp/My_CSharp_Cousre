namespace PayementSystem.Services
{
    public interface IPayService
    {
        double CalculateInstallment(double amount, int installmentsNumber);
    }
}

