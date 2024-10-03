using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_4
{
    internal class ListDemo
    {
        public void getStudent()
        {
            List<string> studentList = new List<string>();

            studentList.Add("Viral");
            studentList.Add("jenish");
            studentList.Add("vivek");
            studentList.Add("tejas");
            studentList.Add("thoru");

            foreach (string i in studentList)
            {
                Console.WriteLine(i);
            }

            studentList.RemoveAt(2);
            Console.WriteLine("-----------------After Remove with index 2 ----------");

            foreach (string i in studentList)
            {
                Console.WriteLine(i);
            }

            studentList.RemoveRange(1, 2);
            Console.WriteLine("--------------Remove 2 items from 1st index-----------");

            foreach (string i in studentList)
            {
                Console.WriteLine(i);
            }

            studentList.Clear();
            Console.WriteLine("---------------------Clear all students----------------");

        }
    }
}
