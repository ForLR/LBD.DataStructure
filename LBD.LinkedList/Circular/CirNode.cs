using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.LinkedList.Circular
{
    public class CirNode<T>
    {
        public CirNode<T> Next { get; set; }

       

        public T item;
        public CirNode()
        {

        }
        public CirNode(T t)
        {
            item = t;
        }

    }
}
