using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class AVLNodeBinnary<T> : NodeBinnary<T> where T : IComparable<T>
    {
        public AVLNodeBinnary(T Member) : base(Member)
        {
        }
        public new AVLNodeBinnary<T> Left
        {
            get
            {
                return (AVLNodeBinnary<T>)base.Left;
            }
            set
            {
                base.Left = value;
            }
        }
        public new AVLNodeBinnary<T> Right
        {
            get
            {
                return (AVLNodeBinnary<T>)base.Right;
            }
            set
            {
                base.Right = value;
            }
        }
        public new AVLNodeBinnary<T> Parent
        {
            get
            {
                return (AVLNodeBinnary<T>)base.Parent;
            }
            set
            {
                base.Parent = value;
            }
        }
    }
}
