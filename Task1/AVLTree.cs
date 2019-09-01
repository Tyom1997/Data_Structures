using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class AVLTree<T> : BinaryTree<T> where T : IComparable<T>
    {
        public new AVLTreeNode<T> Root
        {
            get
            {
                return (AVLTreeNode<T>)base.Root;
            }
            set
            {
                base.Root = value;
            }
        }
        public new AVLTreeNode<T> Find(T value)
        {
            return (AVLTreeNode<T>)base.Find(value);
        }
        public override void Add(T value)
        {
            AVLTreeNode<T> node = new AVLTreeNode<T>(value);

            base.AddHelper(node);
            AVLTreeNode<T> parentNode = node.Parent;
            while (parentNode != null)
            {
                int balance = this.GetBalance(parentNode);
                if (Math.Abs(balance) == 2)
                {
                    this.BalanceAt(parentNode, balance);
                }
                parentNode = parentNode.Parent;
            }
        }
        protected virtual void BalanceAt(AVLTreeNode<T> node, int balance)
        {
            if (balance == 2)
            {
                int rightBalance = GetBalance(node.RightChild);
                if (rightBalance == 1 || rightBalance == 0)
                {
                    RotateLeft(node);
                }
                else if (rightBalance == -1)
                {
                    RotateRight(node.RightChild);
                    RotateLeft(node);
                }
            }
            else if (balance == -2)
            {
                int leftBalance = GetBalance(node.LeftChild);
                if (leftBalance == 1)
                {
                    RotateLeft(node.LeftChild);
                    RotateRight(node);
                }
                else if (leftBalance == -1 || leftBalance == 0)
                {
                    RotateRight(node);
                }
            }
        }
        protected virtual int GetBalance(AVLTreeNode<T> root)
        {
            return this.GetHeight(root.RightChild) - this.GetHeight(root.LeftChild);
        }
        protected virtual void RotateLeft(AVLTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            AVLTreeNode<T> pivot = root.RightChild;
            if (pivot == null)
            {
                return;
            }
            else
            {
                AVLTreeNode<T> rootParent = root.Parent;
                bool isLeftChild = (rootParent != null) && rootParent.LeftChild == root;
                bool makeTreeRoot = root.Tree.Root == root;
                root.RightChild = pivot.LeftChild;
                pivot.LeftChild = root;
                root.Parent = pivot;
                pivot.Parent = rootParent;

                if (root.RightChild != null)
                {
                    root.RightChild.Parent = root;
                }
                if (makeTreeRoot)
                {
                    pivot.Tree.Root = pivot;
                }
                if (isLeftChild)
                {
                    rootParent.LeftChild = pivot;
                }
                else if (rootParent != null)
                {
                    rootParent.RightChild = pivot;
                }
            }
        }
        protected virtual void RotateRight(AVLTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            AVLTreeNode<T> pivot = root.LeftChild;
            if (pivot == null)
            {
                return;
            }
            else
            {
                AVLTreeNode<T> rootParent = root.Parent;
                bool isLeftChild = (rootParent != null) && rootParent.LeftChild == root;
                bool makeTreeRoot = root.Tree.Root == root;
                root.LeftChild = pivot.RightChild;
                pivot.RightChild = root;
                root.Parent = pivot;
                pivot.Parent = rootParent;
                if (root.LeftChild != null)
                {
                    root.LeftChild.Parent = root;
                }
                if (makeTreeRoot)
                {
                    pivot.Tree.Root = pivot;
                }
                if (isLeftChild)
                {
                    rootParent.LeftChild = pivot;
                }
                else if (rootParent != null)
                {
                    rootParent.RightChild = pivot;
                }
            }
        }
    }
}
