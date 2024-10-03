using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal abstract class AbstractSum
    {
        public abstract void SumOfTwo(int a , int b);

        public abstract void SumOfThree(int a , int b , int c);
    }

    class Calculate : AbstractSum
    {
        public override void SumOfTwo(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"Sum of two number {a} and {b} is : " + sum);
        }

        public override void SumOfThree(int a, int b, int c)
        {
            int sum = (a + b) + c;
            Console.WriteLine($"Sum of three number {a} , {b} and {c} is :  " + sum);
        }
    }
}
