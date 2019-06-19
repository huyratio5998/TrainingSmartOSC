using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratice_1.Models;

namespace Pratice_1.Controllers
{
    class getHocSinh
    {
        public List<HsModel> listhsm = new List<HsModel>();

        public void getHs()
        {
            do
            {
                HsModel hs = new HsModel();
                hs.nhapHs();

                listhsm.Add(hs);
                Console.WriteLine("Da them thong tin thanh cong!");

                hs.nhapthemHS();
                if (hs.nhapthemHS()=="n")
                {
                    showHS();
                    break;
                }
                if (hs.nhapthemHS()=="y")
                {
                    Console.WriteLine(" ");
                }
            } while (true);
        }

        public void showHS()
        {
            foreach (var item in listhsm)
            {
                Console.WriteLine("--------------Thong tin hoc sinh {0}------------", item.tenHS);
                Console.WriteLine("Ten: {0}", item.tenHS);
                Console.WriteLine("Gioi Tinh: {0}", item.gioiTinh);
                Console.WriteLine("Email: {0}", item.email);
                
            }

        }
    }
}
