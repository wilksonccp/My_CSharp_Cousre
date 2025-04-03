using PayementSystem.Entities;
namespace PayementSystem.Services;

public class ContractService
{
    private IPayService _payService;

    public ContractService(IPayService payService)
    {
        _payService = payService;
    }

    public List<Installment> ProcessContract(Contract contract, int months)
    {
        List<Installment> installments = new List<Installment>();
        double basicQuota = contract.TotalValue / months;

        for (int i = 1; i <= months; i++)
        {
            DateTime dueDate = contract.Date.AddMonths(i);
            double updatedQuota = _payService.CalculateInstallment(basicQuota, i);
            installments.Add(new Installment(dueDate, updatedQuota));
        }
        return installments;
    }
}
