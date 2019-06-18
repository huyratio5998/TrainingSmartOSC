using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricShape geometricShape = new GeometricShape();

            geometricShape.show();

            Console.WriteLine("\n-----------------------------------------------------\n");

            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter length Rectangle: ");
            float length = float.Parse(Console.ReadLine());
            rectangle.mutatorLength(length);

            Console.WriteLine("Enter width Rectangle: ");
            float width = float.Parse(Console.ReadLine());
            rectangle.mutatorWidth(width);

            rectangle.show();

            Console.WriteLine("\n-----------------------------------------------------\n");

            Cuboid cuboid = new Cuboid();

            Console.WriteLine("Enter height Cuboid: ");
            float heightCU = float.Parse(Console.ReadLine());
            cuboid.setHeight(heightCU);

            Console.WriteLine("Enter length Cuboid: ");
            float lengthCU = float.Parse(Console.ReadLine());
            cuboid.mutatorLength(lengthCU);

            Console.WriteLine("Enter width Cuboid: ");
            float widthCU = float.Parse(Console.ReadLine());
            cuboid.mutatorWidth(widthCU);

            cuboid.show();

            Console.ReadKey();
        }
    }
}
