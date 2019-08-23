using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class ArrayStack<T>
    {
        private T[] array;
        private T[] array1;
        private int index = -1;
        public int Count { get; private set; }
        public ArrayStack(int capacity)
        {
            array = new T[capacity];
            array1 = new T[capacity];
        }
        public bool IsEmpty()
        {
            return index == -1;
        }
        public void Push(T member)
        {
            if (index >= array.Length)
            {
                throw new Exception();
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
            Count--;
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
            for (int i = 0; i < Count / 2; i++)
            {
                T tmp = array[i];
                array[i] = array[Count - i - 1];
                array[Count - i - 1] = tmp;
            }
        }
        public void PrintStack()
        {           
            for(int i = 0; i < Count; i++)
            {
                Console.Write(array[i]+" ");
            }           
        }
        
       
    }
}
