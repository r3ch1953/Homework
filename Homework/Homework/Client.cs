using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Client
    {
        private string name;
        private string number;

        public string Name { get => name; set => name = value; }
        public string Number
        {
            get => number; 

            set
            { 
                for(char i = 'a', j = 'A'; i <= 'z'; i++, j++)
                {
                    if (value.Contains(i) || value.Contains(j))
                        return;
                }

                number = value;
            }
        }

        public Client(string name = "Noname", string number = "0")
        {
            Name = name;
            Number = number;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Client))
                return false;
            return ((Client)obj).Name == this.Name && ((Client)obj).Number == this.Number;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Number: {Number}";
        }
    }
}
