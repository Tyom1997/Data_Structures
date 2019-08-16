using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class ArrayQueue<T>
    {
        private T[] array;
        private int index = -1;
        public int Count { get; private set; }
        public ArrayQueue(int capacity)
        {
            array = new T[capacity];
        }
        
    }
}
