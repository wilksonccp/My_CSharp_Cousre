using System.Globalization;
namespace FixingExercise.Entites;

public class ImportedProduct : Product
{
    public double CustomFee { get; set; }

    public ImportedProduct()
    {
    }
    public ImportedProduct(string name, double price, double coustomFee) : base(name, price)
    {
        CustomFee = coustomFee;
    }

    public double TotalPrice()
    {
        return Price + CustomFee;
    }
    public override string PriceTag()
    {
        return $"{Name} $ {TotalPrice().ToString("f2", CultureInfo.InvariantCulture)} (Coustom Fee $: {CustomFee})";
    }
}
