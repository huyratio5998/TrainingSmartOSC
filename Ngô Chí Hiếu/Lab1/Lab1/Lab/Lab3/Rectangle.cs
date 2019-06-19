using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class HHH
    {
        public void GGG() {

        };

        public virtual void JJJ()
        {

        }
    }
    class Rectangle :GeometricShape
    {
        private double length;
        private double width;
 
        public void mutatorLength(double setLength)
        {
            this.length = setLength;
        }

        public double AccessorLength()
        {
            return this.length;
        }

        public void mutatorWidth(double setwidth)
        {
            this.width = setwidth;
        }

        public double AccessorWidth()
        {
            return this.width;
        }

        public override double computeArea()
        {
            return this.length * this.width;
        }

        public override void show()
        {
            base.show();
            Console.WriteLine("{0} x {1} = {2}",AccessorLength(),AccessorWidth(),computeArea());
        }


    }
}
