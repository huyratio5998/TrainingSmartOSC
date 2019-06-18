using Practice_1.Controller;
using Practice_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.View
{
    class Menu
    {
        private const int ENTER_INFO_STUDENTS = 1;
        private const int DISPLAY_LIST_STUDENT = 2;
        private const int MEDIUM_POINTS_ABOVE_6 = 3;
        private const int GET_LIST_SUBJECT = 4;
        private const int EXIT = 5;
        MenuController menuController = new MenuController();
        public void menu()
        {
            bool isChoose = true;

            List<User> listUser = new List<User>();
            do
            {
                Console.WriteLine("---------------------QUAN LY SINH VIEN---------------------------");
                Console.WriteLine("1: Nhap thong tin hoc sinh!");
                Console.WriteLine("2: Hien tat ca danh sach hoc sinh!");
                Console.WriteLine("3: Hien thi nhung hoc sinh co diem trung binh tren 6!");
                Console.WriteLine("4: Lay ra danh sach cac mon hoc cua hoc sinh!");
                Console.WriteLine("5: Thoat!");
                Console.WriteLine("---------------------QUAN LY SINH VIEN---------------------------");
                Console.WriteLine("Moi ban chon so: ");
                int chonSo = menuController.nhapChonSo();
                Console.WriteLine("-----------------------------------------------------------------");
                switch (chonSo)
                {
                    case ENTER_INFO_STUDENTS:
                        menuController.nhapDsHocSinh(listUser);
                        break;
                    case DISPLAY_LIST_STUDENT:
                        Console.Clear();
                        menuController.hienDsHocSinh(listUser);
                        break;
                    case MEDIUM_POINTS_ABOVE_6:
                        Console.Clear();
                        menuController.locDsHocSinh(listUser);
                        break;
                    case GET_LIST_SUBJECT:
                        Console.Clear();
                        menuController.layRaCacMonHoc(listUser);
                        break;
                    case EXIT:
                        menuController.toExit(chonSo);
                        break;
                    default:
                        throw new Exception("Chon chuc nang khong hop le!");
                }
            } while (isChoose);
        }
    }
}
