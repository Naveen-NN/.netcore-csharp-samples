using System; 

namespace DataEncapsulationExample
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance): base(name, initialBalance)
        {
            
        }

        public override void PerformMonthEndTransactions()
        {
            if( Balance > 500m)
            {
                var intereset =  Balance * 0.05m;
                MakeDeposit(intereset, DateTime.Now, "apply monthly interest");
            }
        }
    }
}