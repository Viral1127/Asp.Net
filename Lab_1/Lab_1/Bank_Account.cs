using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Bank_Account
    {
        int Account_No;
        string Email;
        string User_Name;
        string Account_Type;
        int Account_Balance;
        public void GetAccountDetails()
        {
            Console.WriteLine("Enter account number :  ");
            Account_No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter email :  ");
            Email = Console.ReadLine();

            Console.WriteLine("Enter user name :  ");
            User_Name = Console.ReadLine();

            Console.WriteLine("Enter account type :  ");
            Account_Type = Console.ReadLine();

            Console.WriteLine("Enter account balance :  ");
            Account_Balance = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("-------------------------Account Details---------------------------");
            Console.WriteLine("account number :  " + Account_No);
            Console.WriteLine("email :  " + Email);
            Console.WriteLine("user name :  " + User_Name);
            Console.WriteLine("account type :  " + Account_Type);
            Console.WriteLine("account balance :  " + Account_Balance);
        }
    }
}
