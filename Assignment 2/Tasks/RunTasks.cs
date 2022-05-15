using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2.Tasks
{
    public class RunTasks
    {
        public void TaskFunction()
        {
            int[] sumArr = new int[100];
            int[] lastNumArr = new int[100];

            int sum = 0;
            int lastNum = 0;

            for (int i = 1; i <= 100; i++)
            {
                // Task A adds all the numbers up
                Task taskA = Task.Run(() =>
                {                  
                    sum += i;
                    lastNum = sum;

                    sumArr[i - 1] = sum;
                    lastNumArr[i - 1] = lastNum;

                });
                // Waits for taskA to finish before moving on
                taskA.Wait();

                // Task B prints the sum of each iteration
                Task taskB = Task.Run(() =>
                {
                    Console.WriteLine("{0} + {1} = {2}", i, lastNumArr[i - 1], sumArr[i - 1]);
                });
                // Waits for taskB to finish before moving on
                taskB.Wait();


                // Task C writes the sum to a file at each iteration
                Task taskC = Task.Run(() =>
                {
                    string filePath = "../../../Tasks/data.txt";

                    string stringInput = "Sum: " + i.ToString() + " + " + lastNumArr[i - 1].ToString() + " = " + sumArr[i - 1].ToString() + Environment.NewLine;

                    if (!File.Exists(filePath))
                    {
                        File.WriteAllText(filePath, stringInput);
                    }
                    else
                    {
                        File.AppendAllText(filePath, stringInput);
                    }
                });
                taskC.Wait();

                Console.WriteLine("Saved sum #{0} to the file!\n", i);
            }
            
        }
    }
}