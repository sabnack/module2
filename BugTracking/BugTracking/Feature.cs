using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class Feature:Task
    {
        public const int Priority = 1;

        public Feature(int number, string description, int complexity)
            : base(number, description, complexity)
        {
        }
    }
}
