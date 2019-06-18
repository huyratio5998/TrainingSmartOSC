using Practice_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Controller
{
    class UserController
    {
        TranscriptController transcriptController = new TranscriptController();

        public void hienUser(User users)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"Ten: {users.hoTen} | Gioi tinh: {users.gioiTinh} | Email: {users.email}");
            transcriptController.hienTranscipt(users.bangDiems);
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public void nhapUser(User users)
        {
            while (true)
            {
                Console.WriteLine("Nhap ho va ten: ");
                string ten = Console.ReadLine();

                if (ten.Length > 3 && ten != null && ten.Length <= 32)
                {
                    users.hoTen = ten;
                    break;
                }
                else
                {
                    Console.WriteLine("Ten phai co tu 4 -> 32 ki tu!");
                }
            }


            Console.WriteLine("Nhap gioi tinh: ");
            string nhapGioiTinh = Console.ReadLine();

            GioiTinh gioiTinh;

            if (nhapGioiTinh == "Nam" || nhapGioiTinh == "nam")
            {
                gioiTinh = GioiTinh.Nam;
                users.gioiTinh = getGender(gioiTinh);
            }
            else if (nhapGioiTinh == "Nu" || nhapGioiTinh == "nu")
            {
                gioiTinh = GioiTinh.Nu;
                users.gioiTinh = getGender(gioiTinh);
            }
            else
            {
                gioiTinh = GioiTinh.KhongXacDinh;
                users.gioiTinh = getGender(gioiTinh);
            }

            while (true)
            {
                Console.WriteLine("Nhap email: ");
                string email = Console.ReadLine();

                if (IsValidEmail(email) == false)
                {
                    Console.WriteLine("Nhap email sai!");
                }
                else
                {
                    users.email = email;
                    break;
                }
            }

            users.bangDiems = transcriptController.nhapTranscript();
        }

        private bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private string getGender(GioiTinh gioiTinh)
        {
            switch (gioiTinh)
            {
                case GioiTinh.Nam:
                    return "Nam";
                case GioiTinh.Nu:
                    return "Nu";
                case GioiTinh.KhongXacDinh:
                    return "Khong xac dinh gioi tinh!";
                default:
                    return "Dau vao khong hop le!";
            }
        }
    }
}
