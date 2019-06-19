using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratice_1.Controllers;

namespace Pratice_1.Models
{
    class HsModel
    {
        public string tenHS { get; set; }
        public enum gender
        {
            FuckenWowShit = 0,
            Male = 1,
            Female = 2
        }
        public string gioiTinh { get; set; }
        public string email { get; set; }

        public string thembd;
        
        public List<BdModel> listBd { get; set; }

        public HsModel()
        {
            this.tenHS = "";
            this.gioiTinh = "";
            this.email = "";
        }

        public HsModel(string tenhs, string gioitinh, string emaill,  List<BdModel> listbdmodel)
        {
            this.tenHS = tenhs;
            this.gioiTinh = gioitinh;
            this.email = emaill;
            //  this.chonHS = chonhs;
            this.listBd = new List<BdModel>();
        }

        public void nhapHs()
        {
            Console.WriteLine("Nhap vao thong tin hoc sinh:");
            Console.WriteLine("Nhap vao Ten: ");
            tenHS = Console.ReadLine();

            do
            {
                Console.WriteLine("Nhap vao Gioi Tinh: ");
                this.gioiTinh = Convert.ToString(Console.ReadLine());

                if (gioiTinh == "nam" || gioiTinh == "Nam" || gioiTinh == "nAm" || gioiTinh == "naM" || gioiTinh == "NAm" || gioiTinh == "NaM" || gioiTinh == "nAM" || gioiTinh == "NAM")
                {
                    this.gioiTinh  = convertEnum(gender.Male);
                    break;
                    
                }
                if (gioiTinh == "nu" || gioiTinh == "Nu" || gioiTinh == "nU" || gioiTinh == "NU")
                {
                    this.gioiTinh = convertEnum(gender.Female);
                    break;
                }
                if (gioiTinh == "" || gioiTinh == "khong" || gioiTinh == "Khong" || gioiTinh == "KHONG")
                {
                    this.gioiTinh = convertEnum(gender.FuckenWowShit);
                    break;
                }
                else
                {
                    Console.WriteLine("Ban da nhap sai gioi tinh, Xin moi nhap lai !");

                    this.gioiTinh = null;
                }
            } while (this.gioiTinh == null);

            Console.WriteLine("Nhap vao Email: ");
            this.email = Convert.ToString(Console.ReadLine());
            BdModel bdm;
            do
            {
                bdm = new BdModel();

                bdm.nhapBD();
                
                Console.WriteLine("Them bang diem ? (y/n)  ");
                thembd = Console.ReadLine();
            } while (thembd == "y" || thembd == "yes" || thembd == "Y" || thembd == "Yes");
        }

        public string convertEnum(gender gender)
        {
            string vvvvv;
            switch (gender)
            {
                case gender.FuckenWowShit:
                    vvvvv = "khong xac dinh";
                    return vvvvv;

                case gender.Male:
                    vvvvv = "Nam";
                    return vvvvv;
                case gender.Female:
                    vvvvv = "Nu  ";
                    return vvvvv;

                default:
                    return "    g";
                  
            }


        }
    }
}
