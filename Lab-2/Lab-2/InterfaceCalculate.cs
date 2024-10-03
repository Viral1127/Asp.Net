using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal interface InterfaceCalculate
    {
        void Addition(int a ,int b);
        void Substraction(int a , int b);

    }

    public class Result : InterfaceCalculate
    {
        public void Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"Sum of two number {a} and {b} is :  " + sum);
        }
        public void Substraction(int a, int b)
        {
            int sub = a - b;
            Console.WriteLine($"Substraction of two number {a} and {b} is :  " + sub);
        }
    }  
}
