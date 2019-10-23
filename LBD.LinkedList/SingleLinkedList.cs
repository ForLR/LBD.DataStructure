using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.LinkedList
{
    /// <summary>
    /// 单项链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T>
    {
        private Node<T> head;
        public int Count { get; private set; }

        public T this[int index]
        {
            get { return GetNodeByIndex(index).item; }
            set { GetNodeByIndex(index).item = value; }
        }

        /// <summary>
        /// 获取索引位置节点    
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Node<T> GetNodeByIndex(int index)
        {
            if (index < 0||index>Count)
            {
                throw new ArgumentOutOfRangeException("index","索引超出范围");
            }

            Node<T> result = this.head;
            for (int i = 0; i < index; i++)
            {
                result = result.Next;
            }
            return result;

        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head==null)
            {
                
                head = newNode;
            }
            else
            {
                Node<T> prevNext = GetNodeByIndex(this.Count-1);
                prevNext.Next = newNode;

            }

            this.Count++;
        }
        /// <summary>
        /// 插入都指定位置节点
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void Insert(int index,T value)
        {
            Node<T> newNode = null;
            if (index<0||index>this.Count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出范围");
            }
            else if (index==0)
            {
                if (head==null)
                {
                    newNode= new Node<T>(value);
                    this.head = newNode;
                }
                else
                {
                    newNode = new Node<T>(value);
                    newNode.Next = this.head;
                    this.head = newNode;
                }
            }
            else
            {
                ///不是表头的插入  获取前一个节点 把前一个节点的next赋值给新节点的next 再修改前一个节点的next为新节点

                Node<T> prevNode = GetNodeByIndex(index-1);
                newNode = new Node<T>(value);
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
            }
            this.Count++;
        }

        public void RemoveAt(int index)
        {
            if (index==0)
            {
                this.head = this.head.Next;
            }
            else
            {
                Node<T> prevNode = GetNodeByIndex(index-1);
                if (prevNode.Next==null)
                {
                    throw new ArgumentOutOfRangeException("index", "索引超出范围");

                }
                Node<T> deleteNode = prevNode.Next;
                prevNode.Next = deleteNode.Next;
                deleteNode = null;
            }
            this.Count--;
        }
    }
}
