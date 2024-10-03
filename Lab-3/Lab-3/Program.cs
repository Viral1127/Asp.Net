using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_3.TrafficSignal;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-10) or 0 to exit");
                Console.WriteLine("1 : sum overloading");
                Console.WriteLine("2 : Area overloading");
                Console.WriteLine("3 : Method overriding");
                Console.WriteLine("4 : Hospital Overriding");
                Console.WriteLine("5 : Calculator");
                Console.WriteLine("6 : Traffic ");
                Console.WriteLine("7 : RBI");
                
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 0:
                        return;
                    case 1:
                        SumOverloading();
                        break;
                    case 2:
                        AreaOverloading();
                        break;
                    case 3:
                        Overriding();
                        break;
                    case 4:
                        HospitalOverriding();
                        break;
                    case 5:
                        Calc();
                        break;
                    case 6:
                        traffic();
                        break;
                    case 7:
                        rbi();
                        break;
                }
            }
            void SumOverloading()
            {
                SumOverLoading s = new SumOverLoading();
                s.sum(5, 10);
                s.sum(1.2, 1.5);
            }

            void AreaOverloading()
            {
                AreaOverLoading s = new AreaOverLoading();
                double areaSquare = s.area(5);
                Console.WriteLine("Area of square is :  " + areaSquare);
                double areaRactangle = s.area(5,10);
                Console.WriteLine("Area of Ractangle is :  " + areaRactangle);
                double areaCircle = s.area(5);
                Console.WriteLine("Area of Circle is :  " + areaCircle);
               
            }
            void Overriding()
            {
                ICICI i = new ICICI();
                HDFC h = new HDFC();
                SBI s  = new SBI();
                RBI r = new RBI();

                i.CalculateInterest(10,10,10);
                h.CalculateInterest(10,10,10);
                s.CalculateInterest(10,10,10);
                r.CalculateInterest(10,10,10);
            }

            void HospitalOverriding()
            {
                Apollo apollo  = new Apollo();
                Wockhardt wockhart = new Wockhardt();
                Gokul_Superspeciality gokul = new Gokul_Superspeciality();

                apollo.HospitalDetails();
                wockhart.HospitalDetails();
                gokul.HospitalDetails();
            }

            void Calc()
            {
                Cal calculator;

                Console.WriteLine("Select an operation: +, -, *, /");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        calculator = Calculator.Add;
                        break;
                    case '-':
                        calculator = Calculator.Subtract;
                        break;
                    case '*':
                        calculator = Calculator.Multiply;
                        break;
                    case '/':
                        calculator = Calculator.Divide;
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        return;
                }

                Console.WriteLine($"Result: {calculator(num1, num2)}");
            }

            void traffic()
            {
                TrafficDel yellow = new TrafficDel(TrafficSignal.Yellow);
                TrafficDel green = new TrafficDel(TrafficSignal.Green);
                TrafficDel red = new TrafficDel(TrafficSignal.Red);

                yellow();
                green();
                red();
            }

            void rbi()
            {
                HDFC h = new HDFC();
                SBI s = new SBI();
                ICICI i = new ICICI();
                RBI r = new RBI();

                h.CalculateInterest(10,20,30);
                s.CalculateInterest(10,20,30);
                i.CalculateInterest(10,20,30);
                r.CalculateInterest(10,20,30);

            }
        }

        
    }
}
