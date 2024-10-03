using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Select a program to run (1-10) or 0 to exit");
                Console.WriteLine("1 : Candidate");
                Console.WriteLine("2 : Staff");
                Console.WriteLine("3 : Account details");
                Console.WriteLine("4 : Student");
                Console.WriteLine("5 : Area of rectangle");
                Console.WriteLine("6 : Single Inheritance");
                Console.WriteLine("7 : Salary of Employee");
                Console.WriteLine("8 : Distance Addition");
                Console.WriteLine("9 : Furniture");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice) {
                    case 1:
                        RunCadidateProgram(); break;
                    case 2:
                        RunStaffProgram(); break;
                    case 3:
                        RunAccountProgram(); break;
                    case 4:
                        RunStudentProgram(); break;
                    case 5:
                        RunRectangleProgram();break;
                    case 6:
                        RunSingleInheritance();break;
                    case 7:
                        RunSalaryOfEmployee();break;
                    case 8:
                        RunDistanceProgram(); break;
                    case 9:
                        RunFurnitureProgram(); break;
                }
            }
            void RunCadidateProgram(){
                Candidate candidate = new Candidate();
                candidate.GetCandidateDetails();
                candidate.DisplayCandidateDetails();
             }

            void RunStaffProgram()
            {
                Staff[] staff = new Staff[2];

                for(int i = 0; i < staff.Length; i++)
                {
                    staff[i] = new Staff();
                    staff[i].GetStaffDetails();                    
                }
                for (int i = 0; i < staff.Length; i++)
                {
                    Console.WriteLine("-----------Staff details-------------");
                    if (staff[i].GetPost() == "HOD") {
                        staff[i].DisplayStaffDetails();
                    }
                    
                }
            }

            void RunAccountProgram()
            {
                Bank_Account account = new Bank_Account();
                account.GetAccountDetails();
                account.DisplayAccountDetails();
            }

            void RunStudentProgram()
            {
                Student student = new Student();
                student.displayStudent();
            }

            void RunRectangleProgram()
            {
                Console.WriteLine("Enter height of rectangle :  ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter width of retangle :  ");
                double width = Convert.ToDouble(Console.ReadLine());

                AreaOfRactangle area = new AreaOfRactangle(height,width);
                area.calculateArea();
            }

            void RunSingleInheritance()
            {
                Interest act1 = new Interest("101" , "viral" , 50000 ,2 );

                act1.displayActDetails();

                act1.displayInterest();
            }

            void RunSalaryOfEmployee()
            {
                Salary s1 = new Salary();
                s1.displaySalary();
            }

            void RunDistanceProgram()
            {
                Distance d1 = new Distance(50, 100.20);
                d1.calculateDistance();
            }

            void RunFurnitureProgram()
            {
                Console.WriteLine("Enter Furniture material :  ");
                string material = Console.ReadLine();
                Console.WriteLine("Enter price :  ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter table height in feet :  ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter surface of table :  ");
                double surface  = Convert.ToDouble(Console.ReadLine());
                Table t1 = new Table(material,price,height,surface);
                t1.displayFurniture();
            }
        }
    }
}
