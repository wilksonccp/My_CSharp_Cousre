namespace InterfaceExercise;

public class ProductNameCompare : IComparer<Product>
{
    public int Compare(Product p1, Product p2)
    {
        return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    }
}

