using MultCurrenctApp.Interfaces;


public abstract class BaseCurrencyConverter : ICurrencyConverter
{
    private readonly double _exchangeRate;

    protected BaseCurrencyConverter(double exchangeRate)
    {
        _exchangeRate = exchangeRate;
    }

    public double Convert(double amount)
    {
        return amount / _exchangeRate; // Sempre divide pelo câmbio
    }
}

