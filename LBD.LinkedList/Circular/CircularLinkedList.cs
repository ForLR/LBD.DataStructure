using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.LinkedList.Circular
{
    public class CircularLinkedList<T>
    {
        private CirNode<T> tail;

        private CirNode<T> currentPrev;
        public int Count { get; private set; }

        /// <summary>
        /// 当前节点的元素值
        /// </summary>
        public T CurrentItem { get { return this.currentPrev.Next.item; } }

        public CircularLinkedList()
        {
            this.tail = null;
            this.Count = 0;
        }

        public bool IsEmtry() => this.tail == null;


        public CirNode<T> GetNodeByIndex(int index)
        {
            if (index < 0||index>=this.Count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出范围");
            }
            //尾节点指向首节点
            var result = this.tail.Next;
            for (int i = 0; i < index; i++)
            {
                result = result.Next;
            }
            return result;
        }

        public  void Add(T value)
        {
            CirNode<T> newNode = new CirNode<T>(value);
            if (this.tail==null)
            {
                this.tail = newNode;
                this.tail.Next = newNode;
                this.currentPrev = newNode;
            }
            else
            {
                newNode.Next = this.tail.Next;
                this.tail.Next = newNode;

                if (this.currentPrev==this.tail)
                {
                    this.currentPrev = newNode;
                }
                this.tail = newNode;

            }
            this.Count++;
        }

        public void Remove()
        {
            if (this.tail==null)
            {
                throw new NullReferenceException("链表没有任何元素");
            }
            else if(this.Count==1) //尾节点即是首节点
            {
                this.tail = null;
                this.currentPrev = null;
              
            }
            else
            {

                if (this.currentPrev.Next==this.tail)
                {
                    this.tail = this.currentPrev;
                }
                this.currentPrev.Next = this.tail.Next.Next;

            }

            this.Count --;
        }

        public void RemoveAt(int index)
        {
            if (this.tail == null)
            {
                throw new NullReferenceException("链表没有任何元素");
            }
            else if (this.Count == 1)
            {
                this.tail = null;
                this.currentPrev = null;
            }
            else
            {
                CirNode<T> nowNode = GetNodeByIndex(index-1);

                nowNode.Next = nowNode.Next.Next;
                nowNode = null;
            }
            this.Count--;

        }
        public string GetAllNodes()
        {
            if (this.Count==0)
            {
                throw new NullReferenceException("链表没有任何元素");
            }
            else
            {
                CirNode<T> nowNode = this.tail.Next;
                var result = string.Empty;
                for (int i = 0; i < this.Count; i++)
                {
                    result += nowNode.item + "  ";
                    nowNode = nowNode.Next;
                }
                return result;
            }
        }

        

    }
}
