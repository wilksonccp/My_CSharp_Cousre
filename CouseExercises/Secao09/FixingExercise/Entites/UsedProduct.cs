using System.Globalization;

namespace FixingExercise.Entites;

public class UsedProduct : Product
{
    public DateTime ManufacturedDate { get; set; }

    public UsedProduct()
    {
    }
    public UsedProduct(string name, double price,DateTime manufacturedDate) : base(name, price)
    {
        ManufacturedDate = manufacturedDate;
    }

    public override string PriceTag()
    {
        return $"{Name} (used) $ {Price.ToString("f2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufacturedDate.ToString("dd/MM/yyyy")})";
    }
}
