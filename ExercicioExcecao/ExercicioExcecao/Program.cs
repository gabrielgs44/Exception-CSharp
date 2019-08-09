using ExercicioExcecao.Entities;
using ExercicioExcecao.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExercicioExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, limit, balance);
            Console.WriteLine();
            try
            {
                Console.Write("Enter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
