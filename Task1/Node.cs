using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Node<T> 
    {
        public T Member { get; set; }
        public Node<T> Next { get; set; }

    }
}
