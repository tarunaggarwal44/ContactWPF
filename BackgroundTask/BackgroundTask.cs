using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundTask
{
    public  class BackgroundTask
    {
        private List<Action> actions;

        public BackgroundTask()
        {
            actions = new List<Action>();
        }

        public void AddTask(Action action)
        {
            actions.Add(action);
        }

        public bool ExecuteTasks()
        {
            foreach(var action in actions)
            {
                action();
            }

            actions.Clear();
            return true;
        }
    }
}
