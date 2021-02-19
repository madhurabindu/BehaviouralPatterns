using System;
using System.Collections;
using Base.Interface;
using Imp.CRMSteps;

namespace App.Main.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Example for Chain Of Responsibility pattern------------");
            var temp = Console.ForegroundColor;

            Hashtable metaData = new Hashtable();
            metaData["connectionString"] = "SQLConnectionString";
            
            ICRMStep root = new CRMDBHandler(metaData, 
                new CRMAllocator(metaData, 
                new CRMNotifier(metaData, null)));

            CRMData data = new CRMData();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlease Raise Your Request Here");

            Console.WriteLine("\nPlease Enter your name and Email ID");
            Console.ForegroundColor = temp;
            data.RaisedBy = Console.ReadLine();
            data.RaisedByEmail = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlease Enter CRM Type : [Complaint, ChangeRequest, Enquiry, Feedback]");
            Console.ForegroundColor = temp;
            string type = Console.ReadLine();
            data.CRMType = (CRMData.Type)CRMData.Type.Parse(typeof(CRMData.Type), type);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlease Enter the Department : [IT / SW / HR]");
            Console.ForegroundColor = temp;
            data.OrgDept = new Department() { Name = Console.ReadLine() };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlease Enter Your {0}", type);
            Console.ForegroundColor = temp;
            data.RequestDescription = Console.ReadLine();

            root.RaiseRequest(data);

        }
    }
}
