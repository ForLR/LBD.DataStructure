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

        /// <summary>
        /// 标识当前元素数量
        /// </summary>
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
        /// <summary>
        /// 返回栈顶元素 但不移除
        /// </summary>
        /// <returns></returns>

        public T Peek()
        {
            if (this.Index == 0)
            {
                throw new NullReferenceException("Stack为空");
            }
            return First.Data;
        }

        public void Clear()
        {
            First.next = null;
            First.Data = default(T);
            this.Index = 0;
        }


        public bool Contains(T value)
        {
            if (value==null)
            {
                throw new  ArgumentNullException("值为空");
            }
            Node<T> temp = this.First;
            int num = 0;//防止循环链表
            while (temp.next!=null&&num<Count)
            {
                num++;
                if (temp.Data.Equals(value))
                {
                    return true;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return false;
        }
        public int Count => this.Index; 

        

    }
}
