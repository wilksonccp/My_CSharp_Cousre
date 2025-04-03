using System;
using System.Globalization;
using FristExercise.Entities;
using static System.Console;
using FristExercise.Entities.Exceptions;

namespace FristExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter account data");
            Write("Number: ");
            int number = int.Parse(ReadLine());
            Write("Holder: ");
            string holder = ReadLine();
            Write("Initial balance: ");
            double balance = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            WriteLine();
            Write("Enter amount for withdraw: ");
            double amount = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amount);
                WriteLine(account);
            }
            catch (DomainException e)
            {
                WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException)
            {
                WriteLine("Input error: Please enter a valid number.");
            }
            catch (Exception e)
            {
                WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}


