using System;
using Day_2_Notes.Generics;

namespace Day_2_Notes
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReviewGenerics();
            UnderstandFuncDelegate();
        }

        public static void ReviewGenerics()
        {
            // Generic variable for int
            var intStack = new GenericStack<int>();

            for (int i = 0; i < 101; i++)
            {
                try
                {
                    intStack.Push(i);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }                
            }

            for (int i = 0; i < 101; i++)
            {
                try
                {
                    var val = intStack.Pop();
                    Console.Write(val + "-");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            // Generic variable for string
            var stringStack = new GenericStack<string>();
        }

        public static void UnderstandFuncDelegate()
        {
            var values = new int[5] { 0, 1, 2, 3, 4 };
            var funcDelegate = new FuncDelegate();
            funcDelegate.RunCalculation<int>(values, funcDelegate.Calculate);
            funcDelegate.RunCalculation<int>(values, Calculate2);
        }

        public static int Calculate2(int c)
        {
            return 2 * c * c;
        }
    }
}
