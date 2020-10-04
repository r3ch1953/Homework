using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Basement : IPart
    {
        private string material;
        private PartStatus status;

        public string Material { get => material; set => material = value; }
        public PartStatus Status { get => status; set => status = value; }

        public Basement(string material = "Solid", PartStatus status = PartStatus.INPROCESS)
        {
            Material = material;
            Status = status;
        }

        public override string ToString()
        {
            return ($"Basement, material: {material}, Status: {Status.ToString()}");
        }
    }
}
