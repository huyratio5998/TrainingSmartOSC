using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLap3
{
    class Rectangle : GeometricShape
    {
        private double length, width;
        public void mutator(double Length, double Width)
        {
            this.length = Length;
            this.width = Width;
        }
        public double accessorLength()
        {
            return length;
        }
        public double accessorWidth()
        {
            return width;
        }
        public override double computeArea()
        {
            return this.length * this.width;
        }
        public override void show()
        {
            Console.WriteLine("--------Rectangle--------");
            base.show();           
            Console.WriteLine("Length: "+length);
            Console.WriteLine("Width: " + width);
            
        }
    }
}
