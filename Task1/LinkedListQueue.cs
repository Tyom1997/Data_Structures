using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class LinkedListQueue<T>
    {
        LinkedList<T> listqueue = new LinkedList<T>();
        public int Count()
        {
            return listqueue.Count;
        }
        public bool IsEmpty()
        {
            return listqueue.Count < 0;
        }
        public void Reverse()
        {
            listqueue.Reverse();
        }
        public void Enqueue(T member)
        {
            listqueue.Addlast(member);
        }
        public void Dequeue()
        {

        }
    }
}
