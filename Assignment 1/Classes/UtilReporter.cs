using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Assignment_1.Classes
{
    // Declaring a delegate
    public delegate void ProgressReporter(int x);

    public class UtilReporter
    {
        public void ReportProgress(int x)
        {
            ProgressReporter printer = WriteProgressToConsole;
            ProgressReporter saveFile = WriteProgressToFile;

            for (int i = 0; i <= 10; i++)
            {
                System.Threading.Thread.Sleep(100);
                printer(i * 10);
                saveFile(i * 10);
            }
        }

        public void WriteProgressToConsole(int x)
        {
            Console.WriteLine(x);
        }

        public void WriteProgressToFile(int x)
        {

            string filePath = "../../../Classes/data.txt";
            string stringInput = x.ToString() + Environment.NewLine;

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, stringInput);
            }
            else
            {
                File.AppendAllText(filePath, stringInput);
            }
        }
    }
}