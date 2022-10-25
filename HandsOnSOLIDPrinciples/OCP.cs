using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples
{
    //Demonstrate OCP
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
    public class AreaCalculator
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }
            return area;
        }
    }



    internal class OCP
    {
        static void Main()
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Rectangle(12,23);
            shapes[1] = new Circle(12.2);
            AreaCalculator areaCalculator = new AreaCalculator();
            double area=areaCalculator.TotalArea(shapes);
            Console.WriteLine("Total Area of All Shapes: " + area);
        }
    }
}
