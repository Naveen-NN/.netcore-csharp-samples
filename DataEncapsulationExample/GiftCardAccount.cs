using System; 

namespace DataEncapsulationExample
{
    public class GiftCardAccount : BankAccount // IS A relation
    {
        private decimal _monthyDeposit = 0m;
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0)
        :base(name, initialBalance)
        {
            _monthyDeposit = monthlyDeposit;
        }

        public override void PerformMonthEndTransactions()
        {
            if(_monthyDeposit != 0)
            {
                MakeDeposit(_monthyDeposit, DateTime.Now, "Add monthlt deposit");
            }
        }
    }
}