using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class CountingSort
    {
        public void Sort(int[] array)
        {
            int length = array.Length;
            int[] output = new int[length];
            int[] count = new int[100];
            for (int i = 0; i < 100; ++i)
            {
                count[i] = 0;
            }
            for (int i = 0; i < length; ++i)
            {
                ++count[array[i]];
            }
            for (int i = 1; i <= 99; ++i)
            {
                count[i] += count[i - 1];
            }
            for (int i = length - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                --count[array[i]];
            }
            for (int i = 0; i < length; ++i)
            {
                array[i] = output[i];
            }
        }
    }
}
