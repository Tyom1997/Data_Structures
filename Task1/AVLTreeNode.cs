using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class AVLTreeNode<T>:BinnaryNode<T> where T:IComparable<T>
    {
        public AVLTreeNode(T value)
        : base(value)
        {
        }
        public new AVLTreeNode<T> LeftChild
        {
            get
            {
                return (AVLTreeNode<T>)base.LeftChild;
            }
            set
            {
                base.LeftChild = value;
            }
        }
        public new AVLTreeNode<T> RightChild
        {
            get
            {
                return (AVLTreeNode<T>)base.RightChild;
            }
            set
            {
                base.RightChild = value;
            }
        }
        public new AVLTreeNode<T> Parent
        {
            get
            {
                return (AVLTreeNode<T>)base.Parent;
            }
            set
            {
                base.Parent = value;
            }
        }
        
    }
}
