using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class MergeSort
    {
        public int[] Sort(int[] array)
        {
            return MSort(array, 0, array.Length - 1);
        }
        private int[] MSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                int middleIndex = (lowIndex + highIndex) / 2;
                MSort(array, lowIndex, middleIndex);
                MSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }
            return array;
        }
        private void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            int left = lowIndex;
            int right = middleIndex + 1;
            int[] tempArray = new int[highIndex - lowIndex + 1];
            int index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }
                index++;
            }
            for (int i= left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (int i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
    }
}
