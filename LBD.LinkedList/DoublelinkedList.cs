using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.LinkedList
{
    /// <summary>
    /// 双向链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublelinkedList<T>
    {
        public DbNode<T> head;
        public int Count { get; set; }

        public T this[int index]
        {
            get { return GetNodeByIndex(index).item; }
            set { GetNodeByIndex(index).item = value; }
        }
        public DoublelinkedList()
        {
            this.head = null;
            this.Count = 0;
        }

        private DbNode<T> GetNodeByIndex(int index)
        {
            if (index<0&&index>=this.Count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出范围");
            }
            DbNode<T> result = this.head;
            for (int i = 0; i < index; i++)
            {
                result = result.Next;
            }
            return result;

        }

        /// <summary>
        /// 尾节点之后插入新节点
        /// </summary>
        /// <param name="value"></param>
        public void AddAfter(T value)
        {
            DbNode<T> newNode = new DbNode<T>(value);
            if (this.head==null)
            {
                this.head = newNode;
            }
            else
            {
                DbNode<T> lastNode = GetNodeByIndex(this.Count-1);
                lastNode.Next = newNode;
                newNode.Prev = lastNode;
            }
            this.Count++;
        }

        /// <summary>
        /// 尾节点之前插入
        /// </summary>
        /// <param name="value"></param>
        public void AddBefore(T value)
        {
            DbNode<T> newNode = new DbNode<T>(value);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                DbNode<T> lastNode = GetNodeByIndex(this.Count - 1);//尾节点
                DbNode<T> lastPrevNode = lastNode.Prev;//尾节点的前一个节点

                lastPrevNode.Next = newNode;
                newNode.Prev = lastPrevNode;

                newNode.Next = lastNode;
                lastNode.Prev = newNode;
            }
            this.Count++;
        }
        public void InsertAfter(int index,T value)
        {
            DbNode<T> tempNode;
            if (index==0)
            {
                if (this.head==null)
                {
                    tempNode = new DbNode<T>(value);
                    this.head = tempNode;

                }
                else
                {
                    tempNode = new DbNode<T>(value);
                    tempNode.Next = this.head;
                    this.head.Prev = tempNode;
                    this.head = tempNode;
                }
            }
            else
            {
                tempNode = new DbNode<T>(value);
                DbNode<T> indexNode = GetNodeByIndex(index);
                DbNode<T> nextIndexNode = indexNode.Next;

                indexNode.Next = tempNode;
                tempNode.Prev = indexNode;

                //是否尾节点
                if (nextIndexNode!=null)
                {
                    tempNode.Next = nextIndexNode;
                    nextIndexNode.Prev = tempNode;
                }
                
            }
            this.Count++;
        }

        public void InsertBefore(int index, T value)
        {
            DbNode<T> tempNode;
            if (index == 0)
            {
                if (this.head == null)
                {
                    tempNode = new DbNode<T>(value);
                    this.head = tempNode;
                }
                else
                {
                    tempNode = new DbNode<T>(value);
                    tempNode.Next = this.head;
                    this.head.Prev = tempNode;
                    this.head = tempNode;
                }
            }
            else
            {
                tempNode = new DbNode<T>(value);
                DbNode<T> indexNode = GetNodeByIndex(index);
                DbNode<T> prveIndexNode = indexNode.Prev;

                prveIndexNode.Next = tempNode;
                tempNode.Prev = prveIndexNode;
                tempNode.Next = indexNode;
                indexNode.Prev = tempNode;
            }
            this.Count++;
        }

        public void RemoveAt(int index)
        {
            if (index==0)
            {
                this.head = this.head.Next;
                this.head.Prev = null;
            }
            else
            {
                DbNode<T> deleteNode = GetNodeByIndex(index);
                DbNode<T> prveNode = deleteNode.Prev;
                DbNode<T> nextNode = deleteNode.Next;
                prveNode.Next = nextNode;
                if (nextNode!=null)//判断是否是尾节点
                {
                    nextNode.Prev = prveNode;
                }
                deleteNode = null;
            }
            this.Count--;
        }




    }
}
