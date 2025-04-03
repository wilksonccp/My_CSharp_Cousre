namespace HerancaDemo.Entites;

public class Account
{
    public int AcNumber { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }

    public Account()
    {
    }
    public Account(int acNumber, string holder, double balance)
    {
        AcNumber = acNumber;
        Holder = holder;
        Balance = balance;
    }
    public void Whitdraw(double amount)
    {
        Balance -= amount;
    }
    public void Deposot(double amount)
    {
        Balance -= amount;
    }
}
