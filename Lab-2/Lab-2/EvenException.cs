using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class EvenException
    {
        public EvenException() {
            Console.WriteLine("Enter number :  ");
            int a =  Convert.ToInt32(Console.ReadLine());

            try
            {
                if (a % 2 != 0) {
                    throw new Exception("Number is not even");
                }
                else
                {
                    Console.WriteLine($"{a} is Even");
                }
            }
            catch (Exception e){
                Console.WriteLine(e);
            }
        }
    }
}
