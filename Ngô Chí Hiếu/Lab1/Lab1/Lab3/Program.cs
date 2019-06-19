using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            GeometricShape g = new GeometricShape();

            g.show();
            //-------------------------------------------------------

            Rectangle r = new Rectangle();

            Console.WriteLine("Enter Length: ");
            r.mutatorLength(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Enter Width: ");
            r.mutatorWidth(Convert.ToDouble(Console.ReadLine()));

            r.show();
            //-----------------------------------------------------------
            Cuboid c = new Cuboid();

            Console.WriteLine("Enter Length: ");
            c.mutatorLength(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Enter Width: ");
            c.mutatorWidth(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Enter Height: ");
            c.setHeight(Convert.ToDouble(Console.ReadLine()));
            c.show();
            //--------------------------------------------------------
           
            Console.ReadKey();
        }
    }
}
