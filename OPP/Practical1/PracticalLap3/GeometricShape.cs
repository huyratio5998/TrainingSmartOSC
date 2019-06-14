using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLap3
{
    class  GeometricShape
    {
        private string shapeType;
        private double area;
        public GeometricShape()
        {
            this.shapeType = "NoShape";
            this.area = 0.0;
        }
        public virtual double computeArea()
        {
            return this.area;
        }
        public virtual void show()
        {
            Console.WriteLine("shapeType:"+shapeType);
            Console.WriteLine("area:" + area);
            Console.WriteLine("computeArea:"+computeArea());
        }
    }

}
