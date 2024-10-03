using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class AreaOfRactangle
    {
        double height, width;

       public  AreaOfRactangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public void calculateArea()
        {
            Console.WriteLine("Area of rectangle is :  " + this.height*this.width);
        } 
    }
}
