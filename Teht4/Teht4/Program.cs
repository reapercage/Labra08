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
            return Name + " Radius=" + Radius.ToString("0.00") + " Area=" + area.ToString("0.00") + " Circumference=" + circumference.ToString("0.00");
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
        public override string ToString()
        {
            return Name + " Width=" + Width.ToString("0.00") + " Height=" + Height.ToString("0.00") + " Area=" + area.ToString("0.00") + " Circumference=" + circumference.ToString("0.00");
        }

    }
    class Shapes
    {
        private List<Shape> shapes;
        public List<Shape> Kuviot
        {
            get { return shapes; }
        }
        public Shapes()
        {
            shapes = new List<Shape>();
        }
        public void AddCircle(Circle crc)
        {
            crc.Area();
            crc.Circumference();
            shapes.Add(crc);
        }
        public void AddRectangle(Rectangle rec)
        {
            rec.Area();
            rec.Circumference();
            shapes.Add(rec);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shapes muodot = new Shapes();
            Circle crc = new Circle { Name = "Circle", Radius = 1 };
            muodot.AddCircle(crc);
            Rectangle rec = new Rectangle { Name = "Rectangle", Height = 20, Width = 40};
            muodot.AddRectangle(rec);

            foreach (Shape s in muodot.Kuviot)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadKey();
        }
    }
}
