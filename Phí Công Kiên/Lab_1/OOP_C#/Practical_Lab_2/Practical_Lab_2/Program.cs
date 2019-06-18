using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount currentAccount = new CurrentAccount()
            {
                accountID = 1,
                balance = 9000000
            };
            Console.WriteLine("Account ID: {0} | {1}", currentAccount.accountID, currentAccount.balanceInquiry());
            currentAccount.amountWithdrawn(1000000);
            Console.WriteLine("Account ID: {0} | {1}", currentAccount.accountID, currentAccount.balanceInquiry());
            currentAccount.amountDeposit(2000000);
            Console.WriteLine("Account ID: {0} | {1}", currentAccount.accountID, currentAccount.balanceInquiry());

            Console.WriteLine("\n------------------------------------------------------------------------\n");

            SavingAccount savingAccount = new SavingAccount()
            {
                accountID = 2,
                balance = 99999999
            };

            Console.WriteLine("Account ID: {0} | {1}", savingAccount.accountID, savingAccount.balanceInquiry());
            savingAccount.amountWithdrawn(1500000);
            Console.WriteLine("Account ID: {0} | {1}", savingAccount.accountID, savingAccount.balanceInquiry());
            savingAccount.amountDeposit(222222);
            Console.WriteLine("Account ID: {0} | {1}", savingAccount.accountID, savingAccount.balanceInquiry());

            Console.ReadKey();
        }
    }
}
