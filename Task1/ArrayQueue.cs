using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class ArrayQueue<T>
    {
        private T[] array;
        private int indexinput = -1;
        private int indexout = -1;
        public int Count { get; private set; }
        public bool IsEmpty()
        {
            return Count < 0;
        }
        public ArrayQueue(int capacity)
        {
            array = new T[capacity];
        }
        public void Enqueue(T member)
        {
            if (indexinput == indexout && indexout !=-1)
            {
                throw new Exception();
            }

            if (indexinput == array.Length - 1)
            {
                indexinput = 0;
            }
            else
                indexinput++;
            array[indexinput] = member;
            Count++;
        }
        public T Dequeue()
        {
            if (indexinput == indexout && indexinput != -1)
            {
                throw new Exception();
            }
            if (indexout == array.Length-1)
            {
                indexout =0;
            }
            else
            {
                indexout++;
            }
            var r = array[indexout];
            array[indexout] = default(T);
            Count--;
            return r;
        }
        public T Peek()
        {
                if (indexinput == indexout && indexinput != -1)
                {
                    throw new Exception();
                }
                if (indexout == array.Length - 1)
                {
                    indexout = 0;
                }
                else
                {
                    indexout++;
                }
                var r = array[indexout];
                return r;            
        }
        public void Reverse()
        {
            for (int i = 0; i <Count / 2; i++)
            {
                T tmp = array[i];
                array[i] = array[Count-i-1];
                array[Count - i - 1] = tmp;
            }            
        }
        public void PrintQueue()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
