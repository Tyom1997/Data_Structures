using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class AVL<T>:BinaryTree<T> where T:IComparable<T>
    {
        public new  AVLNodeBinnary<T> Root;
        public override bool Contains(T value)
        {
            return base.Contains(value);
        }
        public override void Add(T data)
        {
            base.Add(data);
            AVLNodeBinnary<T> node = new AVLNodeBinnary<T>(data);
            AVLNodeBinnary<T> parentNode = node.Parent;
            while (parentNode != null)
            {
                int balance = GetBalance(parentNode);
                if (Math.Abs(balance) == 2) 
                {
                   BalanceAt(parentNode,balance);
                }
                parentNode = parentNode.Parent;
            }
        }
        public override void Remove(T value)
        {
            base.Remove(value);
            AVLNodeBinnary<T> node = new AVLNodeBinnary<T>(value);
            AVLNodeBinnary<T> parentNode = node.Parent;
            while (parentNode != null)
            {
                int balance = this.GetBalance(parentNode);

                if (Math.Abs(balance) == 1)
                {
                    break; 
                }
                else if (Math.Abs(balance) == 2) 
                {
                    this.BalanceAt(parentNode, balance);
                }

                parentNode = parentNode.Parent;
            }
        }
        private void BalanceAt(AVLNodeBinnary<T> node, int balance)
        {
            if (balance == 2)
            {
                int rightBalance = GetBalance(node.Right);
                if (rightBalance == 1 || rightBalance == 0)
                {
                    RotateLeft(node);
                }
                else if (rightBalance == -1)
                {
                    RotateRight(node.Right);
                    RotateLeft(node);
                }
            }
            else if (balance == -2) 
            {
                int leftBalance = GetBalance(node.Left);
                if (leftBalance == 1)
                {
                    RotateLeft(node.Left);
                    RotateRight(node);
                }
                else if (leftBalance == -1 || leftBalance == 0)
                {
                    RotateRight(node);
                }
            }
        }
        private int GetBalance(AVLNodeBinnary<T> node)
        {
            return MaxDepth(node.Right) - MaxDepth(node.Left);
        }
        private void RotateLeft(AVLNodeBinnary<T> newnode)
        {
            if (newnode == null)
            {
                return;
            }
            AVLNodeBinnary<T> avlnode = newnode.Right;
            if (newnode.Right == null)
            {
                return;
            }
            else
            {
                AVLNodeBinnary<T> rootParent = newnode.Parent;
                bool isLeftChild = (rootParent != null) && rootParent.Left== newnode;
                bool makeTreeRoot = newnode.Tree.Root == newnode;
                newnode.Right = newnode.Right.Left;
                newnode.Right.Left = newnode;
                newnode.Parent =newnode.Right;
                newnode.Right.Parent = rootParent;

                if (newnode.Right != null)
                {
                    newnode.Right.Parent = newnode;
                }
                if (makeTreeRoot)
                {
                    avlnode.Tree.Root = avlnode;
                }
                if (isLeftChild)
                {
                    rootParent.Left = avlnode;
                }
                else if (rootParent != null)
                {
                    rootParent.Right = avlnode;
                }
            }
        }
        private void RotateRight(AVLNodeBinnary<T> root)
        {
            if (root == null)
            {
                return;
            }
            AVLNodeBinnary<T> avlnode = root.Left;
            if (avlnode== null)
            {
                return;
            }
            else
            {
                AVLNodeBinnary<T> rootParent = root.Parent;
                bool isLeftChild = (rootParent != null) && rootParent.Left == root;
                bool makeTreeRoot = root.Tree.Root == root;
                root.Left = avlnode.Right;
                avlnode.Right = root;
                root.Parent = avlnode;
                avlnode.Parent = rootParent;
                if (root.Left != null)
                {
                    root.Left.Parent = root;
                }
                if (makeTreeRoot)
                {
                    avlnode.Tree.Root = avlnode;
                }
                if (isLeftChild)
                {
                    rootParent.Left=avlnode;
                }
                else if (rootParent != null)
                {
                    rootParent.Right = avlnode;
                }
            }
        }
        
    }
}
