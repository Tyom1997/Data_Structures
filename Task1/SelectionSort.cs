using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class SelectionSort<T> where T:IComparable<T>
    {
        private int MinElementIndex(T[] array, int index)
        {
            int result = index;
            for (int i = index; i < array.Length; ++i)
            {
                if (array[i].CompareTo(array[result]) < 1)
                {
                    result = i;
                }
            }
            return result;
        }
        private void Swap(ref T x, ref T y)
        {
            var t = x;
            x = y;
            y = t;
        }
        public T[] Sort(T[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;
            int index = MinElementIndex(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return Sort(array, currentIndex + 1);
        }
        public void Show(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
