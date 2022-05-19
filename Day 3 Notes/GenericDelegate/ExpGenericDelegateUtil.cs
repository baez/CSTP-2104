using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_3_Notes.GenericDelegate
{
    // Generics
    public delegate List<T> GenDelegate<T>(T[] arg);
    public delegate List<int> GenDelegate(int arg);

    public class ExpGenericDelegateUtil
    {
        public static void TestGenericDelegate()
        {
            string[] parts = { "123", "456", "7890" };
            var getDelegate = new GenDelegate<int>(GenDelFunc);
            int[] values = { 4, 5, 6, 7 };

            TakeAction(values, getDelegate);
        }

        public static void TakeAction<T>(T[] values, GenDelegate<T> genDelegate)
        {
            var result = genDelegate(values);

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(result.ElementAt(i));
            }
        }

        public static List<T> GenDelFunc<T>(T[] arg)
        {
            return arg.ToList();
        }
    }
}
