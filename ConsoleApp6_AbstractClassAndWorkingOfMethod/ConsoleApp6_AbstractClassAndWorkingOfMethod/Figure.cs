using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Abstract Class and Working Of Abstract Methods 
namespace ConsoleApp6_AbstractClassAndWorkingOfMethod
{
    public abstract class Figure
    {
        public double height;
        public double width;
        public double radious;
        public const double Pi = 3.14f;

        //Abstract Method
        public abstract double getArea();
    }

    public class Rectangle : Figure
    {
          public Rectangle(double width, double height)
          {
            this.width = width;
            this.height = height;
          }

        public override double getArea()
        {
            return width * height;
        }
    }

    public class Circle : Figure
    {
        public Circle(double radious)
        {
            this.radious = radious;
        }

        public override double getArea()
        {
            return Pi * radious * radious;
        }
    }

    public class Triangle : Figure
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double getArea()
        {
            return (width * height) / 2;
        }
    }

    public class MyClass
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(45, 25);
            Console.WriteLine("Area of Rectangel : " + r.getArea());

            Circle c = new Circle(2);
            Console.WriteLine("Area of Circle : "+ c.getArea());

            Triangle t = new Triangle(2, 2);
            Console.WriteLine("Area of Triangle : "+ t.getArea());

            Console.ReadLine();

        }
    }
}
