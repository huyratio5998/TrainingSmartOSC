using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class BankAccount
    {
        public int accountID { get; set; }
        public double balance { get; set; }

        public BankAccount()
        {

        }

        public BankAccount(int accountID, double balance)
        {
            this.accountID = accountID;
            this.balance = balance;
        }


        public double balanceInquiry()
        {
            return this.balance;
        }
    }
}
