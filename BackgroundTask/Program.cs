using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BackgroundTasksQueue backgroundQueue = new BackgroundTasksQueue();
                backgroundQueue.QueueTask(Copy1);
                backgroundQueue.QueueTask(Copy2);

                var a = 1;
                var b = 2;

                Console.ReadLine();
            }

            catch (Exception ex)
            {

            }


            //BackgroundWorker worker = new BackgroundWorker();

            //BackgroundQueue


            //BackgroundTask backgroundTask = new BackgroundTask();
            //backgroundTask.AddTask(Copy1);
            //backgroundTask.AddTask(Copy2);

            //backgroundTask.ExecuteTasks();


        }


        static async private void Copy1()
        {
            string sourceFile = @"C:\Users\taruna\Desktop\Test\Source\a.zip";
            string destinationFile = @"C:\Users\taruna\Desktop\Test\Destination\a.zip";

            System.IO.File.Copy(sourceFile, destinationFile, true);
        }
        static private void Copy2()
        {
            string sourceFile = @"C:\Users\taruna\Desktop\Test\Source\b.zip";
            string destinationFile = @"C:\Users\taruna\Desktop\Test\Destination\b.zip";

            System.IO.File.Copy(sourceFile, destinationFile, true);
        }
    }
}

