using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int lastValue = 0;
            for (int i = 1; i <= 100; i++)
            {
                num += i;
                Console.WriteLine("{0} + {1} = {2}", i, lastValue, num);
                lastValue = num;
            }
        }
    }
}
