﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SavingAccount : BankAccount
    {
        public SavingAccount()
        {

        }
        public SavingAccount(int accountID, double balance)
        {
            base.accountID = accountID;
            base.balance = balance;
        }

        public void amountWithdrawn(double amount)
        {
            if (balance < 10000)
            {
                Console.WriteLine("Tai khoan cua ban khong du");
            }
            if ((balance - amount) < 10000)
            {
                Console.WriteLine("Tai khoan cua ban khong du");
            }
            else
            {
                double inquiry;

                inquiry = balanceInquiry() - amount;
                this.balance = inquiry;

                Console.WriteLine("Ban da rut {0}", amount);
                Console.WriteLine("So tien hien tai la: {0}", this.balance);

            }
        }

        public void amountDeposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("So tien gui vao khong dung ! ");
            }
            else
            {
                double inquiry;

                inquiry = balanceInquiry() + amount;
                this.balance = inquiry;

                Console.WriteLine("Ban da gui {0}", amount);
                Console.WriteLine("So tien hien tai la: {0}", this.balance);
            }
        }
    }
}
