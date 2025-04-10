using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> nomes = new List<string>
        {
            "Ana", "Pedro", "Amanda", "Marcos", "Bianca", "Mário", "Alice"
        };

        Predicate<string> comecaComA = nome => nome.StartsWith("A");
        var nomesComA = nomes.FindAll(comecaComA);
        Console.WriteLine("Nomes que começam com A: ");
        nomesComA.ForEach(Console.WriteLine);
    }
}