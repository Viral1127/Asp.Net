using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal interface Shape
    {
        void Circle(double r);
        void Triangle(double height, double Base);
        void Square(double a);
    }

    public class Area : Shape
    {

        double area;
        public void Circle(double r)
        {
            area = (3.14 * r * r);
            Console.WriteLine($"Area of circle with radious {r} is :  " + area);
        }

        public void Square(double a)
        {
            area = Math.Pow(a, 2);
            Console.WriteLine($"Area of square with side {a} is :  " + area);
        }

        public void Triangle(double height, double Base)
        {
            area = 0.5 * height * Base;
            Console.WriteLine($"area of triangle with height {height} and base {Base} is :  " + area);
        }
    }
}
