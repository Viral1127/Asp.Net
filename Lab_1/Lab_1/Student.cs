using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Student
    {
        int Enrollment_No;
        string Student_Name;
        int Semester;
        double CPI;
        double SPI;

        public Student()
        {
            Console.WriteLine("enter enrollment number :  ");
            Enrollment_No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter student name :  ");
            Student_Name = Console.ReadLine();

            Console.WriteLine("Enter semester :  ");
            Semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter CPI :  ");
            CPI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter SPI :  ");
            SPI = Convert.ToDouble(Console.ReadLine());
        }

        public void displayStudent()
        {
            Console.WriteLine("----------------------------Student Details------------------");
            Console.WriteLine("Enrollment number no :  " + Enrollment_No);
            Console.WriteLine("Student Name :  " + Student_Name);
            Console.WriteLine("Semester :  "+Semester);
            Console.WriteLine("CPI :  " + CPI);
            Console.WriteLine("SPI :  "+SPI);

        }
    }
}
