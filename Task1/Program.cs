using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTree<int> avl = new BinaryTree<int>();
            //avl.Add(7);
            //avl.Add(6);
            //avl.Add(8);
            //avl.Add(5);
            //avl.InOrder();
            InsertionSort<int> ins = new InsertionSort<int>();
            int[] arr = { 6, 5, 4, 3, 2, 1 };
            ins.Sort(arr);
            ins.Show(arr);
        }
    }
}
