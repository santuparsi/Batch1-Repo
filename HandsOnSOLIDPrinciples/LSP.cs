using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples1
{
    public abstract class Shape
    {
        public abstract string GetShape();
    }
    public class Trinagle:Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }
    public class Circle:Shape
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }

    internal class LSP
    {
        static void Main()
        {
            Shape shape = new Circle();
            Console.WriteLine(shape.GetShape());
            shape = new Trinagle();
            Console.WriteLine(shape.GetShape());

        }
    }
}
