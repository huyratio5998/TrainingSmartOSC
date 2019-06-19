using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_1.Models
{
    class BdModel
    {
        public string tenMonHoc { get; set; }
        public float soDiem { get; set; }
        //public string chonBD { get; set; }

        public BdModel()
        {

        }
        public BdModel(string tendiem,float sodiem)
        {
            this.tenMonHoc = tendiem;
            this.soDiem = sodiem;
        }
        public void nhapBD()
        {
            Console.WriteLine("Nhap ten mon hoc: ");
            this.tenMonHoc = Console.ReadLine();
            
            try
            {
                Console.WriteLine("Nhap so diem: ");
                this.soDiem = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ban da nhap sai so diem!!!!"); ;
            }
            
        }
    }
}
