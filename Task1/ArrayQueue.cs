using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class ArrayQueue<T>
    {
        private T[] array;
        private T[] array1;
        private int index = -1;
        public int Count { get; private set; }
        public bool IsEmpty()
        {
            return Count < 0;
        }
        public ArrayQueue(int capacity)
        {
            array = new T[capacity];
            array1 = new T[capacity];
        }
        public void Enqueue(T member)
        {
            if (array.Length < index)
            {
                throw new Exception();
            }
            array[++index] = member;
            Count++;
        }
        public T Dequeue()
        {
            if (Count < 0)
            {
                throw new Exception();
            }
            Count--;
            array[0] = default(T);
            return array[0];
        }
        public T Peek()
        {
            if (index < 0)
            {
                throw new Exception();
            }
            return array[0];
        }
        public T Reverse()
        {
            
            int j = 0;
            for(int i = Count-1; i>=0; i--)
            {
                array1[j] = array[i];
                j++;
            }
            return array1[j];
        }
        public void PrintQueue()
        {
            for(int i = 0; i < Count; i++)
            {
                Console.WriteLine(array[i]+" ");
            }
        }
        public void PrintReverseQueue()
        {
            for (int j = 0; j < Count; j++)
            {
                Console.Write(array1[j] + " ");
            }
        }

    }
}
