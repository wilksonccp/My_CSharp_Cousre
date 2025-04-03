namespace DC02;
using static System.Console;

public class RealyDrunk
{
    public static void ChoiceSenteces(int drinks)
    {
        WriteLine($" MAN, Do you have {drinks} drinks?)");

        string[] senteces = File.ReadAllLines(@"C:\Temp\DrunkAnwers.txt");
        int lineCount = senteces.Length;

        if (lineCount > 0)
        {

            Random rnd = new Random();
            int randomLine = rnd.Next(0, lineCount);
            WriteLine(senteces[randomLine]);
        }
        else
        {
            WriteLine("I'm sorry, I'm out of answers");
        }

    }

}
