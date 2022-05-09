using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1_Notes.ExpDelegate
{
    public class DelegateConsumer
    {
        public static int ObjectCalculator2(int c)
        {
            return (c * c * c) / 2;
        }

        public void ConsumeDelegate()
        {
            var expDelegate = new ExpDelegates();
            Multiplier m1 = expDelegate.SquareArea;
            var result = m1(3);
            Console.WriteLine("Result [1]: " + result);

            var expDelegateCalculator = new ExpDelegateCalculator();
            Multiplier m2 = expDelegateCalculator.ObjectCapacityCalculator;

            // Using the same delegate to point to a different object's compatible method
            m1 = expDelegateCalculator.ObjectCapacityCalculator;
            result = m1(3);
            Console.WriteLine("Result [2]: " + result);

            m1 = ObjectCalculator2;
            result = m1(3);
            Console.WriteLine("Result [3]: " + result);


            Console.WriteLine("[ ConsumeDelegate() ] " + m2(5));
        }
        public void ConsumeMulticastDelegate()
        {
            var expDelegate = new ExpDelegates();
            Multiplier m1 = expDelegate.SquareArea;

            var expDelegateCalculator = new ExpDelegateCalculator();
            m1 += expDelegateCalculator.ObjectCapacityCalculator;

            m1(9);

            ExampleDelegate m2 = expDelegate.SomeRandomFunction;
            var r = m2();

            Console.WriteLine(r);
        }
    }
}
