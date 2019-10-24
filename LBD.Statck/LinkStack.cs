using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.Stack
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> next { get; set; }
        public Node()
        {

        }
        public Node(T value)
        {
            this.Data = value;
        }
    }
    public class LinkStack<T>
    {
        public Node<T> First { get; set; }


        public int Index { get; set; }
        public LinkStack()
        {
            First = null;
            this.Index = 0;
        }

        public void Push(T value)
        {
            Node<T> oldNode = First;
            First = new Node<T>();
            First.Data = value;
            First.next = oldNode;

            this.Index++;
        }
        public T Pop()
        {
            T first = First.Data;
            First = First.next;

            this.Index--;
            return first;
        }

        

    }
}
