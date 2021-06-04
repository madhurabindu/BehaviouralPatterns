using Base.MobilePlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Main.NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            string ans = "n";
            do
            {
                Console.WriteLine("Enter the plan you have selected");
                Console.WriteLine("1. Talk too much a 28 days plan, wih unlimited talk time");
                Console.WriteLine("2. Talk too much a 100 days plan, with unlimited talk time");
                Console.WriteLine("3. Take a Postpaid for a month");
                Console.WriteLine("4. Or Postpaid for a year");

                string option = Console.ReadLine();
                var plan = factory.GetPlan(option);
                PrintPlan(plan);

                Console.WriteLine("Do you want to confirm this plan?");
                ans = Console.ReadLine();
                Console.WriteLine();
            } while (ans != "y" && ans != "yes");
        }

        private static void PrintPlan(IMobilePlan plan) 
        {
            Console.WriteLine("==================================");
            Console.WriteLine("You plan details is.. ");
            Console.WriteLine("==================================");
            Console.Write("Plan Name: ");
            
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", plan.Name);
            Console.ForegroundColor = color;

            Console.WriteLine("Plan Rate: {0}", plan.Rate);
            Console.WriteLine("Number of Free SMS: {0}", plan.SMSRate);
            Console.WriteLine("Valid for: {0} days", plan.NumberOfDays);
            Console.WriteLine("==================================");
            Console.WriteLine();
        }
    }
}
