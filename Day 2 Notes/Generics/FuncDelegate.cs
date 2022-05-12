using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2_Notes.Generics
{
    public class FuncDelegate
    {
        // public delegate T Multiplier3(T);

        // Function that initializes a delegate in the parameter
        public void RunCalculation<T>(T[] values, Func<T, T> calculator)
        {
            for (int i = 0; i < values.Length; i++)
            {
                var res = calculator(values[i]);
                Console.WriteLine("res=" + res);
            }
        }

        public int Calculate(int c)
        {
            return c * c;
        }
    }
}
