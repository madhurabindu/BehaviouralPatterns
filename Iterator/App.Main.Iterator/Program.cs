using System;

using Base.Enumarable;

namespace App.Main.Iterator
{

    class MainApp

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            EmployeeList a = new EmployeeList();
            a[0] = new Employee() { Id = 1001, Name = "Tom Hanks", Department="Movies", Designation="Producer"};
            a[1] = new Employee() { Id = 1002, Name = "Tom Cat", Department = "Software", Designation = "Developer" };
            a[2] = new Employee() { Id = 1003, Name = "Tom Cruise", Department = "Action", Designation = "Stunt man" };
            a[3] = new Employee() { Id = 1004, Name = "Tom Bangs", Department = "Music", Designation = "Composer" };
            a[4] = new Employee() { Id = 1005, Name = "Tom Chills", Department = "Entertainment", Designation = "Comedian" };
            a[5] = new Employee() { Id = 1006, Name = "New Joinee"};

            // Create Iterator and provide aggregate

            Base.Enumarable.Iterator i = a.CreateIterator();
            Console.WriteLine("\nIterating over Employee collection:\n");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}
    