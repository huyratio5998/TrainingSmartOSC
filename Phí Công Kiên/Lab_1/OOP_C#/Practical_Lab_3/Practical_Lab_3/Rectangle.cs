using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_3
{
    class Rectangle : GeometricShape
    {
        private float length;
        private float width;
        public void mutatorLength(float set)
        {
            this.length = set;
        }

        public float accesserLength()
        {
            return this.length;
        }

        public void mutatorWidth(float set)
        {
            this.width = set;
        }

        public float accesserWidth()
        {
            return this.width;
        }

        public override double computerArea()
        {
            return this.length * this.width;
        }


        public override void show()
        {
            //base.show();
            //Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Rectangle: {accesserWidth()} x {accesserLength()} = {computerArea()}");
        }
    }
}
