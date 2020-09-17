using System;
using SimpleListProject;

namespace BKIT_LAB3
{
    class SimpleStack<T> : SimpleList<T> 
        where T : IComparable
    {
        public void Push(T element)
        {
            Add(element);
        }

        public T Pop()
        {
            if (Count != 0)
            {
                T topElement = Get(Count - 1);
                if (Count != 1)
                {
                    last = GetItem(Count - 2);
                    last.next = null;
                }
                else
                {
                    first = null;
                    last = null;
                }
                --Count;
                return topElement;
            }
            throw new Exception("Impossible to get the element from empty stack");
        }
    }
}
