using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class TaskListInit
    {
        List<Task> tasksList;

        public List<Task> GetTasksList()
        {
            tasksList = new List<Task>();

            tasksList.Add(new Feature());
            tasksList.Add(new Bug());
            tasksList.Add(new TechicalDebt());


            return tasksList;
        } 
    }
}
