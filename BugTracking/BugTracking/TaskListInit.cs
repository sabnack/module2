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
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int choice = rnd.Next(3);

                switch (choice)
                {
                    case 0:
                        tasksList.Add(new Feature("Feature", new Random().Next(1, 4)));
                        break;
                    case 1:
                        tasksList.Add(new Bug("Bug", new Random().Next(1, 4)));
                        break;
                    case 2:
                        tasksList.Add(new TechicalDebt("TechDebt", new Random().Next(1, 4)));
                        break;
                }
            }
            return tasksList;
        }
    }
}
