using System;
using System.Collections.Generic;

// Hard coded logic (Employee Object)
namespace Hardcoded
{

    class Program
    {
        static void Main()
        {
            List<Employee> listEmployees = new List<Employee>();

            listEmployees.Add(new Employee { Id = 101, Name = "Hema", Salary = 85000.00, Experience = 3 });
            listEmployees.Add(new Employee { Id = 103, Name = "Laxmi", Salary = 65000.00, Experience = 2 });
            listEmployees.Add(new Employee { Id = 102, Name = "Obul", Salary = 95000.00, Experience = 4 });
            listEmployees.Add(new Employee { Id = 105, Name = "Nagendra", Salary = 86000.00, Experience = 5 });

            Employee.PrintPromotableEmployees(listEmployees);
        }
    }

    // This Employee class is not a reusable class.
    // Every Organization having its own factors, to promote an employee
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public float Experience { get; set; }

        public static void PrintPromotableEmployees(List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Experience >= 3)
                    Console.WriteLine(emp);
            }
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Salary} - {Experience}";
        }
    }
}