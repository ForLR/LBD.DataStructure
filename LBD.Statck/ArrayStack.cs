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

        /// <summary>
        /// 入栈 加入数组尾
        /// </summary>
        /// <param name="node"></param>

        public void Push(T node)
        {
            if (this.Index==this.Count)
            {
                ReCountCapacity(this.Count*2);
            }
            nodes[this.Index] = node;
            this.Index++;
        }

        /// <summary>
        /// 出栈  出数组尾元素
        /// </summary>
        /// <returns></returns>

        public T Pop()
        {
            if (this.Count==0)return default(T);
            var result = nodes[--this.Index];
            nodes[this.Index] = default(T);
          
            if (this.Index > 0 && this.Index == this.Count / 4)
            {
                ReCountCapacity(this.Count / 2);

            }
            return result;
        }

        /// <summary>
        /// 返回栈顶元素 但不移除
        /// </summary>
        /// <returns></returns>

        public T Peek()
        {
            if (this.Index==0)
            {
                throw new NullReferenceException("Stack为空");
            }
            return nodes[this.Index-1];
        }

        public void Clear()
        {
            this.nodes = new T[10];
            this.Index = 0;
        }

        public bool Contains(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("值为空");
            }
            for (int i = 0; i < this.Count; i++)
            {
                if (nodes[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        private void ReCountCapacity(int capacity)
        {
            T[] newNodes = new T[capacity];
            int length = capacity >= this.Count ? Count : capacity;
            for (int i = 0; i < length; i++)
            {
                newNodes[i] = nodes[i];
            }
            nodes = newNodes;
        }
        public bool IsEmtry() => this.nodes.Length == 0;
        public int Count => this.nodes.Length;
    }
}
