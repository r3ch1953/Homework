using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Department
    {
        public List<Employee> Employees { get; set; }
        public int DepartmentCapacity { get; set; } // визначає максимальну кількість працівників в відділі

        public Department(int departmentCapacity = 5, List<Employee> employees = null)
        {
            DepartmentCapacity = departmentCapacity;

            if (employees != null)
            {
                Employees = employees;
            }
            else
            {
                Employees = new List<Employee>();
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (Employees.Count + 1 > DepartmentCapacity)
                throw new Exception("Department full");
            Employees.Add(employee);
        }

        public void DelEmployee(Employee employee)
        {
            if (Employees.Count == 0)
                throw new Exception("List is empty");
            Employees.Remove(employee);
        }

        public void Print()
        {
            Console.WriteLine("Department info: ");
            foreach (var item in Employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
