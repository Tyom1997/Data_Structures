using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class NodeBinnary<T> where T:IComparable<T>
    
    {
        private T member { get; set; }
        private NodeBinnary<T> parent { get; set; }
        private NodeBinnary<T> left { get; set; }
        private NodeBinnary<T> right { get; set; }
        private NodeBinnary<T> tree { get; set; }
        public AVLNodeBinnary<T> Root { get; set; }
        public virtual T Member
        {
            get { return member; }
            set { this.member = value; }
        }
        public virtual NodeBinnary<T> Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public virtual NodeBinnary<T> Left
        {
            get {return left; }
            set { left = value;}
        }
        public virtual NodeBinnary<T> Right
        {
            get { return right; }
            set { right = value; }
        }
        public virtual NodeBinnary<T> Tree
        {
            get { return tree; }
            set { tree = value; }
        }
        public NodeBinnary(T Member)
        {
            this.Member = Member;
        }
        public int CompareTo(T other)
        {
            return Member.CompareTo(other);
        }
    }
}
