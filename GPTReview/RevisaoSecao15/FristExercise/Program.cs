namespace FristExercise
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the post:");
            string post = Console.ReadLine() ?? "0";
            Console.WriteLine("How many characters this post shoud has?");
            string imput = Console.ReadLine() ?? "0";

            if (!int.TryParse(imput, out int numberCut))
            {
                Console.WriteLine("Invalid number. Using default value 0.");
                numberCut = 0;
            }
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine(post.Summary(numberCut));
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("NOW THE LIST EXERCISE");
            Console.WriteLine("=======================");
            
            Console.WriteLine("Insert the list of strings, please:");
            string inputList = Console.ReadLine() ?? string.Empty;
            List<string> list = inputList.Split(",").ToList();
            list.RemoveEmpty();
            List<string> TratList = list;
            Console.Write("[");
            for(int i = 0; i < TratList.Count; i++)
            {
                if((i+1) == TratList.Count)
                {
                    Console.Write(TratList[i]);
                }
                else
                {
                    Console.Write(TratList[i] + ", ");
                }
            }
            Console.Write("]");

        }
    }
}