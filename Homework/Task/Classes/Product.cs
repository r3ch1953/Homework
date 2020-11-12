using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Classes
{
    public class Product
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public string Specification { get; set;}
        public float Price { get; set; }

        public Product(string name, string info, string specification, float price)
        {
            Name = name;
            Info = info;
            Specification = specification;
            Price = price;
        }

        public string GetFullInfo()
        {
            return $"Name: {Name}\nInfo: {Info}\nSpecification: {Specification}\nPrice: {Price}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
                return false;

            var p = obj as Product;

            return p.Name.Equals(Name) &&
                   p.Info.Equals(Info) &&
                   p.Specification.Equals(Specification) &&
                   p.Price.Equals(Price);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name} : {Price}";
        }
    }
}
