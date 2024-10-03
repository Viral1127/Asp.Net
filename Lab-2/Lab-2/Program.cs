using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-10) or 0 to exit");
                Console.WriteLine("1 : Run DevideByZero Exception program");
                Console.WriteLine("2 : Run IndexOutOfBound Exception program");
                Console.WriteLine("3 : Run Abstract class sum program");
                Console.WriteLine("4 : Run Interface program");
                Console.WriteLine("5 : String methods");
                Console.WriteLine("6 : Replace lower and upper ");
                Console.WriteLine("7 : Shape interface");
                Console.WriteLine("8 : Even Exception");
                Console.WriteLine("9 : Longest Word"    );

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        DevideByZero(); break;
                    case 2:
                        IndexOutOfBound(); break;
                    case 3:
                        AbstractSum();break;
                    case 4:
                        Interface();break;
                    case 5:
                        StringMethod();break;
                    case 6:
                        Replace();break;
                    case 7:
                        ShapeInterface();break;
                    case 8:
                        EvenException();break;
                    case 9:
                        Longest();break;

                   
                }
            }

            void DevideByZero()
            {
                DevideByZero e = new DevideByZero();
                
            }
            void IndexOutOfBound()
            {
                IndexOutOfRange i = new IndexOutOfRange();
            }
            void AbstractSum()
            {
                Calculate c = new Calculate();
                c.SumOfTwo(10, 20);
                c.SumOfThree(10, 20, 30);
            }
            void Interface()
            {
                Result result = new Result();
                Console.WriteLine("Enter number 1 :  ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2 :  ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                result.Addition(num1,num2);
                result.Substraction(num1,num2);
            }
            void StringMethod()
            {
                StringMethod stringMethod = new StringMethod();

            }

            void Replace()
            {
                ReplaceCase replaceCase = new ReplaceCase();
              
            }

            void ShapeInterface()
            {
                Area area = new Area();
                Console.WriteLine("enter radious of circle :  ");
                double r =  Convert.ToDouble(Console.ReadLine());
                area.Circle(r);
                Console.WriteLine("enter side of square :  ");
                double a = Convert.ToDouble(Console.ReadLine());
                area.Square(a);
                Console.WriteLine("enter height for triangle");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter width for triangle :  ");
                double Base = Convert.ToDouble(Console.ReadLine());
                area.Triangle(height,Base);
            }

            void EvenException()
            {
                EvenException e = new EvenException();
            }

            void Longest()
            {
                LongestWord longestWord = new LongestWord();
            }
        }
    }
}
