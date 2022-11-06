using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module4.Models
{
    public abstract class Account
    {
        protected decimal Balance;

        public abstract void Credit(decimal value);

        public void ShowBalance()
        {
            Console.WriteLine("Balance remaining: " + Balance);
        }
    }
}