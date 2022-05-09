using System;
using Day_1_Notes.ExpDelegate;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Week 1 - Delegates
            UnderstandingDelegates();
        }

        public static void UnderstandingDelegates()
        {
            var example = new ExpDelegates();
            example.SimpleDelegateCaller();

            example.CallDelegateFor(true);
            example.CallDelegateFor(false);

            var example2 = new DelegateConsumer();
            example2.ConsumeDelegate();
        }
    }
}