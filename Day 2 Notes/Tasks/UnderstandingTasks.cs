using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day_2_Notes.Tasks
{
    public class UnderstandingTasks
    {
        public void RunTasks()
        {
            Task.Run(() => Console.WriteLine("Hello task!"));

            new Thread(() => Console.WriteLine("Init")).Start();
            Task task = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("This is a task running {0}", Thread.CurrentThread.ManagedThreadId);
                // throw new Exception("Task is crashing error!!!");
            });
            Console.WriteLine("Continue... {0}", Thread.CurrentThread.ManagedThreadId);
            try
            {
                task.Wait();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Task<int> task2 = Task.Run(() =>
            {
                var res = 5;
                Console.WriteLine("Resin task2 {0} th:{1}", res);
                return res;
            });

            PrintWait();
            int task2Result = task2.Result;
            Console.WriteLine("Task 2 Result = {0} - th:{1}", task2Result, Thread.CurrentThread.ManagedThreadId);
        }
        
        public void PrintWait()
        {
            var s = true;
            for (int i = 0; i < 10; i++)
            {
                if (s)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("|");
                }
                s = !s;
            }
        }

        public async Task<int> DoSomething()
        {
            await Task.Delay(500);
            return 7;
        }
    }
}
