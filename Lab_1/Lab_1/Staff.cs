using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Staff
    {
        
        string name;
        string department;
        string designation;
        string experience;
        int salary;
        public void GetStaffDetails()
        {
            Console.WriteLine("Enter staff name :  ");
            name = Console.ReadLine();

            Console.WriteLine("Enter department name :  ");
            department = Console.ReadLine();

            Console.WriteLine("Enter designation :  ");
            designation = Console.ReadLine();

            Console.WriteLine("Enter experience :  ");
            experience = Console.ReadLine();

            Console.WriteLine("Enter salary :  ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("Staff name :  " +name);
            Console.WriteLine("deparment:  " + department);
            Console.WriteLine("designation :  " + designation);
            Console.WriteLine("experience :  " + experience);
            Console.WriteLine("salary :  " + salary);
        }

        public string GetPost() {
            return designation;
        }
    }
}

