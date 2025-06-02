using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithEmployees.Models
{
    public sealed class Employees : Person, Irole
    {
        private string[] roles;
        public Employees(int employeeid,DateTime joindate,Grades grade, string name, DateTime dateofbirth) : base(name, dateofbirth)
        {
            this.EmployeeId = employeeid;
            this.JoinDate = joindate;
            this.Grade = grade;
        }
        public int EmployeeId { get; set; }
        public DateTime JoinDate { get; set; }
        public Grades Grade { get; set; }

        public void AddRoles(params string[] roles)
        {
            this.roles = roles;
        }

        public override int Age()
        {
            return(DateTime.Now-DateOfBirth).Days / 365;
        }

        public string GetRoles()
        {
            return string.Join(", ", roles);
        }
        public override string ToString()
        {
            return $"Id:{EmployeeId},Name:{Name},Joined on:{JoinDate:yyyy-MM-dd},Grade:{Grade}" +
                $"Age:{Age()}, Role plays:{GetRoles()}";
        }
    }
}
