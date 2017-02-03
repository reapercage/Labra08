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
        public double Radius;
        private double area;
        private double circumference;
        public override void Area()
        {
            area = Math.PI * Math.Pow(Radius,2);
        }
        public override void Circumference()
        {
            circumference = 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return Name + " " + Radius + " " + area;
        }

    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        private double area;
        private double circumference;

        public override void Area()
        {
            area = Width * Height;
        }
        public override void Circumference()
        {
            circumference = 2 * Width + 2 * Height;
        }

    }
    class Shapes
    {
        private List<Shape> shapes;
        public List<Shape> Kuviot
        {
            get { return shapes; }
        }
        public void AddCircle(Circle crc)
        {
            shapes.Add(crc);
        }
        public void AddRectangle(Rectangle rec)
        {
            shapes.Add(rec);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shapes muodot = new Shapes();
            Circle crc = new Circle { Name = "ympr1", Radius = 1 };
            muodot.AddCircle(crc);

            foreach (Circle c in muodot.Kuviot)
            {
                Console.WriteLine(c.ToString());
            }
            Console.ReadKey();
        }
    }
}
