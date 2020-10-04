using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    enum PartStatus
    {
        DONE,
        INPROCESS
    }

    interface IPart
    {
        string Material { get; set; }

        PartStatus Status { get; set; }
    }
}
