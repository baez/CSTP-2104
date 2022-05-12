using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2_Notes.Generics
{
    public class GenericStack<T>
    {
        private const int initialSize = 100;
        private int position;
        private T[] data = new T[initialSize];

        // ------------------------------------

        public void Push(T obj)
        {
            if (this.position > initialSize - 1)
            {
                throw new InvalidOperationException("Stack is full");
            }
            data[this.position++] = obj;
        }

        public T Pop()
        {
            if (this.position == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return this.data[this.position--];
        }

        public bool HasItems()
        {
            if (this.position > 0)
            {
                return true;
            }
            return false;

            //return this.position > 0;
        }

        public bool IsFull()
        {
            if (this.position == initialSize)
            {
                return true;
            }
            return false;

           //return this.position == initialSize;
        }
    }
}
