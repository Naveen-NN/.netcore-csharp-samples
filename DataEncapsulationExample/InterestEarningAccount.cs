using System; 

namespace DataEncapsulationExample
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance): base(name, initialBalance)
        {
            
        }
    }
}