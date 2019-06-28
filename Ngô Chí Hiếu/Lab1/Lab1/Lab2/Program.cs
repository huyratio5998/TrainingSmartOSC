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
            string repeat;
            int choose;
            SavingAccount s = new SavingAccount(001, 80000);
            CurrentAccount c = new CurrentAccount(002, 26000);

            do
            {
                do
                {
                    Console.WriteLine("Moi ban chon: ");
                    Console.WriteLine("1. Saving Accoutn");
                    Console.WriteLine("2. Current Account");
                    Console.WriteLine("3. Thoat");
                    choose = Convert.ToInt16(Console.ReadLine());
                } while (choose!= 1 && choose != 2 && choose != 3);
                
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap WithDraw: ");
                        draw = Convert.ToInt64(Console.ReadLine());

                        s.amountWithdrawn(draw);

                        Console.WriteLine("nhap Deposit: ");
                        deposit = Convert.ToInt64(Console.ReadLine());

                        s.amountDeposit(deposit);
                        break;

                    case 2:
                        Console.WriteLine("nhap WithDraw: ");
                        draw = Convert.ToInt64(Console.ReadLine());

                        c.amountWithdrawn(draw);

                        Console.WriteLine("nhap Deposit: ");
                        deposit = Convert.ToInt64(Console.ReadLine());

                        c.amountDeposit(deposit);

                        Console.ReadKey();
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Ban co muon tiep tuc Giao dich khong ? (y/n)");
                repeat = Console.ReadLine();
                if (repeat != "y"&& repeat != "n" && repeat != "Y" && repeat != "N" && repeat != "Yes" && repeat != "No" && repeat != "YES" && repeat != "NO")
                {
                    Console.WriteLine("Ban da nhap sai, xin moi nhap lai !");
                    repeat = "y";
                }
            } while (repeat == "y");            
        }
    }
}
