using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class showBangDiem:nhapBangDiem
    {
        public void show()
        {
            Console.WriteLine("Ten mon hoc: {0}", this.monHoc);
            Console.WriteLine("So diem cua mon hoc: {0}", this.soDiem);
        }
    }
}
