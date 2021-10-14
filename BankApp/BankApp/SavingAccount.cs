using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class SavingAccount : IAccount
    {
        public void printAccountData()
        {
            Console.WriteLine("Saving account data");
        }
    }
}
