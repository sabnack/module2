using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class Bug:Task
    {
        public Task Feature { get; set; }
        public const int Priority = 2;

        public Bug(int number, string description, int complexity, Task feature)
            :base(number, description, complexity)
        {
            Feature = feature;
        }
    }
}
