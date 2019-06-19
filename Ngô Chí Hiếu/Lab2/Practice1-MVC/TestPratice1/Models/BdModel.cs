using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_1.Models
{
    class BdModel
    {
        public string tenDiem { get; set; }
        public float soDiem { get; set; }
        public string chonBD { get; set; }

        public BdModel()
        {

        }
        public BdModel(string tendiem,float sodiem)
        {
            this.tenDiem = tendiem;
            this.soDiem = sodiem;
        }
        public void nhapBD()
        {
            Console.WriteLine("Nhap ten mon hoc: ");
            tenDiem = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap so diem: ");
            soDiem = float.Parse(Console.ReadLine());

        }

        public string nhapthemBD()
        {
            Console.WriteLine("Ban co muon nhap them Bang Diem ? (y/n): ");
            return chonBD = Convert.ToString(Console.ReadLine());
        }
    }
}
