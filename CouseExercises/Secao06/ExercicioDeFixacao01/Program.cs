using System;
using System.Globalization;
using ExercicioDeFixacao01;

namespace ExercicioDeFicacao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guests[] rooms = new Guests[10];

            int rentQtd = 1;
            Console.WriteLine("Quantos hospedes serão alocados?");
            int gusQtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < gusQtd; i++)
            {
                Console.WriteLine("Aluguel: #" + rentQtd);

                Console.Write("Nome: ");
                string nameGues = Console.ReadLine();
                Console.Write("Email: ");
                string emailGues = Console.ReadLine();

                bool roomAssigned = false;
                while (!roomAssigned)
                {
                    Console.Write("Quarto: ");
                    int roomGues;
                    while (!int.TryParse(Console.ReadLine(), out roomGues) || roomGues < 0 || roomGues > 9)
                    {
                        Console.Write("Por favor, insira um número de quarto válido (0-9): ");
                    }
                    if (rooms[roomGues] != null)
                    {
                        Console.WriteLine("Este quarto já está ocupado. Por favor, escolha outro quarto.");
                    }
                    else
                    {
                        rooms[roomGues] = new Guests(nameGues, emailGues);
                        roomAssigned = true; // Indica que um quarto foi atribuído com sucesso
                        rentQtd++;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
                }
            }
        }
    }
}


