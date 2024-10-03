using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Account_Details
    {
        public string ActNo;
        public string ActName;
        public double Balance;

        public Account_Details(string actNo , string actName , double balance) { 
            ActNo = actNo;
            ActName = actName;
            Balance = balance;
        }

        public void displayActDetails()
        {
            Console.WriteLine("Account number :  " + ActNo);
            Console.WriteLine("Account Holdeer's Name :  " + ActName);
            Console.WriteLine("Account balance :  " + Balance);
        }
    }



    internal class Interest : Account_Details
    {
       public double rate;
        public Interest(string actNo, string actName, double balance, double rate) : base(actNo, actName, balance)
        {
            this.rate = rate;
        }

        public double calculateIntrest()
        {
            double intrest = (Balance *  rate)/100;
            return intrest;
        }

        public void displayInterest()
        {
            double interest = calculateIntrest();
            Console.WriteLine("Total intrest  =  " + interest);
        }
    }
}
