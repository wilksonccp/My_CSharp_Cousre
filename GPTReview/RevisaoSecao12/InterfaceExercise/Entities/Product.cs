using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
namespace InterfaceExercise;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public static List<Product> LoadProducts()
    {
        string pathProduct = @"C:\Users\wilks\OneDrive\Documentos\APRENDENDO A PROGRAMAR\CURSO C# COMPLETO\ExerciciosGPT\PayementExercise\Products.csv";
        List<Product> list = new List<Product>();

        using (StreamReader sr = new StreamReader(pathProduct))
        {
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }
        }
        return list;
    }
    public static List<Product> Sort(List<Product> list, int option)
    {
        if (option == 1)
        {
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
        }
        else if (option == 2)
        {
            list.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
        }
        return list;
    }

    public override string ToString()
    {
        return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}

