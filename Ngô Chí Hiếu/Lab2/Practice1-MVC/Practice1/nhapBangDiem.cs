using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class nhapBangDiem
    {
        public string monHoc { get; set; }
        public float soDiem { get; set; }

        public nhapBangDiem()
        {

        }

        public nhapBangDiem(string monhoc,float sodiem)
        {
            this.monHoc = monhoc;
            this.soDiem = sodiem;
        }

        public void nhapMonvaDiem()
        {
            Console.Write("Nhap vao ten mon hoc: ");
            this.monHoc = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap vao so diem cua mon {0} : ",this.monHoc);
            try
            {
                this.soDiem = float.Parse(Console.ReadLine());
            }
            catch (NotFiniteNumberException exception)
            {

                throw exception;
            }
            
            
        }

    }
}
