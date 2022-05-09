using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1_Notes.ExpDelegate
{
    public delegate int Multiplier(int x);

    public delegate int ExampleDelegate();

    public class ExpDelegates
    {
        // Defining a compatible method or function
        public int SquareArea(int side)
        {
            return side * side;
        }

        // Defining a compatible method or function
        public int ObjectCapacity(int side)
        {
            return 2 * side;
        }

        public int SomeRandomFunction()
        {
            return 5;
        }

        // ------------

        public void SimpleDelegateCaller()
        {
            CallSimpleDelegate();
        }

        private void CallSimpleDelegate()
        {
            // Creating a delegate instance
            Multiplier m = SquareArea;

            // Written above is the shorter version of this...
            // It's still creating a delegate instance (just slightly more complicated looking)
            Multiplier m2 = new Multiplier(SquareArea);

            // Invoking the delegate => invokes the method
            int area = m(5);
            // Above is a short hand way of the following...
            int area2 = m.Invoke(6);

            Console.WriteLine("[ CallSimpleDelegate() ] Area is: " + area);
        }

        public void CallDelegateFor(bool isSquare)
        {
            if (isSquare)
            {
                Multiplier m = SquareArea;
                int area = m(5);
                Console.WriteLine("[ CallDelegateFor() ] Area is: " + area);
                return;
            }
            Multiplier o = ObjectCapacity;
            int result = o(6);
            Console.WriteLine("[ CallDelegateFor() ] Obj capacity is: " + result);
        }
    }
}
