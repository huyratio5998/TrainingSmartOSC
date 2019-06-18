using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_2
{
    class CurrentAccount : BankAccount
    {
        public CurrentAccount() { }

        public CurrentAccount(int accountID, double blance)
        {
            base.accountID = accountID;
            base.balance = balance;
        }

        public void amountWithdrawn(double amount)
        {
            if (balanceInquiry() <= 5000)
            {
                Console.WriteLine("Balance is not enough!");
                return;
            }
            else if ((balanceInquiry() - amount) <= 5000)
            {
                Console.WriteLine("Balance is not enough!");
                return;
            }
            else
            {
                double b = balanceInquiry() - amount;
                base.balance = b;
                Console.WriteLine($"Successfully withdraw the amount of {amount} VND!");
            }
        }

        public void amountDeposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("The deposit amount must be greater than 0 VND!");
                return;
            }
            double a = balanceInquiry() + amount;
            base.balance = a;
            Console.WriteLine($"successfully send {amount} VND!");
        }
    }
}
