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

            tasksList.Add(new Feature(1, "feature1", 1));
            tasksList.Add(new Bug(2, "bug1", 1, null));
            tasksList.Add(new TechicalDebt(3, "TechDebt1", 1));
            tasksList.Add(new Feature(4, "feature2", 1));
            tasksList.Add(new Bug(5, "bug2", 1, null));
            tasksList.Add(new TechicalDebt(6, "TechDebt2", 1));


            return tasksList;
        } 
    }
}
