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
    //        int m;
    //        string s="";
    //        do
    //        {
    //            Console.WriteLine("nhap so tien can rut khach hang");
                
    //            m = Convert.ToInt32(Console.ReadLine());
    //            if (m <= 0)
    //            {
    //                Console.WriteLine("ban nhap sai gia tri");
    //                continue;
    //            }
    //            tung.amountWithdrawn(m);
    //            tung.balanceInquiry();
               
    //            Console.WriteLine("ban muon nhap nua khong Y/N");
    //            s = Convert.ToString(Console.ReadLine());
    //        } while((s!="N")&&(s!="n"));
    //        Console.ReadKey();
    //    }
    //}
}
