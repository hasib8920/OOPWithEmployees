using OOPWithEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new Employees(1, DateTime.Now, Grades.Junior, "John Doe", new DateTime(1990, 1, 1));
            employee.AddRoles("Developer", "Tester", "Team Lead");
            Console.WriteLine(employee.ToString());
            Console.WriteLine($"Employee Age: {employee.Age()} years");
            Console.WriteLine($"Employee Roles: {employee.GetRoles()}");
            Console.WriteLine(employee);
            Console.ReadLine();
        }
    }
}
