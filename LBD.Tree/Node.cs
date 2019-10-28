using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.Tree
{
    public class Node<T>
    {
        public T Data { get; set; }

        /// <summary>
        /// 左节点
        /// </summary>
        public Node<T> LeftChild { get; set; }
        /// <summary>
        /// 右节点
        /// </summary>
        public Node<T> RightChild { get; set; }

        public Node()
        {

        }
        public Node(T data)
        {
            this.Data = data;
        }
        public Node(T data,Node<T> left,Node<T> right)
        {
            this.Data = data;
            this.LeftChild = left;
            this.RightChild = right;
        }

    }
}
