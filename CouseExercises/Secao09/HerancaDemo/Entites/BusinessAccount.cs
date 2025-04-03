namespace HerancaDemo.Entites;

public class BusinessAccount : Account
{
    public double LoanLimit { get; set; }

    public BusinessAccount()
    {
    }
    public BusinessAccount(int acNumber, string holder, double balance, double loanLimit)
        : base(acNumber, holder, balance)
    {
        LoanLimit = loanLimit;
    }

    public void Loan(double amount)
    {
        if(LoanLimit <= amount)
        {
            LoanLimit -= amount;
            Balance += amount;
        }
        else
        {
            Console.WriteLine("Loan Limit is done");
        }
    }
}
