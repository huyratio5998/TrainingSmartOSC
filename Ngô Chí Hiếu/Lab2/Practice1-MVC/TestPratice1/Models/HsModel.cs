using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_1.Models
{
    class HsModel
    {
        public string tenHS { get; set; }
        public string gioiTinh { get; set; }
        public string email { get; set; }

        public string chonHS { get; set; }

        public List<BdModel> listbangdiem = new List<BdModel>();

        public HsModel()
        {

        }
        public HsModel(string tenhs, string gioitinh,string emaill,string chonhs)
        {
            this.tenHS = tenhs;
            this.gioiTinh = gioitinh;
            this.email = emaill;
            this.chonHS = chonhs;
        }

        public void nhapHs()
        {
            Console.WriteLine("Nhap vao thong tin hoc sinh:");
            Console.WriteLine("Nhap vao Ten: ");
            tenHS = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nhap vao Gioi Tinh: ");
            gioiTinh = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nhap vao Email: ");
            email = Convert.ToString(Console.ReadLine());

            BdModel bdm = new BdModel();
            do
            {
                bdm.nhapBD();
                listbangdiem.Add(bdm);

            } while (bdm.nhapthemBD() == "y"|| bdm.nhapthemBD() == "Y"|| bdm.nhapthemBD() == "yes"|| bdm.nhapthemBD() == "Yes");
            

            
        }

        public string nhapthemHS()
        {
            Console.WriteLine("Ban co muon nhap them Hoc Sinh ? (y/n): ");
            return chonHS = Convert.ToString(Console.ReadLine());
        }

        
    }
}
