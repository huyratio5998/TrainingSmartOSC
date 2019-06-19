using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double draw;
            double deposit;

            //saving acount
            SavingAccount s = new SavingAccount(001,80000);

            Console.WriteLine("Nhap WithDraw: ");
            draw = Convert.ToInt16(Console.ReadLine());

            s.amountWithdrawn(draw);

            Console.WriteLine("nhap Deposit: ");
            deposit = Convert.ToInt16(Console.ReadLine());

            s.amountDeposit(deposit);


            // current account

            CurrentAccount c = new CurrentAccount(002,26000);

            Console.WriteLine("nhap WithDraw: ");
            draw = Convert.ToInt16(Console.ReadLine());

            c.amountWithdrawn(draw);

            Console.WriteLine("nhap Deposit: ");
            deposit = Convert.ToInt16(Console.ReadLine());

            c.amountDeposit(deposit);

            Console.ReadKey();
        }
    }
}
