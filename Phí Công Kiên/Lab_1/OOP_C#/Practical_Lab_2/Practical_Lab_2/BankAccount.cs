using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_2
{
    class BankAccount
    {
        public int accountID { get; set; }
        public double balance { get; set; }

        public BankAccount() { }

        public double balanceInquiry()
        {
            return this.balance;
        }
    }
}
