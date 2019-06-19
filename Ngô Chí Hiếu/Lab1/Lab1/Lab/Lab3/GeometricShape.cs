using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class GeometricShape
    {

        public double area;
        public string shapeType;

        public GeometricShape()
        {
            this.area = 0.0;
            this.shapeType = "NoShape";
        }

        public virtual double computeArea()
        {
            return this.area;
        }

        public virtual void show()
        {
            Console.WriteLine("--------------------GeometricShape----------------------------");
            Console.WriteLine("Area: {0} ",this.area);
            Console.WriteLine("Shape: {0} ",this.shapeType);
            Console.WriteLine("ComputeArea: {0}",computeArea());
            Console.WriteLine("--------------------------------------------------------------\n");
        }

    }
}
