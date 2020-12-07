using System;

namespace DataEncapsulationExample
{
    class Program
    {
        static void Main(string[] args)
        {

            // [ctrl] + k + c - commeting
            // [ctrl] + k + u - un-commeting

            GiftCardAccountExample();
            
            InterestEarningAccountExample();

            //Assignment - LineOfCredit class example code   
            LineOfCreditExample();
        }


        static void  GiftCardAccountExample()
        {
            BankAccount giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "Bought coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "Bought groceries");
            string accountHistory = giftCard.GetAccountHistory();
            Console.WriteLine(accountHistory);
            giftCard.PerformMonthEndTransactions();  
            accountHistory = giftCard.GetAccountHistory();
            Console.WriteLine(accountHistory);
        }

        static void InterestEarningAccountExample()
        {
            BankAccount account  = new InterestEarningAccount("Savings Account", 100000);  
            account.MakeDeposit( 1750, DateTime.Now, "Save some money");
            account.MakeDeposit( 10000, DateTime.Now, "Save some more money");
            account.MakeWithdrawal( 1250, DateTime.Now, "Mobil bill payment");
            Console.WriteLine(account.GetAccountHistory());
            account.PerformMonthEndTransactions();  
            Console.WriteLine(account.GetAccountHistory());
        }   


        ///Assigment 
        static void  LineOfCreditExample()
        {

        }
    }
}
