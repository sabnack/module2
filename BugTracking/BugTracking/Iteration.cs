using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class Iteration
    {
        TaskListInit _taskListInit = new TaskListInit();
        List<Task> _tasksList = new List<Task>();
        List<Task> _temporaryList = new List<Task>();
        int _namberOfIterationItems = 3;
        int _namberIteration = 10;

        public Iteration()
        {
            _tasksList = _taskListInit.GetTasksList();
        }
    }
}
