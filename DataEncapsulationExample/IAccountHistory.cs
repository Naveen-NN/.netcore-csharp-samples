using System; 
using System.Collections.Generic;  

namespace DataEncapsulationExample
{
    public interface IAccountHistory
    {
        string GetAccountHistory(List<Transaction> allTransactions);
    }
}