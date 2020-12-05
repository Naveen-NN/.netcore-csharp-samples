using System;

namespace DataEncapsulationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account  = new BankAccount("Vivaan", 100000);
            
            account.MakeDeposit(25000, DateTime.Now, "Savings every month");
            account.MakeDeposit(1500, DateTime.Now, "Savings every month");
            account.MakeWithdrawal(34500, DateTime.Now, "Person use");

            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine(account.GetAccountHistory());
        }

    }
}
