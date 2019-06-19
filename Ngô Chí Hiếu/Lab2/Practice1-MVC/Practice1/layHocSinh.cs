using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class layHocSinh
    {
        public void layHS()
        {
            List<nhapHocSinh> lH = new List<nhapHocSinh>();
            string chonHs;

            do
            {
                nhapHocSinh hs = new nhapHocSinh();

                hs.nhapInfo();
                lH.Add(hs);

                Console.WriteLine("Ban co muon them Hoc Sinh ? (y/n): ");
                chonHs = Convert.ToString(Console.ReadLine());

                if (chonHs == "n")
                {
                    foreach (var item in lH)
                    {
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.WriteLine("Thong tin hoc sinh thu {0}: ", lH.Count);
                        item.show();

                    }
                }

            } while (chonHs == "y");
        }
    }
}
