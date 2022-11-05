using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module4.Models
{
    public class CheckingAccount
    {
        public CheckingAccount(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public int AccountNumber { get; set; }
        private decimal Balance;
        public void WithDraw(decimal value)
        {
            if(Balance >= value)
            {
                Balance -= value;
                Console.WriteLine($"${value} was withdrawn. Balance remaining: ${Balance}");
            }
            else
            {
                Console.WriteLine("Value for withdraw is bigger than the balance.");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance remaining: ${Balance}");
        }
    }
}