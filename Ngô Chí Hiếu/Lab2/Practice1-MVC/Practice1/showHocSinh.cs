using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class showHocSinh :nhapHocSinh
    {

        public void show()
        {
            Console.WriteLine("Ho va Ten: {0}", this.hoVaTen);
            Console.WriteLine("Gioi Tinh: {0}", this.gioiTinh);
            Console.WriteLine("Email: {0}", this.hopThu);


        }
    }
}
