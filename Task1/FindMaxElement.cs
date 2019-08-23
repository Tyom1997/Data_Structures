using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class FindMaxElement
    {
        public int FindMaximum(int[] array)
        {
            int index = 0;
            int max = array[0];
            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i] > max) 
                    max = array[i];

                if (max == array[i])
                {
                    index = i + 1;
                }
            }
            return index;
        }
    }
}
