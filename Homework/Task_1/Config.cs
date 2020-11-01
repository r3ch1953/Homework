using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Task_1
{
    public delegate void ConfigEvent(Config sender);
    public class Config
    {
        public List<string> Positions;
        public Dictionary<string, List<string>> Address;
        public List<Employee> Employees;
        public string Path { get; set; }

        public event ConfigEvent EmployeeAdded;
        public event ConfigEvent EmployeeDeleted;
        public event ConfigEvent PositionAdded;
        public event ConfigEvent AddressAdded;

        public Config()
        {
            Positions = new List<string>();
            Address = new Dictionary<string, List<string>>();
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            EmployeeAdded.Invoke(this);
        }

        public void DelEmployee(Employee employee)
        {
            Employees.Remove(employee);
            EmployeeDeleted.Invoke(this);
        }

        public void AddPosition(string position)
        {
            Positions.Add(position);
            PositionAdded.Invoke(this);
        }

        public void AddCity(string city)
        {
            Address.Add(city, new List<string>());
            AddressAdded.Invoke(this);
        }

        public void AddStreet(string city, string street)
        {
            if (Address.ContainsKey(city))
            {
                if (!Address[city].Contains(street))
                {
                    Address[city].Add(street);
                }
            }
            else
            {
                Address.Add(city, new List<string> { street });
            }
            AddressAdded.Invoke(this);
        }

        public void Save()
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        static public Config Load(string path)
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));
        }
    }
}
