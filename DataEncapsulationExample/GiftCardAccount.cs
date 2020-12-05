using System; 

namespace DataEncapsulationExample
{
    public class GiftCardAccount : BankAccount
    {
        public GiftCardAccount(string name, decimal initialBalance):base(name, initialBalance)
        {
            
        }
    }
}