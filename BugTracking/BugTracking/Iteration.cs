using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class Iteration
    {
        TaskListInit _taskListInit { get; }
        List<Task> _tasksList { get; }
        List<Task> _temporaryList { get; }
        readonly int _namberOfIterationItems = 3;
        readonly int _namberIteration = 10;

        public Iteration()
        {
            _taskListInit = new TaskListInit();
            _tasksList = new List<Task>();
            _temporaryList = new List<Task>();
            _tasksList = _taskListInit.GetTasksList();
        }

        public void StartProgram()
        {
            for (int i = 0; i < _namberIteration; i++)
            {
                CreateTemporaryList();

                if (_temporaryList.Count == 0)
                {
                    Console.WriteLine("All task Done");
                    break;
                }

                Console.WriteLine("Iteration: {0} ", (i + 1));
                StartIteration();
                Console.WriteLine();

                if (i == _namberIteration - 1)
                {
                    Console.WriteLine("Iteration end");
                }
            }
        }

        public void CreateTemporaryList()
        {
            _temporaryList.Clear();
            for (int i = 0; i < _tasksList.Count; i++)
            {
                if (_tasksList[i].Status == "ToDo")
                {
                    _temporaryList.Add(_tasksList[i]);
                    _tasksList[i].Status = "InProgress";
                    if (_temporaryList.Count == _namberOfIterationItems)
                    {
                        break;
                    }
                }
            }
        }

        public void StartIteration()
        {
            foreach (var item in _temporaryList)
            {
                for (int i = 0; i < item.Complexity * item.Priority; i++)
                {
                    if (item is Feature)
                    {
                        if (new Random().Next(6) > 3)
                        {
                            item.Status = "Bug";

                            _tasksList.Add(new Bug("Bug" + (Task.Number + 1), new Random().Next(1, 4), item));
                            Console.WriteLine("Create Bug.");
                            break;
                        }
                    }
                    Console.WriteLine("ID:{0} - {1} - Iteration: {2}", item.Id, item.Description, (i + 1));
                }

                if (item.Status == "Bug")
                {
                    continue;
                }

                if (item is Bug item1)
                {
                    if (item1.Feature != null)
                    {
                        item1.Feature.Status = "Done";
                    }
                }
                item.Status = "Done";
            }
        }
    }
}
