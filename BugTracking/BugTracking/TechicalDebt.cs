using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class TechicalDebt : Task
    {
        public TechicalDebt(string description, int complexity, double priority = 0.5)
            : base(description, complexity, priority)
        {
        }
    }
}
