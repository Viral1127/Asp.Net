using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("Hospital details");
        }
    }

    class Apollo : Hospital { 
        public  void HospitalDetails()
        {
            Console.WriteLine("Apollo hospital details");
        }
    }

    class Wockhardt : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("Wockhardt hospital details");
        }
    }

    class Gokul_Superspeciality : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality hospital details");
        }
    }



}
