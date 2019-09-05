using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class QuickSort<T> where T:IComparable<T>
    {
        void Swap(T[] items, int left, int right)
        {
            if (left != right)
            {
                T temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }
        Random pivotRng = new Random();
        public void Sort(T[] items)
        {
            Quicksort(items, 0, items.Length - 1);
        }
        private void Quicksort(T[] items, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = pivotRng.Next(left, right);
                int newPivot = Partition(items, left, right, pivotIndex);

                Quicksort(items, left, newPivot - 1);
                Quicksort(items, newPivot + 1, right);
            }
        }
        private int Partition(T[] items, int left, int right, int pivotIndex)
        {
            T pivotValue = items[pivotIndex];
            Swap(items, pivotIndex, right);
            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }
            Swap(items, storeIndex, right);
            return storeIndex;
        }
    }
}
