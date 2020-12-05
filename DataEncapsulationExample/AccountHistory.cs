using System.Collections.Generic;  
using System.Text;

namespace DataEncapsulationExample
{
    public class AccountHistory : IAccountHistory
    {
        public string GetAccountHistory(List<Transaction> allTransactions)
        {
            StringBuilder report = new StringBuilder(); 
        
            decimal balance = 0;  
        
            report.Append("Date\t\tAmount\tBalance\tNote\n");
        
            foreach(Transaction transaction in allTransactions)
            {
                balance += transaction.Amount;   
                report .Append($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Note}\n");
            }

            return report.ToString();
        }
    }
}