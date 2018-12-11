using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    abstract class Task
    {
        public static int Number { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Complexity { get; set; }
        public double Priority { get; set; }
        public int Id;

        public Task(string description, int complexity, double priority, string status = "ToDo")
        {
            Number++;
            Description = description;
            Status = status;
            Complexity = complexity;
            Priority = priority;
            Id = Number;
        }
    }
}
