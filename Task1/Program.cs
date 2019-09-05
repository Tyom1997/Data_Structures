using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapSort s = new HeapSort();
            int[] arr = { 9, 8, 7, 6, 4, 3, 2, 1 };
            s.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            } 
        }
    }
}
