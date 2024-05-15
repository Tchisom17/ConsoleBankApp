using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApp
{
    public class AccountService
    {
        public decimal Credit(decimal amount, decimal balance)
        {
            if (amount <= 0)
            {
                throw new Exception("Account cannot be zero or less");
            }
            return balance += amount;
        }

        public decimal Debit(decimal amount, decimal balance)
        {
            if (balance < amount)
            {
                throw new Exception("Insufficient Funds!");
            }

            return balance -= amount;
        }
    }
}
