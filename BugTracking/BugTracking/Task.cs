using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    abstract class Task
    {
        public int Number { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Complexity { get; set; }


    }
}
