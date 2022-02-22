using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        // Default Constructor
        public BankAccount()
        {
        }


        // Private Field
        private double _balance = 0;


        // Public Method Deposit
        public double Deposit(double addBalance)
        {
            return (_balance += addBalance);
        }

        // Public Method GetBalance
        public void GetBalance()
        {
            Console.WriteLine($"You have successfully deposited ${ _balance } into your bank account.");
        }
    }
}
