using System;
using System.Collections.Generic;  
namespace DataEncapsulationExample
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        //Read only property 
        public string Number { get; }
        
        //set the value and we can get the value  
        public string Owner { get; set;}

        public decimal Balance {
            get
            {
                decimal balance  = 0;  
                
                foreach (var transaction in allTransactions)
                {
                     balance += transaction.Amount;   
                }

                return balance;
            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();  

        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;  
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            PerformTransaction(amount, date, note);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            PerformTransaction(-amount, date, note);
        }

        private void PerformTransaction(decimal amount, DateTime date, string note)
        {
            Transaction t = new Transaction(amount, date, note);
            allTransactions.Add(t);
        }

    }
}