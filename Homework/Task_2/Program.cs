using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department(4,
                                    new List<Employee>
                                     {
                                         new Employee("Ivan", 250),
                                         new Employee("Vasya", 300),
                                         new Employee("Dima", 500),
                                         new Employee("Misha", 300)
                                     });

            department.Print();
            Console.WriteLine(new string('-', 30));

            try
            {
                department.AddEmployee(new Employee());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
