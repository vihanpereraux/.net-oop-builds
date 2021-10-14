using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class CurrentAccount : IAccount
    {
        public void printAccountData()
        {
            Console.WriteLine("Current account data.");
        }
    }
}
