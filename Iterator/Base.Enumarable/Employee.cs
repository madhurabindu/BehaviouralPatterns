using System;
using System.Collections.Generic;

namespace Base.Enumarable
{
    public class Employee
    {
        public Employee()
        {
            Department = "UnAssigned";
            Designation = "UnAssigned";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0, -5}, Name: {1, -10}, Department: {2, -15}, Designation: {3}", Id, Name, Department, Designation);
        }
    }
}
