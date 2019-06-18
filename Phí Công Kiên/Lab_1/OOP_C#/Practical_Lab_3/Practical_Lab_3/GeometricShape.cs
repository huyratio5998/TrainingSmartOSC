using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_3
{
    class GeometricShape
    {
        public string shapeType { get; set; }
        public double area { get; set; }

        public GeometricShape()
        {
            this.area = 0.0;
            this.shapeType = "NoShape";
        }

        public virtual double computerArea()
        {
            return this.area;
        }

        public virtual void show()
        {
            Console.WriteLine($"Shape type: {this.shapeType} | Area: {this.area} | Comouter area: {computerArea()}");
        }
    }
}
