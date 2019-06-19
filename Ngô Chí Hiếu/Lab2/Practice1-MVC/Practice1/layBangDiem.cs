using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class layBangDiem
    {
        public List<nhapBangDiem> ListbangDiem = new List<nhapBangDiem>();

        public void layBD()
        {
            string chonMon;

            do
            {
                nhapBangDiem nhap = new nhapBangDiem();

                nhap.nhapMonvaDiem();
                ListbangDiem.Add(nhap);

                Console.Write("Ban co muon them Bang Diem ? (y/n): ");
                chonMon = Convert.ToString(Console.ReadLine());
            } while (chonMon == "y");
        }
    }
}
