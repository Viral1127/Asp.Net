using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-10) or 0 to exit");
                Console.WriteLine("1 : Run ArrayList program");
                Console.WriteLine("2 : Run List program");
                Console.WriteLine("3 : Run stack program");
                Console.WriteLine("4 : Run Queeue program");

                Fectorial fn = new Fectorial();

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        RunArrayList(); break;
                    case 2:
                        RunList(); break;
                    case 3:
                        RunStack(); break;
                    case 4:
                        RunQueue(); break;
                  

                }
            }

            void RunArrayList()
            {
                ArrayListDemo arrayListDemo = new ArrayListDemo();

                arrayListDemo.getStudent();
            }

            void RunList()
            {
                ListDemo listDemo = new ListDemo();

                listDemo.getStudent();
            }

            void RunStack()
            {
                StackDemo stackDemo = new StackDemo();

                stackDemo.getData();
            }

            void RunQueue()
            {
                QueueDemo queueDemo = new QueueDemo();
                queueDemo.getData();
            }
            void RunFect()
            {
                Fectorial fn = new Fectorial();
              

            }
        }
    }
}