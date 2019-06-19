using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cuboid :Rectangle
    {
        private double height;

        public double getHeight()
        {
            return this.height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public override double computeArea()
        {
            return base.computeArea() * getHeight();
        }

        public override void show()
        {
            Console.WriteLine("Height: {0}",getHeight());
            Console.WriteLine("Cuboid: {0} = {1} x {2} x {3}", this.computeArea(),base.AccessorLength(),base.AccessorWidth(),getHeight());
        }
    }
}
