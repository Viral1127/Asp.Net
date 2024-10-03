using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class DevideByZero
    {
        public DevideByZero()
        {
            try
            {
                Console.WriteLine("ENter value of A :  ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value of B :  ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ans :  " + a / b);
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}
