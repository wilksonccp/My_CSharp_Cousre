using System;
using System.Globalization;
using static System.Console;

namespace GPTHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bem-vindo ao GPT Hotel!");
            WriteLine("Digite o nome do hóspede: ");
            string gest = ReadLine();
            WriteLine("Digite o número do quarto: ");
            if (!int.TryParse(ReadLine(), out int room))
            {
                WriteLine("Erro: O número do quarto deve ser um número inteiro.");
                return;
            }
            WriteLine("Digite a data de check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.ParseExact(ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            WriteLine("Digite a data de check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.ParseExact(ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            try
            {
                Reservation reservation = new Reservation(gest, room, checkIn, checkOut);
                WriteLine(reservation);
            }
            catch (DomainException e)
            {
                WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                WriteLine("Erro: Formato de data inválido. Use o formato dd/MM/yyyy.");
            }
            catch (Exception e)
            {
                WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}


