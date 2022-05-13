using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sumArr = new int[100];
            int[] lastNumArr = new int[100];

            // Task A adds all the numbers up
            Task taskA = Task.Run(() =>
            {
                int sum = 0;
                int lastNum = 0;

                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                    lastNum = sum;
                    
                    sumArr[i - 1] = sum;
                    lastNumArr[i - 1] = lastNum;
                }
                
            });
            // Waits for taskA to finish before moving on
            taskA.Wait();

            // Task B prints the sum of each iteration
            Task taskB = Task.Run(() =>
            {
                Console.WriteLine("Hi");
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("{0} + {1} = {2}", i, lastNumArr[i-1], sumArr[i - 1]);
                }
            });
            // Waits for taskB to finish before moving on
            taskB.Wait();


            // Task C writes the sum to a file at each iteration
            Task taskC = Task.Run(() =>
            {
                string filePath = "../../../data.txt";
                
                for (int i = 1; i <= 100; i++)
                {
                    string stringInput = "Sum: " + i.ToString() + " + " + lastNumArr[i - 1].ToString() + " = " + sumArr[i - 1].ToString() + Environment.NewLine;

                    if (!File.Exists(filePath))
                    {
                        File.WriteAllText(filePath, stringInput);
                    }
                    else
                    {
                        File.AppendAllText(filePath, stringInput);
                    }
                }                
            });
            taskC.Wait();

            Console.WriteLine("\nSaved data to file!");
        }    
    }
}
