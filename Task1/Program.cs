using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> b = new AVLTree<int>();
            b.Add(10);
            b.Add(9);
            b.Add(8);
            b.Inorder(b.Root);
            Console.WriteLine();
            b.Remove(8);
            b.Inorder(b.Root);
        }
    }
}
