using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_3
{
    class Cuboid : Rectangle
    {
        private float height;

        public float getHeight()
        {
            return this.height;
        }

        public void setHeight(float height)
        {
            this.height = height;
        }

        public override double computerArea()
        {
            return this.height * base.accesserLength() * base.accesserWidth();
        }

        public override void show()
        {
            //base.show();
            //Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Cuboid: {getHeight()} x {accesserLength()} x {accesserWidth()} = {computerArea()}");
        }
    }
}
