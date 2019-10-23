using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.LinkedList
{
    public class DbNode<T>
    {
        public DbNode<T> Next { get; set; }
        public DbNode<T> Prev { get; set; }
        public T item { get; set; }
        public DbNode(T item)
        {
            this.item = item;
        }
        public DbNode()
        {

        }
    }
}
