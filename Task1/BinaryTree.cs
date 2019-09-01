using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class BinaryTree<T> where T:IComparable<T>
    {
        public  NodeBinnary<T> Root { get; set; }
        private int size;
        private Comparison<IComparable> comparer = CompareElements;
        public BinaryTree()
        {
            Root = null;
            size = 0;
        }
        public virtual int Count
        {
            get { return size; }
        }
        public virtual void Add(T data)
        {
            NodeBinnary<T> node = new NodeBinnary<T>(data);
            if (Root == null)
            {
                Root = node;
                size++;
            }
            else
            {
                NodeBinnary<T> current = Root;
                while (current != null)
                {
                    node.Parent = current;
                    if (current.Member.CompareTo(data) > 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            node.Parent.Left = node;
                            size++;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            node.Parent.Right = node;
                            node.Parent = current;
                            size++;
                        }
                    }
                }
            }
        }
        public virtual bool Contains(T value)
        {
            if (this.Find(value) == null)
                return false;
            return true;
        }
        public void InOrder()
        {
            InOrderHelper(Root);
        }
        private void InOrderHelper(NodeBinnary<T> binnary)
        {
            if (binnary != null)
            {
                InOrderHelper(binnary.Left);
                Console.Write("{0}  ", binnary.Member);
                InOrderHelper(binnary.Right);
            }
        }
        public void PreOrder()
        {
            PreOrderHelper(Root);
        }
        private void PreOrderHelper(NodeBinnary<T> binnary)
        {
            if (binnary != null)
            {
                Console.Write("{0}   ", binnary.Member);
                PreOrderHelper(binnary.Left);
                PreOrderHelper(binnary.Right);
            }
        }
        public void PostOrder()
        {
            PostOrderHelper(Root);
        }
        private void PostOrderHelper(NodeBinnary<T> binnary)
        {
            if (binnary != null)
            {
                PostOrderHelper(binnary.Left);
                PostOrderHelper(binnary.Right);
                Console.Write("{0}   ", binnary.Member);
            }
        }
        private NodeBinnary<T> Next(T value)
        {
            NodeBinnary<T> current = Root, successor = null;
            while (current != null)
            {
                int val = current.Member.CompareTo(value);
                if (val > 0)
                {
                    successor = current;
                    current = current.Left;
                }
                else
                    current = current.Right;
            }
            return successor;
        }
        protected virtual NodeBinnary<T> Find(T value)
        {
            NodeBinnary<T> node = Root;
            while (node != null)
            {
                int compare = CompareElements((IComparable)value, (IComparable)node.Member);
                if (compare == 0)
                    return node;
                if (compare < 0)
                {
                    node = node.Left;
                    continue;
                }
                node = node.Right;
            }
            return null;
        }
        public int MaxDepth(AVLNodeBinnary<T> node)
        {
            if (node == null)
                return 0;
            else
            {
                int leftDepth = MaxDepth(node.Left);
                int rightDepth = MaxDepth(node.Right);
                if (leftDepth > rightDepth)
                    return (leftDepth + 1);
                else return (rightDepth + 1);
            }
        }
        public void Swap(NodeBinnary<T> first, NodeBinnary<T> second)
        {
            NodeBinnary<T> left1 = first.Left;
            NodeBinnary<T> left2 = second.Left;
            NodeBinnary<T> right1 = first.Right;
            NodeBinnary<T> right2 = second.Right;
            NodeBinnary<T> parent1 = first.Parent;
            NodeBinnary<T> parent2 = second.Parent;
            first.Left = left2;
            second.Left = left1;
            first.Right = right2;
            second.Right = right1;
            first.Parent = parent2;
            second.Parent = parent1;
        }
        public virtual void Remove(T value)
        {
            NodeBinnary<T> parentNode;
            NodeBinnary<T> foundNode = null;
            NodeBinnary<T> tree = parentNode = Root;
            while (tree != null)
            {
                
                if (value.CompareTo(tree.Member) == 0)
                {
                    foundNode = tree;
                    size--;
                    break;
                }
                else if (value.CompareTo(tree.Member) < 0)
                {
                    parentNode = tree;
                    tree = tree.Left;
                    
                }
                else if (value.CompareTo(tree.Member) > 0)
                {
                    parentNode = tree;
                    tree = tree.Right;
                }
            }
            if (foundNode == null)
            {
                throw new Exception("Node not found in binary tree");
            }
            bool leftOrRightNode = false;
            if(foundNode.Left == null && foundNode.Right == null)
            {
                if (leftOrRightNode)
                {
                    parentNode.Right = null;
                    size--;
                }
                else
                {
                    parentNode.Left = null;
                    size--;
                }
            }
            else if (foundNode.Left != null &&foundNode.Right != null)
            {
                if (leftOrRightNode)
                {
                    parentNode.Right = foundNode.Right;
                    parentNode.Right.Left = foundNode.Left;
                }
                else
                {
                    parentNode.Left = foundNode.Right;
                    parentNode.Left.Left = foundNode.Left;
                }
            }
            else if (foundNode.Left != null || foundNode.Right != null)
            {
                if (foundNode.Left != null)
                {
                    if (leftOrRightNode)
                    {
                        parentNode.Right = foundNode.Left;
                    }
                    else
                    {
                        parentNode.Left = foundNode.Left;
                    }
                }
                else
                {
                    if (leftOrRightNode)
                    {
                        parentNode.Right = foundNode.Right;
                    }
                    else
                    {
                        parentNode.Left = foundNode.Right;
                    }
                }
            }
        }
        private static int CompareElements(IComparable x, IComparable y)
        {
            return x.CompareTo(y);
        }
    }
}
