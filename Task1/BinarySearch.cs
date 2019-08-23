using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class BinarySearch
    {
        public  int BinarySearchItterative(int[] arr, int number)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int middle =(right - left) / 2;
                if (arr[middle] == number)
                    return middle;
                if (arr[middle] < number)
                    left= middle + 1; 
                else
                    right = middle - 1;
            }
            return -1;
        }
        public int BinarySearchRecursivly(int[] arr, int left, int right, int number)
        {
            if (right >= left)
            {
                int mid = (right + left) / 2;
                if (arr[mid] == number)
                    return mid;
                if (arr[mid] > number)
                    return BinarySearchRecursivly(arr, left, mid - 1, number);
                else
                    return BinarySearchRecursivly(arr, mid + 1, right, number);
            }
            return -1;
        }


    }
}
