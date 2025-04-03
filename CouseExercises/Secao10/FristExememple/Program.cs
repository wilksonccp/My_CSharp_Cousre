using System;
using System.Globalization;
using FristExememple.Entities;
using FristExememple.Entities.Exeptions;

namespace FristExememple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
            Console.WriteLine("Enter the room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation:");
            Console.WriteLine("Enter the check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
            }
            catch(DomainExeption e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}

