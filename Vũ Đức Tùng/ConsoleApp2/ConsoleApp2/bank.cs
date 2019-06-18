using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class bankAccount
    {
        private int accountID;
        private int balance;

        public int AccountID { get => accountID; set => accountID = value; }
        public int Balance { get => balance; set => balance = value; }

        public void balanceInquiry()
        {
            Console.WriteLine("you accountID: " + AccountID);
            Console.WriteLine("you balance: " + Balance);
        }
    }
    class currentAccount:bankAccount
    {
        public void amountWithdrawn(int amount)
        {
            if ((base.Balance - amount) < 5000)
                Console.WriteLine("tai khoan cua ban khong du");
            else base.Balance = base.Balance - amount;
        }
        public void amountDeposit(int amount)
        {
            base.Balance = base.Balance + amount;
        }
    }
    class savingsAccount : bankAccount
    {
        public void amountWithdrawn(int amount)
        {
            if ((base.Balance - amount) < 10000)
                Console.WriteLine("tai khoan cua ban khong du");
            else base.Balance = base.Balance - amount;
        }
        public void amountDeposit(int amount)
        {
            base.Balance = base.Balance + amount;
        }
    }
    //class test
    //{
    //    public static void Main(string[] args)
    //    {
    //        savingsAccount tung = new savingsAccount();
    //        tung.AccountID = 123;
    //        tung.Balance = 50000;
    //        tung.balanceInquiry();
    //        tung.amountWithdrawn(46000);
    //        tung.balanceInquiry();
    //        tung.amountDeposit(40000);
    //        tung.balanceInquiry();
    //        Console.ReadKey();
    //    }
    //}
}
