using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class GeometricShape
    {
        private string shapeType;

        public string ShapeType { get => shapeType; set => shapeType = value; }
        public double Area { get => area; set => area = value; }

        private double area;
        public void construc()
        {
            shapeType = "Noshape";
            area = 0.0;
        }
        public virtual double computeArea()
        {
            return area;
        }
        public virtual void show()
        {
            Console.WriteLine("hinh dang " + shapeType);
            Console.WriteLine("dientich " + area);
        }
    }
        public class Rectangle:GeometricShape
    {
        public double length;
        public double width;
        public void mutator(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public Double accessorlength()
        {
            return this.length ;
        }
        public double accessorwidth()
        {
            return width;
        }
        public override double computeArea()
        {
            return length * width;
        }
        public override void show()
        {
            Console.WriteLine("chieu dai la: " + length);
            Console.WriteLine("chieu rong la " + width);
            Console.WriteLine("hinh dang " + base.ShapeType);
            Console.WriteLine("dientich " + computeArea());
        }

    }
    public class cuboid:Rectangle
    {
        double height;

        public double Height { get => height; set => height = value; }
        public override double computeArea()
        {
            return height*base.length*base.width;
        }
        public override void show()
        {
            Console.WriteLine("chieu cao la: " + height);
            Console.WriteLine("chieu dai la: " + base.length);
            Console.WriteLine("chieu rong la " + base.width);
            Console.WriteLine("hinh dang " + base.ShapeType);
            Console.WriteLine("dientich " + computeArea());
        }
    }
    //public class test
    //{
    //    public static void Main(string[] args)
    //    {
    //        cuboid hinhvuong = new cuboid();
    //        hinhvuong.ShapeType = "hinh vuong";
    //        hinhvuong.Height = 2;
    //        hinhvuong.length = 2;
    //        hinhvuong.width = 2;
    //        hinhvuong.show();
    //        Console.ReadKey();
    //    }
    //}
    //public class test
    //{
    //    public static  void Main(string[] agrs)
    //    {
    //        GeometricShape hinh= new GeometricShape();
    //        Console.WriteLine("area " + hinh.Area);
    //        Console.ReadKey();
    //    }
    //}
}
