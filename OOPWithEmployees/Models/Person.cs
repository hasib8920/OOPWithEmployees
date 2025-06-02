using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithEmployees.Models
{
    public abstract class Person
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime DateOfBirth { get; set; }
        public Person(string name, DateTime dateofbirth)
        {
           this.Name = name;
            this.DateOfBirth= dateofbirth;
        }
        public abstract int Age();
    }
}
