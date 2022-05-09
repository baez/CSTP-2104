using System;
using Assignment_1.Classes;

namespace Assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Util = new UtilReporter();
            ProgressReporter report = Util.ReportProgress;

            report(2);
        }
    }
}