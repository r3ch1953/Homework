using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Roof : IPart
    {
        private string material;
        private PartStatus status;

        public string Material { get => material; set => material = value; }
        public PartStatus Status { get => status; set => status = value; }

        public Roof(string material = "Metal tile", PartStatus status = PartStatus.INPROCESS)
        {
            Material = material;
            Status = status;
        }

        public override string ToString()
        {
            return ($"Roof, material: {material}, Status: {Status.ToString()}");
        }
    }
}
