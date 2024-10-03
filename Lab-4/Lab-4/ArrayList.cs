using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_4
{
    internal class ArrayListDemo
    {
        

        public void getStudent()
        {
            ArrayList studentList = new ArrayList();
            studentList.Add("Viral");
            studentList.Add("jenish");
            studentList.Add("vivek");
            studentList.Add("tejas");
            studentList.Add("thoru");

            foreach (string i in studentList) { 
                Console.WriteLine(i);
            }

            studentList.Remove("Viral");
            Console.WriteLine("-----------------After Remove----------");

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
