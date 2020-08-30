using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundTask
{
    public class BackgroundTasksQueue
    {
        private Task previousTask = Task.FromResult(true);
        private object key = new object();
        public void QueueTask(Action action)
        {
            lock (key)
            {
                previousTask = previousTask.ContinueWith(t => action()
                    , CancellationToken.None
                    , TaskContinuationOptions.None
                    , TaskScheduler.Default);
            }
        }

    }
}
