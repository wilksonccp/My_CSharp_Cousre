using System.Net.NetworkInformation;
using System.Globalization;

namespace MultCurrenctApp.Entities;

public class Products
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Products(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public static List<Products> GetProducts()
    {
        string pathOrder = @"C:\Temp\products.csv";
        List<Products> products = new List<Products>();

        using (StreamReader sr = new StreamReader(pathOrder))
        {
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                products.Add(new Products(name, price));
            }
        }
        return products;
    }
    
}
