using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{


    public class Fectorial
    {
        public delegate int CommonDelegate(int n);
        public static void calc(CommonDelegate fn, int n)
        {
            Console.WriteLine(fn(n));
        }

        public Fectorial()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            calc(CalculateFactorial, 5);
            calc(isEven, 5);

        }
        static int isEven(int n)
        {
            return n % 2;
        }

        static int CalculateFactorial(int n)
        {
            int ans = 1;
            for (int i = 1; i <= n; i++)
            {
                ans *= i;
            }
            return ans;
        }
    }
}
