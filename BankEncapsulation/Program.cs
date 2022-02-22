using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount userAccount = new BankAccount();

            // Enter Name
            Console.WriteLine("Please enter your first and last name: ");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("");

            while (firstName == "" || lastName == "")
            {
                Console.WriteLine("Please enter a valid name.");
                Console.Write("First Name: ");
                firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                lastName = Console.ReadLine();
            }

            Console.WriteLine("");

            // Deposit Amount
            Console.WriteLine($"Welcome, {firstName} {lastName}.");
            Console.WriteLine("");
            Console.WriteLine("Please enter the amount (in $USD) you are depositing into your account.");

            double userDeposit = double.Parse(Console.ReadLine());

            while (userDeposit < 0)
            {
                Console.WriteLine("Please enter a valid number (cannot be negative or 0).");
                userDeposit = double.Parse(Console.ReadLine());
            };

            // Deposit Confirmation
            userAccount.Deposit(userDeposit);
            userAccount.GetBalance();

            Console.WriteLine("Thank you. Have a nice day.");

        }
    }
}
