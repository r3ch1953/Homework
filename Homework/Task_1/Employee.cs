using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public Employee(string name, string position, int salary, string city, string street)
        {
            Name = name;
            Position = position;
            Salary = salary;
            City = city;
            Street = street;
        }

        public string GetFullInfo()
        {
            return $"Name: {Name}\nPosition: {Position}\nSalary: {Salary}\nAddress: c. {City}, st. {Street}";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
