namespace InterfaceExercise;

public class ProducPriceComparer : IComparer<Product>
{
    public int Compare(Product p1, Product p2)
    {
        return p1.Price.CompareTo(p2.Price);
    }
}
