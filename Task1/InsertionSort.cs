using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class InsertionSort<T> where T:IComparable<T>
    {
        static void Swap(ref T e1, ref T e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        public T[] Sort(T[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i-1;
                while ((j >= 0) && (array[j].CompareTo(key)==1))
                {
                    Swap(ref array[j + 1] ,ref array[j]);
                    j--;
                }
                array[j+1] = key;
            }
            return array;
        }
        public void Show(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
