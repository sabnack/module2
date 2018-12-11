using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class Feature : Task
    {
        public Feature(string description, int complexity, double priority = 1)
            : base(description, complexity, priority)
        {
        }
    }
}
