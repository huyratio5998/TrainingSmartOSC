using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLap3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cuboid c = new Cuboid();
            c.mutator(50, 100);
            c.setHeight(6);
            c.show();            
        }
    }
}
