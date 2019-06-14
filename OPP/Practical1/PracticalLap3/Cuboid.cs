using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLap3
{
    class Cuboid: Rectangle
    {
        private double height;
        public void setHeight(int Height)
        {
            this.height = Height;
        }
        public double getHeight()
        {
            return this.height;
        }
        public override double computeArea()
        {
            return base.computeArea() * height;
        }
        public override void show()
        {
            Console.WriteLine("-----------Cuboid-------------");
            base.show();            
            Console.WriteLine("Height: "+height);
                    
        }
    }
}
