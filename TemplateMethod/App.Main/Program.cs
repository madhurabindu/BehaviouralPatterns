using Base.Tlib;
using System;
using System.Threading;

namespace App.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var color = Console.ForegroundColor;

            Console.WriteLine("Review Tool");
            Console.WriteLine("1. FXCop");
            Console.WriteLine("2. Resharper");
            Console.Write("Enter the tool you would like to use : ");
            string input = Console.ReadLine();

            ReviewTool tool = CreateTool(input);
            Console.WriteLine();
            Console.Write("Select File to be Reviewed: ");
            string fileName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Blue;
            tool.PrepareForReview(fileName);
            Thread.Sleep(500);
            Console.WriteLine("---------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            tool.PerformReview("expert","expert@mycompany.com");
            Thread.Sleep(500);

            Console.WriteLine("Waiting for reviewer comments.......");
            Thread.Sleep(500);
            Console.WriteLine("---------------------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            tool.ConsolidateResult("", fileName);
            Console.WriteLine();
        }

        private static ReviewTool CreateTool(string option)
        {
            ReviewTool tool = null;
            if(option == "1")
            {
                tool = new FxCop();
            }
            else if(option == "2")
            {
                tool = new Resharper();
            }

            return tool;
        }
    }
}
