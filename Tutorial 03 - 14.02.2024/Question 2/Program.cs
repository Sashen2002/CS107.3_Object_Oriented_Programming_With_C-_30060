using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute3._2
{
    internal class Program
    {
        class Employee
        {
            // Private fields
            private int _employeeID;
            private string _fullName;
            private double _salary;

            // Properties
            public int EmployeeID => _employeeID; // read-only property for employee ID
            public string FullName { get => _fullName; set => _fullName = value; } // read-write property for full name
            public double Salary => _salary; // read-only property for salary

            // Constructor
            public Employee(int id, string fullName, double salary)
            {
                _employeeID = id;
                _fullName = fullName;
                _salary = salary;
            }

            // Method to update salary
            public void UpdateSalary(double newSalary)
            {
                _salary = newSalary;
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
                // Create an instance of the Employee class
                Employee employee = new Employee(101, "John Doe", 50000);

                // Display the employee ID using the read-only property
                Console.WriteLine("Employee ID: " + employee.EmployeeID);

                // Update the full name of the employee using the read-write property
                employee.FullName = "Sashen Daniel";
                Console.WriteLine("Updated Full Name: " + employee.FullName);

                // Attempt to modify the salary directly from external code
                // This will result in a compilation error because the Salary property has a private setter
                // Uncommenting the line below will result in a compilation error
                // employee.Salary = 60000;

                // Instead, we can update the salary using the UpdateSalary method
                employee.UpdateSalary(60000);
                Console.WriteLine("Updated Salary: " + employee.Salary);

                Console.ReadLine();
            }
        }
    }
}
