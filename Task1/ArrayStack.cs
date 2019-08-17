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
        public T Reverse()
        {
            int j = 0;
            for (int i = Count - 1; i >= 0; i--)
            {
                array1[j] = array[i];
                j++;
            }
            return array1[j];
        }
        public void PrintStack()
        {           
            for(int i = 0; i < Count; i++)
            {
                Console.Write(array[i]+" ");
            }           
        }
        public void PrintReverseStack()
        {
            for (int j = 0; j < Count; j++)
            {
                Console.Write(array1[j] + " ");
            }
        }
       
    }
}
