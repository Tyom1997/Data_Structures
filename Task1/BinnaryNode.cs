using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class BinnaryNode<T> where T:IComparable<T>
    {
        private T value;
        private BinnaryNode<T> leftChild;
        private BinnaryNode<T> rightChild;
        private BinnaryNode<T> parent;
        private BinaryTree<T> tree;
        public virtual T Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public virtual BinnaryNode<T> LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        public virtual BinnaryNode<T> RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }
        public virtual BinnaryNode<T> Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public virtual BinaryTree<T> Tree
        {
            get { return tree; }
            set { tree = value; }
        }
        public BinnaryNode(T value)
        {
            this.value = value;
        }

    }
}
