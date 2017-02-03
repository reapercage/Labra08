using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    abstract class Shape
    {
        public string Name { get; set; }

        public abstract void Area();

        public abstract void Circumference();
    }
    class Circle : Shape
    {
        private double radius;
        private double area;
        private double circumference;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public override void Area()
        {
            area = Math.PI * Math.Pow(radius,2);
        }
        public override void Circumference()
        {
            circumference = 2 * Math.PI * radius;
        }

    }
    class Rectangle : Shape
    {
        private double width;
        private double height;
        private double area;
        private double circumference;

        public override void Area()
        {
            area = width * height;
        }
        public override void Circumference()
        {
            circumference = 2 * width + 2 * height;
        }

    }
    class Shapes
    {
        private List<Shape> shapes;
        public List<Shape> Kuviot
        {
            get { return shapes; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
