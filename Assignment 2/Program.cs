using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using Assignment_2.Tasks;

namespace Assignment_2
{
    public class Program
    {
        public void Main(string[] args)
        {
            var x = new RunTasks();

            x.TaskFunction();
        }    
    }
}
