using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class RBI
    {
        public void CalculateInterest(double p , double n , double r)
        {
            double interest = (p * n * r) / 100;
            Console.WriteLine("RBI interest:  " + interest);
        }
    }

    class HDFC : RBI {
        public void CalculateInterest(double p, double n, double r)
        {
            double interest = (p * n * r) / 100;
            Console.WriteLine("HDFC interest:  " + interest);
        }
    }

    class SBI : RBI
    {
        public void CalculateInterest(double p, double n, double r)
        {
            double interest = (p * n * r) / 100;
            Console.WriteLine("SBI interest:  " + interest);
        }
    }

    class ICICI : RBI
    {
        public void CalculateInterest(double p, double n, double r)
        {
            double interest = (p * n * r) / 100;
            Console.WriteLine("ICICI interest:  " + interest);
        }
    }
}
