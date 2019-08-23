using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class NodeBinnary<T> where T:IComparable<T>
    
    {
        public T Member { get; private set; }
        public NodeBinnary<T> Parent { get; set; }
        public NodeBinnary<T> Left { get; set; }
        public NodeBinnary<T> Right { get; set; }
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
