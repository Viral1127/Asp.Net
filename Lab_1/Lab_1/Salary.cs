using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Salary
    {
        double Basic, TA, DA, HRA , TotalSalary;

        public Salary() { 
            DA = 1.0;
            HRA = 1.0;

            Console.WriteLine("Enter travel allownnces :  ");
            TA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter basic salary :  ");
            Basic = Convert.ToDouble(Console.ReadLine());
            
            TotalSalary = DA + HRA + TA + Basic;
        }

        public void displaySalary()
        {
            Console.WriteLine("Basic salary  :  " + Basic);
            Console.WriteLine("Travelling allowances :  " + TA);
            Console.WriteLine("DA :  " + DA);
            Console.WriteLine("HRA :  " + HRA);
            Console.WriteLine("Total Salary =  " + TotalSalary);
        }
    }
}
