using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Distance
    {
        double dis1, dis2,dis3;
        public Distance(double dis1,double dis2) {
            this.dis1 = dis1;
            this.dis2 = dis2;
        }

        public void calculateDistance()
        {
            dis3 = dis1 + dis2;
            Console.WriteLine("Addition of dis1 and dis2 is :  " + dis3);
        }
    }
}
