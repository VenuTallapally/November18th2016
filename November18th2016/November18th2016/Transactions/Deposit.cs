using System;
using November18th2016.interfaces;

namespace November18th2016.Transactions
{
    public class Deposit : ITransaction
    {
        public bool MakeTransaction()
        {
            Console.WriteLine("You can do Deposit : True");
            return true;
        }

        public void FailTransaction()
        {
            Console.WriteLine("You can't do Deposit : False");
        }
    }
}