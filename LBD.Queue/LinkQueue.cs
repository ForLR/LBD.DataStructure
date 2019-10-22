using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.Queue
{

    public class Node<T>
    {
        public T Item { get; set; }

        public Node<T> next { get; set; }
        public Node()
        {
                
        }
        public Node(T item)
        {
            this.Item = item;
        }
    }
   public  class LinkQueue<T>
   {

        private Node<T> head,tail;

        public LinkQueue()
        {
            this.head = null;
            this.tail = null;
            this.Size = 0;
        }
        public int Size { get; set; }

        public void EnQueue(T item)
        {
            ///入队插入到尾元素
            Node<T> oldNode = tail;
            tail = new Node<T>();
            tail.Item = item;
            if (IsEmtry())
            {
                head = tail;
            }
            else
            {
                oldNode.next = tail;
            }
            this.Size++;
        }

        public T DeQueue()
        {
            if (IsEmtry())return default(T);

            //首元素出列 
            T result = head.Item;
            //出队列后 当前首元素为以前元素的next值
            head = head.next;
            Size--;
            if (IsEmtry())
            {
                tail = null;
            }

            return result;
        }

        public void clear()
        {
            this.Size = 0;
            this.head = null;
        }

        public bool IsEmtry() => Size == 0;
        

   }
}
