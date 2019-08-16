using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class ArrayStack<T>
    {
        private T[] array;
        private int index = -1;
        public int Count { get; private set; }
        public ArrayStack(int capacity)
        {
            array = new T[capacity];
        }
        public bool IsEmpty()
        {
            return index == -1;
        }
        public void Push(T member)
        {
            if (index >= array.Length)
            {
                Console.WriteLine("Stack is ovverloaded");
            }
            else
            {
                array[++index] = member;
            }
            Count++;
        }
        public T Pop()
        {
            if (index < 0)
            {
                throw new Exception();
            }
            index--;
            array[index] = default(T);
            return array[index];
        }
        public T Peek()
        {
            if (index < 0)
            {
                throw new Exception();
            }
            return array[index];
        }
        public void Reverse()
        {
            
            T prev = default;
            T current = array[index];
            if (current == null)
            {
                return;
            }
            while (current != null)
            {
                T next = prev; 
                prev = current;
                current = next;
            }
            array[index] = prev;
        }
        public void Print()
        {
            for(int i = 0; i < Count; i++)
            {
                Console.Write(array[i]+" ");
            }           
        }
       
    }
}
