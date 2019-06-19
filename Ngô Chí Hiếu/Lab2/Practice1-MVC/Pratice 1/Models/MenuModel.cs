using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratice_1.Controllers;

namespace Pratice_1.Models
{
    class MenuModel
    {
        public int chon { get; set; }
        public void index()
        {
                Console.WriteLine("<-----------------------Quan Ly Hoc Sinh ---------------------->");

                Console.WriteLine("1. Nhap thong tin hoc sinh.");
                Console.WriteLine("2. Hien thi hoc sinh co so diem trung binh >6");
                Console.WriteLine("3. Hien thi ten cac mon hoc");
                Console.WriteLine("4. Hien thi tat ca thong tin hoc sinh");
                Console.WriteLine("5. Thoat.");
                Console.WriteLine("Xin moi chon !");

                chon = Convert.ToInt16(Console.ReadLine());
                if (chon > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Ban da nhap sai, Xin moi nhap lai !");
                }
        }
    }
}
