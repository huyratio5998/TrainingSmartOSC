using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Menu
    {
        public static void ChooseMenu()
        {
            do
            {
                string cont;
                int chose;

                do
                {
                    
                    do
                    {
                        Console.WriteLine("Xin moi chon: ");
                        Console.WriteLine("1.Hien thi nhung hoc sinh co TBC > 6 va sap xep.");
                        Console.WriteLine("2.Hien thi gioi tinh cua cac hoc sinh.");
                        Console.WriteLine("3.Hien thi danh sach tat ca cac mon hoc.");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("4.Hien thi tat ca thong tin hoc sinh da nhap.");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("0.Thoat.");
                        chose = Convert.ToInt32(Console.ReadLine());
                        switch (chose)
                        {
                            case 1:
                                {
                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                        }
                        Console.WriteLine("Ban co muon tiep tuc ? (y/n): ");
                        cont = Convert.ToString(Console.ReadLine());

                    } while (cont == "y");
                } while (chose!=0);
            } while (true);
        }
    }
}
