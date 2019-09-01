using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class BubbleSort<T> where T:IComparable<T>
    {
        private  void Swap(ref T num1,ref T num2)
        {
            var val = num1;
            num1 = num2;
            num2 = val;
        }
        public  T[] Sort(T[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j <len-i ; j++)
                {
                    if (array[j].CompareTo(array[j+1])==1)
                    {
                        Swap(ref array[j],ref array[j + 1]);
                    }
                }
            }

            return array;
        }
        public void Show(T[] arr)
        {
            for(int i = 0; i < arr.Length; i++) 
                Console.Write(arr[i] + " ");
        }
    }
}
