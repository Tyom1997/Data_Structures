using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class LinkedList<T>
    {
        private Node<T> firstMember;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
            }
        }
        public void Addfirst(T member)
        {
            Node<T> newNode = new Node<T>();
            newNode.Member = member;
            if (firstMember == null)
            {
                firstMember = newNode;
            }
            else
            {
                newNode.Next = firstMember;
                firstMember = newNode;
            }
            count++;
        }
        public void Addlast(T member)
        {
            Node<T> newNode = new Node<T>();
            newNode.Member = member;
            if (firstMember == null)
            {
                firstMember = newNode;
            }
            else
            {
                Node<T> temp =firstMember;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            count++;
        }

        public T RemoveFirst()
        {
            if (count < 0)
            {
                throw new Exception();

            }
            var val = firstMember.Member;
            firstMember = firstMember.Next;
            count--;
            return val;
        }

        public void Reverse()
        {
            Node<T> prev = null;
            Node<T> current = firstMember;
            if (current == null)
            {
                return;
            }
            while (current!=null)
            {
                Node<T> next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            firstMember = prev;
        }
        public bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }
        public void Show()
        {
            Node<T> current = firstMember;
            while (current != null)
            {
                Console.WriteLine(current.Member);
                current = current.Next;
            }
        }
    }
}

