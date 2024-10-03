using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class ReplaceCase
    {
        public ReplaceCase() {
            string str1 = "NiRaV";
            string temp = "";

            Console.WriteLine(str1);
            Console.WriteLine("-------------------after swapping---------");
            foreach (char s in str1) {
                if (char.IsLower(s))
                {
                    temp += char.ToUpper(s);
                    
                }
                else if (char.IsUpper(s)) {
                    temp += char.ToLower(s);    
                }
            }
            Console.WriteLine(temp);
        }
    }
       
}
