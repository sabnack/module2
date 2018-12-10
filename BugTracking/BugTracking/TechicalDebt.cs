using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class TechicalDebt:Task
    {
        public const double Priority = 0.5;

        public TechicalDebt(int number, string description, int complexity)
            : base( number, description, complexity)
        {
        }
    }
}
