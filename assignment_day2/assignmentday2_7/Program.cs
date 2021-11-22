using System;

namespace assignmentday2_7
{
    
    abstract class shape
    {
        double radius, width, height;

        public double Radius { get; set; }

        public double Width { get; set; }
        public double Height { get; set; }
        public abstract double Area();


    }

    class Circle : shape
    {
        public override double Area()
        {

            
            double areaOfCircle = 3.14 * Radius * Radius;
            return areaOfCircle;
        }
    }


    class Reactangle : shape
    {
        public override double Area()
        {

            
            double areaOfReact = Width * Height;
            return areaOfReact;
        }
    }
    class Triangle : shape
    {
        public override double Area()
        {

            
            double areaOfTriangle = (Width * Height) * 0.5;
            return areaOfTriangle;
        }

    }


    class Square : shape
    {
        public override double Area()
        {

           
            double areaOfSquare = Width * Width;
            return areaOfSquare;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Radius = 4;
            Console.WriteLine("Area of Circle - " + c.Area());

            Reactangle r = new Reactangle();
            r.Width = 10;
            r.Height = 5;
            Console.WriteLine("Area of Reactangle - " + r.Area());


            Triangle t = new Triangle();
            t.Width = 133;
            t.Height = 55;
            Console.WriteLine("Area of Triangle - " + t.Area());


            Square s = new Square();
            s.Width = 5;
            Console.WriteLine("Area of Square - " + s.Area());

            Console.ReadKey();
        }
    }


}