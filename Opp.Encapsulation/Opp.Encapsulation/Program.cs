using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp.Encapsulation
{
    public class BankAccount
    {
        private decimal balance; 

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount; 
                Console.WriteLine($"Deposited: {amount:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount; 
                Console.WriteLine($"Withdrawn: {amount:C}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(1000);
            Console.WriteLine($"Current Balance: {account.Balance:C}");

            account.Withdraw(560);
            Console.WriteLine($"Current Balance: {account.Balance:C}");

            account.Withdraw(500);

            Console.WriteLine($"Account Balance: {account.Balance:C}");
            Console.ReadKey();
        }
    }
}
