using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class nhapHocSinh
    {
        public string hoVaTen { get; set; }
        public string gioiTinh { get; set; }
        public string hopThu { get; set; }

        public List<nhapBangDiem> ListbangDiem = new List<nhapBangDiem>();


        public nhapHocSinh()
        {

        }

        public nhapHocSinh(string hovaten, string gioitinh, string hopthu, List<nhapBangDiem> bangdiem)
        {
            this.hoVaTen = hovaten;
            this.gioiTinh = gioitinh;
            this.hopThu = hopthu;
            this.ListbangDiem = bangdiem;
        }

        public void nhapInfo()
        {

            Console.Write("Nhap vao Ho va Ten: ");
            this.hoVaTen = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap vao Gioi Tinh: ");
            this.gioiTinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap vao Email: ");
            this.hopThu = Convert.ToString(Console.ReadLine());
        }



    }
}
