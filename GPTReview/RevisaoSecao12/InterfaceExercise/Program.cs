using System.Globalization;
namespace InterfaceExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMediaPlayer mp3Player = new Mp3Player();
            IMediaPlayer videoPlayer = new VideoPlayer();
            IMediaPlayer dvdPlayer = new DvdPlayer();

            Console.WriteLine("       FRIST EXERCISE       ");
            mp3Player.Play();
            mp3Player.Stop();
            Console.WriteLine("----------------------------------");
            videoPlayer.Play();
            videoPlayer.Stop();
            Console.WriteLine("----------------------------------");
            dvdPlayer.Play();
            dvdPlayer.Stop();
            Console.WriteLine();
            Console.WriteLine("       SECOND EXERCISE       ");
            ITaxCalculator brTax = new BRTax();
            ITaxCalculator usTax = new UsTax();

            Console.WriteLine("How much is your buy?");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Choice your country: BR or US");
            string country = Console.ReadLine();

            while (country != "BR" && country != "US")
            {
                Console.WriteLine("Invalid country, choice your country: BR or US");
                country = Console.ReadLine().ToUpper();
            }
            if (country == "BR")
            {
                Console.WriteLine($"The tax is: {brTax.CalculateTax(amount).ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            }
            else if (country == "US")
            {
                Console.WriteLine($"The tax is: {usTax.CalculateTax(amount).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            }
            Console.WriteLine();
            Console.WriteLine("       THIRD EXERCISE       ");
            Console.WriteLine("==============================");

            Console.WriteLine("Aperte enter para buscar a lista");
            Console.ReadLine();

            List<Product> list = Product.LoadProducts();
            Console.WriteLine("A lista de produtos está disponível:");
            Console.WriteLine("Aperte enter para ordenar a lista");
            Console.ReadLine();

            Console.WriteLine("Escolha o critério de ordenação:");
            Console.WriteLine("1 - Ordenar por Nome");
            Console.WriteLine("2 - Ordenar por Preço");
            Console.Write("Digite a opção desejada: ");
            if (int.TryParse(Console.ReadLine(), out int option) && (option == 1 || option == 2))
            {
                list = Product.Sort(list, option); // ✅ Ordenação sem instanciar Product

                Console.WriteLine("\nProdutos ordenados:");
                foreach (var p in list)
                {
                    Console.WriteLine(p);
                }
            }
            else
            {
                Console.WriteLine("\nOpção inválida! Exibindo lista sem ordenação.");
            }
            Console.ReadLine();
        }
    }
}