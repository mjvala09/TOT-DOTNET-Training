using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        private decimal Balance {  get; set; }
        public string AccountHolder { get; set; }
        public int AcountNumber { get; set; }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        public void Withdraw(decimal amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Unsufficient balance.");
            }
        }
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
