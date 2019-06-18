using Practice_1.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Controller
{
    class MenuController
    {
        UserController userController = new UserController();
        public void hienDsHocSinh(List<User> listUser)
        {
            if (listUser.Count <= 0 || listUser == null)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }
            Console.WriteLine("\nDanh sach cac hoc sinh: ");
            foreach (var item in listUser)
            {
                userController.hienUser(item);
            }
        }
        public void nhapDsHocSinh(List<User> listUser)
        {

            bool isChoose = true;
            User users;

        nhapTiep:
            Console.WriteLine("\nNhap Thong Tin Sinh Vien: ");
            do
            {
                users = new User();
                userController.nhapUser(users);
                listUser.Add(users);

                Console.WriteLine("\nBan co muon nhap tiep sinh vien khong? (Y/N)");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "N" || yesOrNo == "n" || yesOrNo == "No")
                {
                    hienDsHocSinh(listUser);
                    isChoose = false;
                    break;
                }
                else if (yesOrNo == "Y" || yesOrNo == "Y" || yesOrNo == "Yes")
                {
                    goto nhapTiep;
                }
            } while (isChoose);
        }

        public void locDsHocSinh(List<User> listUser)
        {
            Console.WriteLine("\nDanh sach hoc sinh co diem > 6!");

            listUser = listUser.Where(d => d.bangDiems.Average(t => t.mark) > 6).ToList();

            listUser = listUser.OrderBy(n => n.hoTen.Split(' ').Last()).ToList();

            hienDsHocSinh(listUser);
        }

        public void layRaCacMonHoc(List<User> listUser)
        {
            Console.WriteLine("\nCac mon hoc hien co cua hoc sinh: ");

            //cau linq nay chua hoan thien(ko hien thi dc ten mon theo kieu string)
            /*  var listUsers = listUser.Where(t => t.bangDiems.All(d => d.subject != d.subject.Distinct())).Distinct().ToList();
               foreach (var user in listUsers)
              {
                  foreach (var bangDiem in user.bangDiems)
                  {
                      Console.WriteLine($"Mon: {bangDiem.subject}");
                  }                             
              } */

            HashSet<string> tenCacMon = new HashSet<string>();
            foreach (var item in listUser)
            {
                foreach (var bangDiem in item.bangDiems)
                {
                    tenCacMon.Add(bangDiem.subject);
                }
            }

            foreach (var mon in tenCacMon)
            {
                Console.WriteLine($"Mon: {mon}");
            }
            
        }

        public int nhapChonSo()
        {
        nhapLaiChonSo:
            int chonSo;
            while (true)
            {
                try
                {
                    chonSo = int.Parse(Console.ReadLine());
                    if (!isValidInputNumber(chonSo))
                    {
                        Console.WriteLine("Chi duoc nhap so tu 1 -> 5! \nMoi nhap lai: ");
                        goto nhapLaiChonSo;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Chi duoc nhap so tu 1 -> 5! \nMoi nhap lai: ");
                    goto nhapLaiChonSo;
                }
                return chonSo;
            }
        }

        private bool isValidInputNumber(int chonSo)
        {
            if (chonSo < 1 || chonSo > 5)
            {
                return false;
            }
            return true;
        }

        public void toExit(int so)
        {
            if (so == 5) Environment.Exit(0);
        } 
    }
}
