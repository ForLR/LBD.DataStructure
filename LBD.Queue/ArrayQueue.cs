using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBD.Queue
{
   public  class ArrayQueue<T>
    {
        private T[] items;
        private int head,tail;

        public int Size { get; private set; }
        public ArrayQueue(int capacity)
        {
            items = new T[capacity];
            this.Size = 0;
            this.head = this.tail =0;
        }

        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="item"></param>
        public void EnQueue(T item)
        {
            if (this.Size==this.items.Length)
            {
                //扩容
                ResizeCapacity(this.Size*2);
            }
            this.items[tail] = item;
            this.Size++;
            this.tail++;

        }

        /// <summary>
        /// 出队
        /// </summary>
        /// <returns></returns>
        public T DeQueue()
        {
            if (this.Size==0)
            {
                return default(T);
            }
            T item = this.items[head];
            items[head] = default(T);
            head++;
            if (head>0&&Size==items.Length/4)
            {
                ResizeCapacity(items.Length/2);
            }
            Size--;
            return item;

        }

        /// <summary>
        /// 重置大小 复制旧值到新数组 
        /// </summary>
        /// <param name="capacity"></param>
        private void ResizeCapacity(int capacity)
        {
            T[] newItem = new T[capacity];
            int index = 0;
            ///新数组长度是否大于当前
            if (capacity>items.Length)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    newItem[index++] = items[i];
                }
            }
            else 
            {
                for (int i = 0; i < capacity; i++)
                {
                    if (!items[i].Equals(default(T)))
                    {
                        newItem[index++] = items[i];
                    }
                }
                this.head = this.tail = 0;
            }
            this.items = newItem;
        }

        public void Clear()
        {
            this.items = default(T[]);
            this.Size = 0;
        }
        public bool IsEmpty() => this.Size==0;


    }
}
