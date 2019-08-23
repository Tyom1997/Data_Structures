using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class BinaryTree<T> where T:IComparable<T>
    {
        private NodeBinnary<T> root;
        public BinaryTree()
        {
            root = null;
        }
        public void Add(T data)
        {
            NodeBinnary<T> node = new NodeBinnary<T>(data);
            if (root == null)
            {
                root = node;
            }
            else
            {
                NodeBinnary<T> current = root;
                node.Parent = null;
                while(current != null)
                {
                    node.Parent = current;
                    if (current.Member.CompareTo(data)>0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            node.Parent.Left = node;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            node.Parent.Right = node;
                        }
                    }
                }
            }
        }
        public bool Contains(T value)
        {
            NodeBinnary<T> node;
            return FindWithParent(value, out node) != null;
        }
        private NodeBinnary<T> FindWithParent(T value,out NodeBinnary<T> node)
        {
            NodeBinnary<T> current = root;
            node = null;
            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    node = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    node = current;
                    current = current.Right;
                }
                else
                    break;
            }
            return current;
        }
        public void InOrder()
        {
            InOrderHelper(root);
        }
        private void InOrderHelper(NodeBinnary<T> binnary)
        {
            if (binnary != null)
            {
                InOrderHelper(binnary.Left);
                Console.Write("{0}  ",binnary.Member);
                InOrderHelper(binnary.Right);
            }
        }
        public void PreOrder()
        {
            PreOrderHelper(root);
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
            PostOrderHelper(root);
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
        public T Remove(T item)
        {
            return DeleteNode(item, root);
        }
        private T DeleteNode(T item, NodeBinnary<T> root)
        {
            int temp = root.Left.Member.CompareTo(item);
            int temp1 = root.Right.Member.CompareTo(item);
            if (root == null)
            {
                throw new Exception();
            }
            if (temp!=0)
            {
                DeleteNode(item, root.Left);
            }
            else if (temp1!=0)
            {
                DeleteNode(item, root.Right);
            }
            else if (temp == 0)
            {
                root.Left = root.Left.Left;
                Console.WriteLine(root.Left.Member);
                return root.Left.Member;
            }
            root.Right = root.Right.Right;
            Console.WriteLine(root.Right.Member);
            return root.Right.Member;
        }
    }
}
