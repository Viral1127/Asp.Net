using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class SumOverLoading
    {
        public void sum(int a , int b)
        {
            int total = a + b;
            Console.WriteLine(total);
        }

        public void sum(double a , double b)
        {
            double total = a + b;
            Console.WriteLine(total);
        }
    }
}
