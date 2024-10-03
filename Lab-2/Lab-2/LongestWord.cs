using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class LongestWord
    {
        public LongestWord() {
            Console.WriteLine("Enter String :  ");
            string str = Console.ReadLine();
            findLognest(str);
        }

        void findLognest(string str)
        {
            string temp = "";
            string[] words = str.Split(new[] { " " } , StringSplitOptions.None);
            int len = 0;

            foreach (string word in words) {
                if (word.Length > len) { 
                    temp = word;
                    len = word.Length;
                }
            }
            Console.WriteLine(temp);
        }
    }
}
