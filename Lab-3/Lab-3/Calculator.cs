using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public delegate double Cal(double a, double b);
    internal class Calculator
    {
        public static double Add(double x, double y) => x + y;

        public static double Subtract(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;

        public static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return x / y;
        }

    }
}
