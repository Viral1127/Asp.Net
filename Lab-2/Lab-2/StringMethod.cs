using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class StringMethod
    {
        public StringMethod()
        {
            string str1 = "Viral";
            string str2 = "Chauhan";
            string str;

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            int length = str1.Length;
            Console.WriteLine("length of str1 is :  " + length);

            str = String.Concat(str1, str2);
            Console.WriteLine("concatination of two strings is :  " + str);

            string substring = str.Substring(0,5);
            Console.WriteLine("substring :  " + substring);

            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str2.ToLower());
        }
    }
}
