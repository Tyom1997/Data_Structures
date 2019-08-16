using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class LinkedListStack<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        public void Push(T member)
        {
            list.Addfirst(member);
        }
        public T Pop()
        {
            if (list.Count < 0)
            {
                throw new Exception();
            }
        }
        public T Peek()
        {
            if (list.Count < 0)
            {
                throw new Exception();
            }
            return list.RemoveFirst();
        }
        public void Reverse()
        {
            list.Reverse();
        }
        public int Count()
        {
            return list.Count;
        }
        public bool IsEmpty()
        {
            return list.Count < 0;
        }
    }
}
