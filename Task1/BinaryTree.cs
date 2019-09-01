using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class BinaryTree<T> where T:IComparable<T>
    {
        public enum TraversalMode
        {
            InOrder = 0,
            PostOrder,
            PreOrder
        }
        private BinnaryNode<T> head;
        private Comparison<IComparable> comparer = CompareElements;
        private int size;
        private TraversalMode traversalMode = TraversalMode.InOrder;
        public virtual BinnaryNode<T> Root
        {
            get { return head; }
            set { head = value; }
        }
        public virtual int Count
        {
            get { return size; }
        }
        public virtual TraversalMode TraversalOrder
        {
            get { return traversalMode; }
            set { traversalMode = value; }
        }
        public BinaryTree()
        {
            head = null;
            size = 0;
        }
        public virtual void Add(T value)
        {
            BinnaryNode<T> node = new BinnaryNode<T>(value);
            AddHelper(node);
        }
        public virtual void AddHelper(BinnaryNode<T> node)
        {
            if (this.head == null) 
            {
                head = node;
                node.Tree = this;
                size++;
            }
            else
            {
                if (node.Parent == null)
                    node.Parent = head;
                bool insertLeftSide = comparer((IComparable)node.Value, (IComparable)node.Parent.Value) <= 0;
                if (insertLeftSide)
                {
                    if (node.Parent.LeftChild == null)
                    {
                        node.Parent.LeftChild = node;
                        size++;
                        node.Tree = this;
                    }
                    else
                    {
                        node.Parent = node.Parent.LeftChild;
                        this.AddHelper(node);
                    }
                }
                else
                {
                    if (node.Parent.RightChild == null)
                    {
                        node.Parent.RightChild = node;
                        size++;
                        node.Tree = this;
                    }
                    else
                    {
                        node.Parent = node.Parent.RightChild;
                        this.AddHelper(node);
                    }
                }
            }
        }
        public virtual BinnaryNode<T> Find(T value)
        {
            BinnaryNode<T> node = head;
            while (node != null)
            {
                if (node.Value.Equals(value))
                    return node;
                else
                {
                    bool searchLeft = comparer((IComparable)value, (IComparable)node.Value) < 0;
                    if (searchLeft)
                        node = node.LeftChild;
                    else
                        node = node.RightChild;
                }
            }
            return null;
        }
        public virtual bool Contains(T value)
        {
            return (Find(value) != null);
        }
        public virtual void Remove(T value)
        {
            BinnaryNode<T> removeNode = Find(value);
            RemoveHelper(removeNode);
        }
        public virtual void RemoveHelper(BinnaryNode<T> removeNode)
        {
            if (removeNode == null || removeNode.Tree != this)
                Console.WriteLine("Nod not founded");
            bool wasHead = (removeNode == head);
            if (this.Count == 1)
            {
                this.head = null;
                removeNode.Tree = null;
                size--;
            }
            else if(removeNode.RightChild==null && removeNode.RightChild == null)
            {
                if(removeNode.Parent != null && removeNode.Parent.LeftChild == removeNode)
                {
                    removeNode.Parent.LeftChild = null;
                }
                else
                {
                    removeNode.Parent.RightChild = null;
                }
                removeNode.Tree = null;
                removeNode.Parent = null;
                size--;
            }
            else if ((removeNode.RightChild == null || removeNode.RightChild == null))
            {
                if (removeNode.Parent != null && removeNode.Parent.LeftChild == removeNode)
                {
                    removeNode.LeftChild.Parent = removeNode.Parent;
                    if (wasHead)
                        this.Root = removeNode.LeftChild;
                    if ((removeNode.Parent != null && removeNode.Parent.LeftChild == removeNode))
                        removeNode.Parent.LeftChild = removeNode.LeftChild;
                    else
                        removeNode.Parent.RightChild = removeNode.LeftChild;
                }
                else
                {
                    removeNode.RightChild.Parent = removeNode.Parent;
                    if (wasHead)
                        this.Root = removeNode.RightChild;
                    if ((removeNode.Parent != null && removeNode.Parent.LeftChild == removeNode))
                        removeNode.Parent.LeftChild = removeNode.RightChild;
                    else
                        removeNode.Parent.RightChild = removeNode.RightChild;
                }
                removeNode.Tree = null;
                removeNode.Parent = null;
                removeNode.LeftChild = null;
                removeNode.RightChild = null;
                size--;
            }
            else
            {
                BinnaryNode<T> successorNode = removeNode.LeftChild;
                while (successorNode.RightChild != null)
                {
                    successorNode = successorNode.RightChild;
                }
                removeNode.Value = successorNode.Value;
                RemoveHelper(successorNode);
            }
        }
        public virtual int GetHeight()
        {
            return GetHeight(this.Root);
        }
        public virtual int GetHeight(T value)
        {
            BinnaryNode<T> valueNode = this.Find(value);
            if (value != null)
                return this.GetHeight(valueNode);
            else
                return 0;
        }
        public virtual int GetHeight(BinnaryNode<T> startNode)
        {
            if (startNode == null)
                return 0;
            else
                return 1 + Math.Max(GetHeight(startNode.LeftChild), GetHeight(startNode.RightChild));
        }
        public virtual void Postorder(BinnaryNode<T> node)
        {
            if (node == null)
                return;
            Postorder(node.LeftChild);
            Postorder(node.RightChild);
            Console.Write(node.Value + " ");
        }
        public virtual void Inorder(BinnaryNode<T> node)
        {
            if (node == null)
                return;
            Inorder(node.LeftChild);
            Console.Write(node.Value + " ");
            Inorder(node.RightChild);
        }
        public virtual void Preorder(BinnaryNode<T> node)
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.Value + " ");

            /* then recur on left sutree */
            Preorder(node.LeftChild);

            /* now recur on right subtree */
            Preorder(node.RightChild);
        }
        public static int CompareElements(IComparable x, IComparable y)
        {
            return x.CompareTo(y);
        }
    }

}
