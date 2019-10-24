using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.LinkedList
{
    public class Node<T>
    {
        public T item { get; set; }
        public Node<T> Next { get; set; }
        public Node(T item)
        {
            this.item = item;
        }
        public Node()
        {

        }
    }
}
