using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.Stack
{
    public class ArrayStack<T>
    {
        private T[] nodes;


        private int Index { get; set; }
        public ArrayStack(int capacity)
        {
            nodes = new T[capacity];
            this.Index = 0;
        }

        public void Push(T node)
        {
            if (this.Index==this.Size)
            {
                ResizeCapacity(this.Size*2);
            }
            nodes[this.Index] = node;
            this.Index++;
        }

        public T Pop()
        {
            if (this.Size==0)return default(T);
            var result = nodes[--this.Index];
            nodes[this.Index] = default(T);
          
            if (this.Index > 0 && this.Index == this.Size / 4)
            {
                ResizeCapacity(this.Size / 2);

            }
            return result;
        }
        private void ResizeCapacity(int capacity)
        {
            T[] newNodes = new T[capacity];
            int length = capacity >= this.Size ? Size : capacity;
            for (int i = 0; i < length; i++)
            {
                newNodes[i] = nodes[i];
            }
            nodes = newNodes;
        }
        public bool IsEmtry() => this.nodes.Length == 0;
        public int Size => this.nodes.Length;
    }
}
