using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Candidate
    {
        int id;
        String name;
        int age;
        double weight;
        double height;
    public void GetCandidateDetails()
        {
            Console.WriteLine("Enter candidate Id :  ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter candidate name :  ");
            name = Console.ReadLine();

            Console.WriteLine("Enter candidate age :  ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter candidate weight :  ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter candidate height :  ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("candidate id :  " + id);
            Console.WriteLine("candidate name :  " + name);
            Console.WriteLine("candidate age :  " +age);
            Console.WriteLine("candidate weight :  " + weight);
            Console.WriteLine("candidate height :  " + height);
        }
    }
}
