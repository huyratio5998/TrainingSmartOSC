using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratice_1.Models;
using static Pratice_1.Models.HsModel;

namespace Pratice_1.Controllers
{
    class HsController
    {
        
        public void getHs(List<HsModel> listHs)
        {
            HsModel hsm;
            
            string themHs;

            do
            {
                hsm = new HsModel();

                hsm.nhapHs();
                listHs.Add(hsm);


                Console.WriteLine("Them hoc sinh? (y/n) ");
                themHs = Convert.ToString(Console.ReadLine());

                if (themHs == "n" || themHs == "no" || themHs == "N" || themHs == "No")
                {

                    foreach (var item in listHs)
                    {
                        Console.WriteLine("Ten: {0}", item.tenHS);
                        Console.WriteLine("Gioi Tinh: {0}", item.gioiTinh);
                        Console.WriteLine("Email: {0}", item.email);
                        foreach (var iteml in hsm.listBd)
                        {
                            Console.WriteLine("Mon hoc: {0}", iteml.tenMonHoc);
                            Console.WriteLine("So Diem: {0}", iteml.soDiem);
                        }
                    }
                }
                Console.ReadLine();
            } while (themHs == "y" || themHs == "yes" || themHs == "Y" || themHs == "Yes");


            //Console.Clear();

        }


        public void nhapHsS(HsModel hsModel)
        {
            Console.WriteLine("Nhap vao thong tin hoc sinh:");
            Console.WriteLine("Nhap vao Ten: ");
            hsModel.tenHS = Console.ReadLine();

            do
            {
                Console.WriteLine("Nhap vao Gioi Tinh: ");
                hsModel.gioiTinh = Convert.ToString(Console.ReadLine());

                if (hsModel.gioiTinh == "nam" || hsModel.gioiTinh == "Nam")
                {
                    hsModel.gioiTinh = hsModel.convertEnum(gender.Male);
                    break;

                }
                if (hsModel.gioiTinh == "nu" || hsModel.gioiTinh == "Nu" || hsModel.gioiTinh == "nU" || hsModel.gioiTinh == "NU")
                {
                    hsModel.gioiTinh = hsModel.convertEnum(gender.Female);
                    break;
                }
                if (hsModel.gioiTinh == "" || hsModel.gioiTinh == "khong" || hsModel.gioiTinh == "Khong" || hsModel.gioiTinh == "KHONG")
                {
                    hsModel.gioiTinh = hsModel.convertEnum(gender.FuckenWowShit);
                    break;
                }
                else
                {
                    Console.WriteLine("Ban da nhap sai gioi tinh, Xin moi nhap lai !");

                    hsModel.gioiTinh = null;
                }
            } while (hsModel.gioiTinh == null);

            Console.WriteLine("Nhap vao Email: ");
            hsModel.email = Convert.ToString(Console.ReadLine());
            BdModel bdm;
            do
            {
                bdm = new BdModel();

                nhapDiem(bdm);
                hsModel.listBd.Add(bdm);

                Console.WriteLine("Them bang diem ? (y/n)  ");
                hsModel.thembd = Console.ReadLine();
            } while (hsModel.thembd == "y" || hsModel.thembd == "yes" || hsModel.thembd == "Y" || hsModel.thembd == "Yes");
        }

        public void nhapDiem(BdModel bdModel)
        {
            Console.WriteLine("Nhap ten mon hoc: ");
            bdModel.tenMonHoc = Console.ReadLine();

            try
            {
                Console.WriteLine("Nhap so diem: ");
                bdModel.soDiem = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ban da nhap sai so diem!!!!"); ;
            }
        }
    }
}
