using System;
using System.Collections.Generic;  
using System.Text; 

namespace DataEncapsulationExample
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
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
            if( amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be greater than zero");
            }

            PerformTransaction(amount, date, note);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
           
            CheckWithdrawal(amount);

            PerformTransaction(-amount, date, note);
        }

        public string GetAccountHistory()
        {
            AccountHistory history = new AccountHistory();  
            return history.GetAccountHistory(allTransactions);
        }
        private void PerformTransaction(decimal amount, DateTime date, string note)
        {
            Transaction t = new Transaction(amount, date, note);
            allTransactions.Add(t);
        }

        private void CheckWithdrawal(decimal amount)
        {
            if( amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be greater than zero");
            }

            if( Balance - amount <= 0 )
            {
                throw new InvalidOperationException("No sufficient funds for withdrawal");
            }
        }

    }
}
