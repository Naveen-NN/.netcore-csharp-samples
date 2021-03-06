using System; 

namespace DataEncapsulationExample
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance):base(name, initialBalance)
        {
            
        }

        public override void PerformMonthEndTransactions()
        {
            if(Balance < 0)
            {
                var interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charged monthy interest");
            }
        }
    }
}