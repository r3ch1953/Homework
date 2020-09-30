using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Employee
    {
        private string name;
        private int salary;

        public string Name
        {
            get => name;

            set
            {
                foreach (var item in value)
                {
                    if (!char.IsLetter(item))
                        throw new FormatException("Name contains digits or others symbols");
                }
                name = value;
            }
        }
        public int Salary
        { 
            get => salary;
            set
            {
                if (value < 0)
                    throw new FormatException("Salary lower then zero");
                salary = value;
            }
        }

        public Employee(string name = "Noname", int salary = 100)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name}, Salary: {Salary}";
        }
    }
}
