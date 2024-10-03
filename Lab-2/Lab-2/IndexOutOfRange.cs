using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class IndexOutOfRange
    {
        public IndexOutOfRange() {
            int[] arrayList = new int[5];

            try
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("enter number");
                    arrayList[i]= Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(arrayList[10]);
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
