using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class BankAccount
    {
        private int accountID;
        private double balance;

        public int AccountID { get => accountID; set => accountID = value; }
        public double Balance { get => balance; set => balance = value; }
        public double balanceInquiry()
        {
            return balance;
        }           
    }
    class CurrentAccount : BankAccount
    {
        public CurrentAccount(int AccountID, double Balance)
        {
            base.AccountID = AccountID;
            base.Balance = Balance;
        }
        public void amountWithdrawn(double amount)
        {
            if (this.Balance-amount >= 5000)
            {
                this.Balance -= amount;                
            }
            else
            {
                Console.WriteLine("minimum balance should not decrease Rs.5000");
                return;
            }
        }
        public void amountDeposit(double amount)
        {
            this.Balance += amount;
        }
    }
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(int AccountID, double Balance)
        {
            base.AccountID = AccountID;
            base.Balance = Balance;
        }
        public void amountWithdrawn(double amount)
        {
            if (this.Balance-amount >= 10000)
            {
                this.Balance -= amount;                
            }
            else
            {
                Console.WriteLine("minimum balance should not decrease Rs.10000");
                return;
            }            
        }
        public void amountDeposit(double amount)
        {
            this.Balance += amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount();
            double balance=bank.balanceInquiry();
            Console.WriteLine("current money: "+balance);
            CurrentAccount CA = new CurrentAccount(1000, 500000);
            CA.amountWithdrawn(200000);
            CA.amountDeposit(500000);
            balance = CA.balanceInquiry();
            Console.WriteLine("money: "+balance);
            SavingsAccount SA = new SavingsAccount(1001, 500000);
            SA.amountWithdrawn(450000);
            SA.amountDeposit(10000);
            balance = SA.balanceInquiry();
            Console.WriteLine("money: " + balance);
            
        }
    }
}
