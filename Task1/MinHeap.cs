using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class MinHeap
    {
        private int[] members;
        private int size;
        public MinHeap(int capacity)
        {
            members = new int[capacity];
        }
        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = members[firstIndex];
            members[firstIndex] = members[secondIndex];
            members[secondIndex] = temp;
        }
        public void Add(int element)
        {
            if (size == members.Length)
                throw new IndexOutOfRangeException();

            members[size] = element;
            size++;
            HeapifyUp();
        }
        public int RemoveMin()
        {
            if (size == 0)
                throw new IndexOutOfRangeException();

            int result = members[0];
            members[0] = members[size - 1];
            size--;
            HeapifyDown();
            return result;
        }
        public int GetMin()
        {
            if (size == 0)
                throw new IndexOutOfRangeException();

            return members[0];
        }
        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int smallerIndex = LeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index) < LeftChild(index))
                {
                    smallerIndex = RightChildIndex(index);
                }
                if (members[smallerIndex] >= members[index])
                {
                    break;
                }
                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }
        private void HeapifyUp()
        {
            int index = size - 1;
            while (!HasRoot(index) && members[index] < Parent(index))
            {
                int parentIndex = ParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
        private int LeftChildIndex(int elementIndex) { return 2 * elementIndex + 1; }
        private int RightChildIndex(int elementIndex) { return 2 * elementIndex + 2; }
        private int ParentIndex(int elementIndex) { return (elementIndex - 1) / 2; }
        private bool HasLeftChild(int elementIndex) => LeftChildIndex(elementIndex) < size;
        private bool HasRightChild(int elementIndex) => RightChildIndex(elementIndex) < size;
        private bool HasRoot(int elementIndex) => elementIndex == 0;
        private int LeftChild(int elementIndex) { return members[LeftChildIndex(elementIndex)];}
        private int RightChild(int elementIndex) { return members[RightChildIndex(elementIndex)];}
        private int Parent(int elementIndex) { return members[ParentIndex(elementIndex)];}
    }
}
