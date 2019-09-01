using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> avl = new BinaryTree<int>();
            avl.Add(10);
            avl.Add(9);
            avl.Add(8);
            avl.Remove(10);
            avl.InOrder();
            //tree.InOrder();
            //tree.Remove(9);
            //tree.InOrder();
        }
    }
}
