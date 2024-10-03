using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class AreaOverLoading
    {
        public double area(float a)
        {
            return Math.Pow(a, 2);
            
        }

        public double area(double a, double b) { 
            return a* b;
            
        }

        public double area(double r)
        {
            return Math.Pow(r, 2);
            
        }




    }
}
