using System;
class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("ow many characters do you want to cut the post to? ");
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out int charCut))
        {
            Console.WriteLine("Invalid number. Using default value 0.");
            charCut = 0;
        }
        Console.WriteLine("Insert the post to cut:");
        string post = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("++++++++++++++++++++++");
        Console.WriteLine();
        Console.WriteLine("HERE IS THE CUT POST:");
        Console.WriteLine(post.Cut(charCut));



    }
}