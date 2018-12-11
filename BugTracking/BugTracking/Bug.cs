using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class Bug : Task
    {
        public Task Feature { get; set; }

        public Bug(string description, int complexity, Task feature = null, double priority = 2)
            : base(description, complexity, priority)
        {
            Feature = feature;
        }
    }
}
